namespace ClsData
{
    using System;
    using System.Data.SqlClient;
    public class Configuracion
    {

        public static SqlDataReader GetConfiguracionById(ClsEntity.Configuracion peObjConfiguracion)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("LISTAR_CONFIGURACION_INTERFAZ_X_ID",
                                                                new SqlParameter("@ID_SUCURSAL", peObjConfiguracion.ID_SUCURSAL));
        } 
        public static Int32 InsConfiguracion(ClsEntity.Configuracion peObjConfiguracion)
        {
            return ClsFunciones.BDFunciones.EjecutarProcedimiento("INS_CONFIGURACION_INTERFAZ",
                                                                new SqlParameter("@ID_SUCURSAL", peObjConfiguracion.ID_SUCURSAL),
                                                                new SqlParameter("@SERVIDOR", peObjConfiguracion.SERVIDOR),
                                                                new SqlParameter("@BASEDEDATOS", peObjConfiguracion.BASEDEDATOS),
                                                                new SqlParameter("@USUARIO", peObjConfiguracion.USUARIO),
                                                                new SqlParameter("@CLAVE", peObjConfiguracion.CLAVE),
                                                                new SqlParameter("@CODPROYECTO", peObjConfiguracion.CODPROYECTO));
        }

    }
}
