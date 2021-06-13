namespace ClsBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    public class Tareador
    {
        public static List<ClsEntity.Tareador> GetAllTareador(ClsEntity.Tareador peObjTareador)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Tareador.GetAllTareador(peObjTareador);
            List<ClsEntity.Tareador> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Tareador>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Tareador loobjTareador = new ClsEntity.Tareador
                    {
                        ID_PERSONAL = Convert.ToInt32(lodtrDataRead["ID_PERSONAL"]),
                        ID_ALTERNO_FICHA = Convert.ToString(lodtrDataRead["ID_ALTERNO_FICHA"]),
                        NOMBRE_COMPLETO = Convert.ToString(lodtrDataRead["NOMBRE_COMPLETO"])
                    };

                    loListRes.Add(loobjTareador);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static List<ClsEntity.Tareador> GetTareadorId(ClsEntity.Tareador peObjTareador)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Tareador.GetTareadorId(peObjTareador);
            List<ClsEntity.Tareador> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Tareador>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Tareador loobjTareador = new ClsEntity.Tareador
                    {
                        ID_PERSONAL = Convert.ToInt32(lodtrDataRead["ID_PERSONAL"]),
                        ID_ALTERNO_FICHA = Convert.ToString(lodtrDataRead["ID_ALTERNO_FICHA"]),
                        NOMBRE_COMPLETO = Convert.ToString(lodtrDataRead["NOMBRE_COMPLETO"])
                    };

                    loListRes.Add(loobjTareador);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static Int32 ProcesarTareoTareador(ClsEntity.Tareador peObjTareador)
        {
            return ClsData.Tareador.ProcesarTareoTareador(peObjTareador);
        }
    }
}
