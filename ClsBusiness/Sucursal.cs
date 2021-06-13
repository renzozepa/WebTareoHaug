namespace ClsBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    public class Sucursal
    {
        public static List<ClsEntity.Sucursal> GetSucursal(ClsEntity.Sucursal peObjSucursal)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Sucursal.getSucursal(peObjSucursal);
            List<ClsEntity.Sucursal> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Sucursal>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Sucursal loobjSucursal = new ClsEntity.Sucursal
                    {
                        ID_SUCURSAL = Convert.ToString(lodtrDataRead["ID_SUCURSAL"]),
                        DESCRIPCION = Convert.ToString(lodtrDataRead["DESCRIPCION"]),
                        ESTADO = Convert.ToBoolean(lodtrDataRead["ESTADO"]),
                        ID_USU_REG = Convert.ToInt32(lodtrDataRead["ID_USU_REG"]),
                        FECHA_REGISTRO = Convert.ToDateTime(lodtrDataRead["FECHA_REGISTRO"]).Date,
                        ID_USUARIO_MOD = Convert.ToInt32(lodtrDataRead["ID_USUARIO_MOD"]),
                        FECHA_MODIFICACION = Convert.ToDateTime(lodtrDataRead["FECHA_MODIFICACION"]).Date
                    };
                    loListRes.Add(loobjSucursal);
                }
            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static List<ClsEntity.Sucursal> GetSucursalByID(ClsEntity.Sucursal peObjSucursal)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Sucursal.getSucursalByID(peObjSucursal);
            List<ClsEntity.Sucursal> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Sucursal>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Sucursal loobjSucursal = new ClsEntity.Sucursal
                    {
                        ID_SUCURSAL = Convert.ToString(lodtrDataRead["ID_SUCURSAL"]),
                        DESCRIPCION = Convert.ToString(lodtrDataRead["DESCRIPCION"]),
                        RUC = Convert.ToString(lodtrDataRead["RUC"]),
                        ESTADO = Convert.ToBoolean(lodtrDataRead["ESTADO"]),
                        ID_USU_REG = Convert.ToInt32(lodtrDataRead["ID_USU_REG"]),
                        FECHA_REGISTRO = Convert.ToDateTime(lodtrDataRead["FECHA_REGISTRO"]).Date,
                        ID_USUARIO_MOD = Convert.ToInt32(lodtrDataRead["ID_USUARIO_MOD"]),
                        FECHA_MODIFICACION = Convert.ToDateTime(lodtrDataRead["FECHA_MODIFICACION"]).Date
                    };

                    loListRes.Add(loobjSucursal);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static List<ClsEntity.Sucursal> GetSucursalID(ClsEntity.Personal peObjPersonal)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Sucursal.getSucursalID(peObjPersonal);
            List<ClsEntity.Sucursal> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Sucursal>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Sucursal loobjSucursal = new ClsEntity.Sucursal
                    {
                        ID_SUCURSAL = Convert.ToString(lodtrDataRead["ID_SUCURSAL"]),
                        DESCRIPCION = Convert.ToString(lodtrDataRead["SUCURSAL"])
                    };
                    loListRes.Add(loobjSucursal);
                }

            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }

    }
}
