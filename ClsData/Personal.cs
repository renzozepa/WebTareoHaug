namespace ClsData
{
    using System.Data.SqlClient;
    public class Personal
    {
        public static SqlDataReader GetAllPersonal(ClsEntity.Personal peObjPersonal)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("LISTAR_PERSONAL_TAREADOR_ALL_SUCURSAL",
                                                                new SqlParameter("@ID_SUCURSAL", peObjPersonal.ID_SUCURSAL));
        }
        public static SqlDataReader GetAllPersonalCesado(ClsEntity.Personal peObjPersonal)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("LISTAR_PERSONAL_TAREADOR_ALL_CESADO_SUCURSAL",
                                                                new SqlParameter("@ID_SUCURSAL", peObjPersonal.ID_SUCURSAL));
        }
        public static SqlDataReader GetAllPersonalTareador(ClsEntity.Personal peObjPersonal)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("LISTAR_PERSONAL_TAREADOR_SUCURSAL",
                                                                new SqlParameter("@ID_TAREADOR", peObjPersonal.ID_TAREADOR),
                                                                new SqlParameter("@ID_SUCURSAL", peObjPersonal.ID_SUCURSAL));
        }
        public static SqlDataReader GetAllPersonalTareadorCesado(ClsEntity.Personal peObjPersonal)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("LISTAR_PERSONAL_TAREADOR_CESADO_SUCURSAL",
                                                                new SqlParameter("@ID_TAREADOR", peObjPersonal.ID_TAREADOR),
                                                                new SqlParameter("@ID_SUCURSAL", peObjPersonal.ID_SUCURSAL));
        }
    }
}
