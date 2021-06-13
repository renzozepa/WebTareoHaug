namespace ClsBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    public class Configuracion
    {
        public static List<ClsEntity.Configuracion> GetConfiguracionByID(ClsEntity.Configuracion peObjConfiguracion)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Configuracion.GetConfiguracionById(peObjConfiguracion);
            List<ClsEntity.Configuracion> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Configuracion>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Configuracion loobjConfiguracion = new ClsEntity.Configuracion
                    {
                        SERVIDOR = Convert.ToString(lodtrDataRead["SERVIDOR"]),
                        BASEDEDATOS = Convert.ToString(lodtrDataRead["BASEDEDATOS"]),
                        USUARIO = Convert.ToString(lodtrDataRead["USUARIO"]),
                        CLAVE = Convert.ToString(lodtrDataRead["CLAVE"]),
                        CODPROYECTO = Convert.ToString(lodtrDataRead["CODPROYECTO"])
                    };

                    loListRes.Add(loobjConfiguracion);
                }
            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static Int32 InsConfiguracion(ClsEntity.Configuracion peObjConfiguracion)
        {
            return ClsData.Configuracion.InsConfiguracion(peObjConfiguracion);
        }
    }
}
