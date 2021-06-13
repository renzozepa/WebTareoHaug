using System;
using System.Data;
using System.Data.SqlClient;

namespace ClsFunciones
{
    public class BDFunciones
    {
        public static string Conexion()
        {
            System.Xml.XmlDocument obj = new System.Xml.XmlDocument();
            obj.Load(System.AppDomain.CurrentDomain.BaseDirectory + @"\App_Xml\configuration.xml");
            string str;
            return str = obj.GetElementsByTagName("conexion")[0].InnerXml.ToString();
        }
        public static string ConexionS10()
        {
            System.Xml.XmlDocument obj = new System.Xml.XmlDocument();
            obj.Load(System.AppDomain.CurrentDomain.BaseDirectory + @"\App_Xml\configuration.xml");
            string str;
            return str = obj.GetElementsByTagName("conexion_s10")[0].InnerXml.ToString();
        }
        public static string ConexionS10Dinamico(string sucursal)
        {
            string str = string.Empty;
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = EjecutarDataReader("LISTAR_CONFIGURACION_INTERFAZ_X_ID", new SqlParameter("@ID_SUCURSAL", sucursal));
            if ((lodtrDataRead.HasRows))
            {
                while ((lodtrDataRead.Read()))
                {
                    str = "server="+ Convert.ToString(lodtrDataRead["SERVIDOR"]) + ";database=" + Convert.ToString(lodtrDataRead["BASEDEDATOS"]) + ";uid=" + Convert.ToString(lodtrDataRead["USUARIO"]) + ";pwd=" + Convert.ToString(lodtrDataRead["CLAVE"]) + ";Connection Timeout=120";
                }
            }                
            return str;
        }
        private static void AgregaParametros(ref SqlCommand Commando, ref SqlParameter[] Parametros)
        {
            if (Parametros.Length > 0 && Parametros != null)
            {
                foreach (SqlParameter Parametro in Parametros)
                {
                    Commando.Parameters.Add(Parametro);
                }
            }
        }
        public static DataSet EjecutarDataSet(string NombreSP, params SqlParameter[] Parametros)
        {

            SqlConnection Conex = new SqlConnection(Conexion());
            Conex.Open();

            SqlTransaction Tran = default(SqlTransaction);
            Tran = Conex.BeginTransaction();

            SqlCommand Cmd = new SqlCommand();
            try
            {
                var _with1 = Cmd;
                _with1.Connection = Conex;
                _with1.Transaction = Tran;
                _with1.CommandText = NombreSP;
                _with1.CommandType = CommandType.StoredProcedure;
                _with1.CommandTimeout = 0;

                AgregaParametros(ref Cmd, ref Parametros);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd;

                DataSet ds = new DataSet();
                da.Fill(ds);

                Tran.Commit();
                return ds;

            }
            catch (Exception ex)
            {
                Tran.Rollback();
                throw new Exception(NombreSP + System.Environment.NewLine + " Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (Conex.State == ConnectionState.Open)
                    Conex.Close();
                Conex.Dispose();
            }

        }
        public static int EjecutarProcedimiento(string NombreSP, params SqlParameter[] Parametros)
        {
            SqlConnection Conex = new SqlConnection(Conexion());
            Conex.Open();

            SqlTransaction Tran = default(SqlTransaction);
            Tran = Conex.BeginTransaction();

            SqlCommand Cmd = new SqlCommand();
            int Filas = 0;

            try
            {
                var _with1 = Cmd;
                _with1.Connection = Conex;
                _with1.Transaction = Tran;
                _with1.CommandText = NombreSP;
                _with1.CommandType = CommandType.StoredProcedure;
                _with1.CommandTimeout = 0;

                AgregaParametros(ref Cmd, ref Parametros);

                Filas = Convert.ToInt32(Cmd.ExecuteScalar());
                Tran.Commit();

                return Filas;

            }
            catch (Exception ex)
            {
                Tran.Rollback();
                throw new Exception(NombreSP + System.Environment.NewLine + " Error: " + ex.Message);
            }
            finally
            {
                if (Conex.State == ConnectionState.Open)
                    Conex.Close();
                Conex.Dispose();
            }

        }
        public static String EjecutarProcedimientoS(string NombreSP, params SqlParameter[] Parametros)
        {
            SqlConnection Conex = new SqlConnection(Conexion());
            Conex.Open();

            SqlTransaction Tran = default(SqlTransaction);
            Tran = Conex.BeginTransaction();

            SqlCommand Cmd = new SqlCommand();
            string Filas = string.Empty;

            try
            {
                var _with1 = Cmd;
                _with1.Connection = Conex;
                _with1.Transaction = Tran;
                _with1.CommandText = NombreSP;
                _with1.CommandType = CommandType.StoredProcedure;
                _with1.CommandTimeout = 0;

                AgregaParametros(ref Cmd, ref Parametros);

                Filas = Convert.ToString(Cmd.ExecuteScalar());
                Tran.Commit();

                return Filas;

            }
            catch (Exception ex)
            {
                Tran.Rollback();
                throw new Exception(NombreSP + System.Environment.NewLine + " Error: " + ex.Message);
            }
            finally
            {
                if (Conex.State == ConnectionState.Open)
                    Conex.Close();
                Conex.Dispose();
            }

        }
        public static SqlDataReader EjecutarDataReader(string NombreSP, params SqlParameter[] Parametros)
        {
            SqlConnection Conex = null;
            SqlDataReader dr = default(SqlDataReader);
            SqlCommand Cmd = default(SqlCommand);
            try
            {
                Conex = new SqlConnection
                {
                    ConnectionString = Conexion()
                };
                Conex.Open();

                Cmd = new SqlCommand(NombreSP, Conex)
                {
                    CommandType = CommandType.StoredProcedure
                };
                AgregaParametros(ref Cmd, ref Parametros);
                dr = Cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("Proc: " + NombreSP + System.Environment.NewLine + " Error: " + ex.Message);
                return null;
            }
            finally
            {
                //If Conex.State = ConnectionState.Open Then Conex.Close()
                //Conex.Dispose()
            }
            return dr;
        }
        public static SqlDataReader EjecutarDataReaderText(string query)
        {
            SqlConnection Conex = null;
            SqlDataReader dr = default(SqlDataReader);
            SqlCommand Cmd = default(SqlCommand);
            try
            {
                Conex = new SqlConnection();
                Conex.ConnectionString = Conexion();
                Conex.Open();

                Cmd = new SqlCommand(query, Conex);
                Cmd.CommandType = CommandType.Text;
                //AgregaParametros(ref Cmd, ref Parametros);
                dr = Cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("Proc: " + query + System.Environment.NewLine + " Error: " + ex.Message);
                return null;
            }
            finally
            {
                //If Conex.State = ConnectionState.Open Then Conex.Close()
                //Conex.Dispose()
            }
            return dr;
        }
        public static DataSet EjecutarDataSetText(string query)
        {

            SqlConnection Conex = new SqlConnection(Conexion());
            Conex.Open();

            SqlTransaction Tran = default(SqlTransaction);
            Tran = Conex.BeginTransaction();

            SqlCommand Cmd = new SqlCommand();
            try
            {
                var _with1 = Cmd;
                _with1.Connection = Conex;
                _with1.Transaction = Tran;
                _with1.CommandText = query;
                _with1.CommandType = CommandType.Text;
                _with1.CommandTimeout = 0;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd;

                DataSet ds = new DataSet();
                da.Fill(ds);

                Tran.Commit();
                return ds;

            }
            catch (Exception ex)
            {
                Tran.Rollback();
                throw new Exception("Proc: " + query + System.Environment.NewLine + " Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (Conex.State == ConnectionState.Open)
                    Conex.Close();
                Conex.Dispose();
            }

        }
        public static SqlDataReader EjecutarDataReaderTextS10(string sucursal,string query)
        {
            SqlConnection Conex = null;
            SqlDataReader dr = default(SqlDataReader);
            SqlCommand Cmd = default(SqlCommand);
            try
            {
                Conex = new SqlConnection
                {
                    ConnectionString = ConexionS10Dinamico(sucursal)
                };
                Conex.Open();

                Cmd = new SqlCommand(query, Conex)
                {
                    CommandType = CommandType.Text
                };
                //AgregaParametros(ref Cmd, ref Parametros);
                dr = Cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("Proc: " + query + System.Environment.NewLine + " Error: " + ex.Message);
                return null;
            }
            finally
            {
                //If Conex.State = ConnectionState.Open Then Conex.Close()
                //Conex.Dispose()
            }
            return dr;
        }
        public static SqlDataReader EjecutarDataReaderS10(string sucursal,string NombreSP, params SqlParameter[] Parametros)
        {
            SqlConnection Conex = null;
            SqlDataReader dr = default(SqlDataReader);
            SqlCommand Cmd = default(SqlCommand);
            try
            {
                Conex = new SqlConnection
                {
                    ConnectionString = ConexionS10Dinamico(sucursal)
                };
                Conex.Open();

                Cmd = new SqlCommand(NombreSP, Conex)
                {
                    CommandType = CommandType.Text
                };
                AgregaParametros(ref Cmd, ref Parametros);
                dr = Cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("Proc: " + NombreSP + System.Environment.NewLine + " Error: " + ex.Message);
                return null;
            }
            finally
            {
                //If Conex.State = ConnectionState.Open Then Conex.Close()
                //Conex.Dispose()
            }
            return dr;
        }

    }
}
