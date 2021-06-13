namespace ClsData
{
    using System.Data.SqlClient;
    public class Sucursal
    {
        public static SqlDataReader getSucursal(ClsEntity.Sucursal peObjSucursal)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("SP_SUCURSAL_LIST");
        }

        public static SqlDataReader getSucursalByID(ClsEntity.Sucursal peObjSucursal)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("GET_SUCUR_ID", new SqlParameter("@ID_SUCURSAL", peObjSucursal.ID_SUCURSAL));
        }

        public static SqlDataReader getSucursalID(ClsEntity.Personal peObjPersonal)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("GET_SUCURSAL_ID", new SqlParameter("@ID_PERSONAL", peObjPersonal.ID_PERSONAL));
        }
    }
}
