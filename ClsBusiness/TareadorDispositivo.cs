namespace ClsBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    public class TareadorDispositivo
    {
        public static List<ClsEntity.TareadorDispositivo> GetAllDispositivosTareador(ClsEntity.TareadorDispositivo peObjTareadorDispositivo)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.TareadorDispositivo.GetAllDispositivosTareador(peObjTareadorDispositivo);
            List<ClsEntity.TareadorDispositivo> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.TareadorDispositivo>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.TareadorDispositivo loobjTareadorDispositivo = new ClsEntity.TareadorDispositivo
                    {
                        ID = Convert.ToInt32(lodtrDataRead["ID"]),
                        DESCRIPCION = Convert.ToString(lodtrDataRead["DESCRIPCION"]),
                        NUMERO_CELULAR = Convert.ToString(lodtrDataRead["NUMERO_CELULAR"]),
                        ID_TAREADOR = Convert.ToString(lodtrDataRead["ID_TAREADOR"]),
                        TAREADOR = Convert.ToString(lodtrDataRead["TAREADOR"]),
                        TOKEN = Convert.ToString(lodtrDataRead["TOKEN"]),
                        FECHA_SOLICITUD = Convert.ToDateTime(lodtrDataRead["FECHA_SOLICITUD"]),
                        FECHA_ALTA = Convert.ToDateTime(lodtrDataRead["FECHA_ALTA"]),
                        FECHA_VENCIMIENTO = Convert.ToDateTime(lodtrDataRead["FECHA_VENCIMIENTO"]),
                        ESTADO = Convert.ToBoolean(lodtrDataRead["ESTADO"]),
                        ID_USU_REG = Convert.ToInt32(lodtrDataRead["ID_USU_REG"]),
                        FECHA_REGISTRO = Convert.ToDateTime(lodtrDataRead["FECHA_REGISTRO"]),
                        ID_USUARIO_MOD = Convert.ToInt32(lodtrDataRead["ID_USUARIO_MOD"]),
                        FECHA_MODIFICACION = Convert.ToDateTime(lodtrDataRead["FECHA_MODIFICACION"])
                    };

                    loListRes.Add(loobjTareadorDispositivo);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static List<ClsEntity.TareadorDispositivo> GetAllDispositivosTareadorById(ClsEntity.TareadorDispositivo peObjTareadorDispositivo)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.TareadorDispositivo.GetAllDispositivosTareadorById(peObjTareadorDispositivo);
            List<ClsEntity.TareadorDispositivo> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.TareadorDispositivo>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.TareadorDispositivo loobjTareadorDispositivo = new ClsEntity.TareadorDispositivo
                    {
                        ID = Convert.ToInt32(lodtrDataRead["ID"]),
                        DESCRIPCION = Convert.ToString(lodtrDataRead["DESCRIPCION"]),
                        NUMERO_CELULAR = Convert.ToString(lodtrDataRead["NUMERO_CELULAR"]),
                        ID_TAREADOR = Convert.ToString(lodtrDataRead["ID_TAREADOR"]),
                        TAREADOR = Convert.ToString(lodtrDataRead["TAREADOR"]),
                        TOKEN = Convert.ToString(lodtrDataRead["TOKEN"]),
                        FECHA_SOLICITUD = Convert.ToDateTime(lodtrDataRead["FECHA_SOLICITUD"]),
                        FECHA_ALTA = Convert.ToDateTime(lodtrDataRead["FECHA_ALTA"]),
                        FECHA_VENCIMIENTO = Convert.ToDateTime(lodtrDataRead["FECHA_VENCIMIENTO"]),
                        ESTADO = Convert.ToBoolean(lodtrDataRead["ESTADO"]),
                        ID_USU_REG = Convert.ToInt32(lodtrDataRead["ID_USU_REG"]),
                        FECHA_REGISTRO = Convert.ToDateTime(lodtrDataRead["FECHA_REGISTRO"]),
                        ID_USUARIO_MOD = Convert.ToInt32(lodtrDataRead["ID_USUARIO_MOD"]),
                        FECHA_MODIFICACION = Convert.ToDateTime(lodtrDataRead["FECHA_MODIFICACION"])
                    };

                    loListRes.Add(loobjTareadorDispositivo);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static int UpdDispositivoTareador(ClsEntity.TareadorDispositivo peObjTareadorDispositivo)
        {
            return ClsData.TareadorDispositivo.UpdDispositivoTareador(peObjTareadorDispositivo);
        }
        public static int InsDispositivoTareador(ClsEntity.TareadorDispositivo peObjTareadorDispositivo)
        {
            return ClsData.TareadorDispositivo.InsDispositivoTareador(peObjTareadorDispositivo);
        }
        public static int ValidarExistenciaDispositivoTareador(ClsEntity.TareadorDispositivo peObjTareadorDispositivo)
        {
            return ClsData.TareadorDispositivo.ValidarExistenciaDispositivoTareador(peObjTareadorDispositivo);
        }
    }
}
