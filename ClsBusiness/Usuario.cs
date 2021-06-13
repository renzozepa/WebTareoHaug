namespace ClsBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SqlClient;
    using ClsEntity;

    public class Usuario
    {
        public static List<ClsEntity.Usuario> GetUsuarioLogin(ClsEntity.Usuario peObjUsuario)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Usuario.GetUsuarioLogin(peObjUsuario);
            List<ClsEntity.Usuario> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Usuario>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Usuario loobjUsuario = new ClsEntity.Usuario();

                    loobjUsuario.ID_USUARIO = Convert.ToInt32(lodtrDataRead["ID_USUARIO"]);
                    loobjUsuario.NOMBRE = Convert.ToString(lodtrDataRead["NOMBRE"]);
                    loobjUsuario.APELLIDO_PATERNO = Convert.ToString(lodtrDataRead["APELLIDO_PATERNO"]);
                    loobjUsuario.APELLIDO_MATERNO = Convert.ToString(lodtrDataRead["APELLIDO_MATERNO"]);
                    loobjUsuario.NOMBRE_COMPLETO = Convert.ToString(lodtrDataRead["NOMBRE_COMPLETO"]);

                    loListRes.Add(loobjUsuario);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
    }
}
