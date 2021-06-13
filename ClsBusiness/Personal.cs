namespace ClsBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    public class Personal
    {
        public static List<ClsEntity.Personal> GetAllPersonal(ClsEntity.Personal peObjPersonal)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Personal.GetAllPersonal(peObjPersonal);
            List<ClsEntity.Personal> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Personal>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Personal loobjPersonal = new ClsEntity.Personal
                    {
                        ID_PERSONAL = Convert.ToInt32(lodtrDataRead["ID_PERSONAL"]),
                        NOMBRE = Convert.ToString(lodtrDataRead["NOMBRE"]),
                        ID_TIPODOCUIDEN = Convert.ToString(lodtrDataRead["ID_TIPODOCUIDEN"]),
                        TIPODOCUIDEN = Convert.ToString(lodtrDataRead["TIPODOCUIDEN"]),
                        NUMERO_DOCUIDEN = Convert.ToString(lodtrDataRead["NUMERO_DOCUIDEN"]),
                        ID_SITUACION = Convert.ToInt32(lodtrDataRead["ID_SITUACION"]),
                        SITUACION = Convert.ToString(lodtrDataRead["SITUACION"]),
                        ID_PROYECTO = Convert.ToString(lodtrDataRead["ID_PROYECTO"]),
                        PROYECTO = Convert.ToString(lodtrDataRead["PROYECTO"]),
                        ID_TAREADOR = Convert.ToString(lodtrDataRead["ID_TAREADOR"]),
                        TAREADOR = Convert.ToString(lodtrDataRead["TAREADOR"]),
                        ID_CLASE_TRABAJADOR = Convert.ToInt32(lodtrDataRead["ID_CLASE_TRABAJADOR"]),
                        CLASE_TRABAJADOR = Convert.ToString(lodtrDataRead["CLASE_TRABAJADOR"])
                    };

                    loListRes.Add(loobjPersonal);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static List<ClsEntity.Personal> GetAllPersonalCesado(ClsEntity.Personal peObjPersonal)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Personal.GetAllPersonalCesado(peObjPersonal);
            List<ClsEntity.Personal> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Personal>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Personal loobjPersonal = new ClsEntity.Personal
                    {
                        ID_PERSONAL = Convert.ToInt32(lodtrDataRead["ID_PERSONAL"]),
                        NOMBRE = Convert.ToString(lodtrDataRead["NOMBRE"]),
                        ID_TIPODOCUIDEN = Convert.ToString(lodtrDataRead["ID_TIPODOCUIDEN"]),
                        TIPODOCUIDEN = Convert.ToString(lodtrDataRead["TIPODOCUIDEN"]),
                        NUMERO_DOCUIDEN = Convert.ToString(lodtrDataRead["NUMERO_DOCUIDEN"]),
                        ID_SITUACION = Convert.ToInt32(lodtrDataRead["ID_SITUACION"]),
                        SITUACION = Convert.ToString(lodtrDataRead["SITUACION"]),
                        ID_PROYECTO = Convert.ToString(lodtrDataRead["ID_PROYECTO"]),
                        PROYECTO = Convert.ToString(lodtrDataRead["PROYECTO"]),
                        ID_TAREADOR = Convert.ToString(lodtrDataRead["ID_TAREADOR"]),
                        TAREADOR = Convert.ToString(lodtrDataRead["TAREADOR"]),
                        ID_CLASE_TRABAJADOR = Convert.ToInt32(lodtrDataRead["ID_CLASE_TRABAJADOR"]),
                        CLASE_TRABAJADOR = Convert.ToString(lodtrDataRead["CLASE_TRABAJADOR"])
                    };

                    loListRes.Add(loobjPersonal);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static List<ClsEntity.Personal> GetAllPersonalTareador(ClsEntity.Personal peObjPersonal)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Personal.GetAllPersonalTareador(peObjPersonal);
            List<ClsEntity.Personal> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Personal>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Personal loobjPersonal = new ClsEntity.Personal
                    {
                        ID_PERSONAL = Convert.ToInt32(lodtrDataRead["ID_PERSONAL"]),
                        NOMBRE = Convert.ToString(lodtrDataRead["NOMBRE"]),
                        ID_TIPODOCUIDEN = Convert.ToString(lodtrDataRead["ID_TIPODOCUIDEN"]),
                        TIPODOCUIDEN = Convert.ToString(lodtrDataRead["TIPODOCUIDEN"]),
                        NUMERO_DOCUIDEN = Convert.ToString(lodtrDataRead["NUMERO_DOCUIDEN"]),
                        ID_SITUACION = Convert.ToInt32(lodtrDataRead["ID_SITUACION"]),
                        SITUACION = Convert.ToString(lodtrDataRead["SITUACION"]),
                        ID_PROYECTO = Convert.ToString(lodtrDataRead["ID_PROYECTO"]),
                        PROYECTO = Convert.ToString(lodtrDataRead["PROYECTO"]),
                        ID_TAREADOR = Convert.ToString(lodtrDataRead["ID_TAREADOR"]),
                        TAREADOR = Convert.ToString(lodtrDataRead["TAREADOR"]),
                        ID_CLASE_TRABAJADOR = Convert.ToInt32(lodtrDataRead["ID_CLASE_TRABAJADOR"]),
                        CLASE_TRABAJADOR = Convert.ToString(lodtrDataRead["CLASE_TRABAJADOR"])
                    };

                    loListRes.Add(loobjPersonal);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static List<ClsEntity.Personal> GetAllPersonalTareadorCesado(ClsEntity.Personal peObjPersonal)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Personal.GetAllPersonalTareadorCesado(peObjPersonal);
            List<ClsEntity.Personal> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Personal>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Personal loobjPersonal = new ClsEntity.Personal
                    {
                        ID_PERSONAL = Convert.ToInt32(lodtrDataRead["ID_PERSONAL"]),
                        NOMBRE = Convert.ToString(lodtrDataRead["NOMBRE"]),
                        ID_TIPODOCUIDEN = Convert.ToString(lodtrDataRead["ID_TIPODOCUIDEN"]),
                        TIPODOCUIDEN = Convert.ToString(lodtrDataRead["TIPODOCUIDEN"]),
                        NUMERO_DOCUIDEN = Convert.ToString(lodtrDataRead["NUMERO_DOCUIDEN"]),
                        ID_SITUACION = Convert.ToInt32(lodtrDataRead["ID_SITUACION"]),
                        SITUACION = Convert.ToString(lodtrDataRead["SITUACION"]),
                        ID_PROYECTO = Convert.ToString(lodtrDataRead["ID_PROYECTO"]),
                        PROYECTO = Convert.ToString(lodtrDataRead["PROYECTO"]),
                        ID_TAREADOR = Convert.ToString(lodtrDataRead["ID_TAREADOR"]),
                        TAREADOR = Convert.ToString(lodtrDataRead["TAREADOR"]),
                        ID_CLASE_TRABAJADOR = Convert.ToInt32(lodtrDataRead["ID_CLASE_TRABAJADOR"]),
                        CLASE_TRABAJADOR = Convert.ToString(lodtrDataRead["CLASE_TRABAJADOR"])
                    };

                    loListRes.Add(loobjPersonal);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }

    }
}
