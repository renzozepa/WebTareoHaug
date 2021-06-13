namespace ClsData
{
    using System;
    using System.Data.SqlClient;
    public class Tareador
    {
        public static SqlDataReader GetAllTareador(ClsEntity.Tareador peObjTareador)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("SP_TAREADOR");
        }
        public static SqlDataReader GetTareadorId(ClsEntity.Tareador peObjTareador)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("LISTAR_TAREADOR_ID", new SqlParameter("@ID_PERSONAL", peObjTareador.ID_PERSONAL));
        }
        public static Int32 ProcesarTareoTareador(ClsEntity.Tareador peObjTareador)
        {
            return ClsFunciones.BDFunciones.EjecutarProcedimiento("PROCESAR_TAREO_PERSONAL", new SqlParameter("@ID_TAREADOR", peObjTareador.ID_ALTERNO_FICHA));
        }
    }
}
