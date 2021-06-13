namespace ClsData
{
    using System.Data.SqlClient;
    public class TareadorDispositivo
    {
        public static SqlDataReader GetAllDispositivosTareador(ClsEntity.TareadorDispositivo peObjTareadorDispositivo)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("LISTAR_TAREADOR_DISPOSITIVOS",
                                                                new SqlParameter("@ID_PERSONAL", peObjTareadorDispositivo.ID_PERSONAL));
        }
        public static SqlDataReader GetAllDispositivosTareadorById(ClsEntity.TareadorDispositivo peObjTareadorDispositivo)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("LISTAR_TAREADOR_DISPOSITIVOS_ID",
                                                                new SqlParameter("@ID", peObjTareadorDispositivo.ID));
        }
        public static int UpdDispositivoTareador(ClsEntity.TareadorDispositivo peObjTareadorDispositivo)
        {
            return ClsFunciones.BDFunciones.EjecutarProcedimiento("UPD_TAREADOR_DISPISITIVO", new SqlParameter("@ID", peObjTareadorDispositivo.ID),
                                                                                           new SqlParameter("@DESCRIPCION", peObjTareadorDispositivo.DESCRIPCION),
                                                                                           new SqlParameter("@NUMERO_CELULAR", peObjTareadorDispositivo.NUMERO_CELULAR),
                                                                                           new SqlParameter("@ID_TAREADOR", peObjTareadorDispositivo.ID_TAREADOR),
                                                                                           new SqlParameter("@TOKEN", peObjTareadorDispositivo.TOKEN),
                                                                                           new SqlParameter("@FECHA_ALTA", peObjTareadorDispositivo.FECHA_ALTA),
                                                                                           new SqlParameter("@FECHA_VENCIMIENTO", peObjTareadorDispositivo.FECHA_VENCIMIENTO),
                                                                                           new SqlParameter("@ESTADO", peObjTareadorDispositivo.ESTADO),
                                                                                           new SqlParameter("@ID_USUARIO_MOD", peObjTareadorDispositivo.ID_USU_REG));
        }
        public static int InsDispositivoTareador(ClsEntity.TareadorDispositivo peObjTareadorDispositivo)
        {
            return ClsFunciones.BDFunciones.EjecutarProcedimiento("INS_TAREADOR_DISPISITIVO", new SqlParameter("@DESCRIPCION", peObjTareadorDispositivo.DESCRIPCION),
                                                                                           new SqlParameter("@NUMERO_CELULAR", peObjTareadorDispositivo.NUMERO_CELULAR),
                                                                                           new SqlParameter("@ID_TAREADOR", peObjTareadorDispositivo.ID_TAREADOR),
                                                                                           new SqlParameter("@TOKEN", peObjTareadorDispositivo.TOKEN),
                                                                                           new SqlParameter("@FECHA_SOLICITUD", peObjTareadorDispositivo.FECHA_SOLICITUD),
                                                                                           new SqlParameter("@FECHA_ALTA", peObjTareadorDispositivo.FECHA_ALTA),
                                                                                           new SqlParameter("@FECHA_VENCIMIENTO", peObjTareadorDispositivo.FECHA_VENCIMIENTO),
                                                                                           new SqlParameter("@ESTADO", peObjTareadorDispositivo.ESTADO),
                                                                                           new SqlParameter("@ID_USU_REG", peObjTareadorDispositivo.ID_USU_REG));
        }
        public static int ValidarExistenciaDispositivoTareador(ClsEntity.TareadorDispositivo peObjTareadorDispositivo)
        {
            return ClsFunciones.BDFunciones.EjecutarProcedimiento("VALIDAR_EXISTENCIA_DISPOSITIVO_TAREADOR", new SqlParameter("@ID_TAREADOR", peObjTareadorDispositivo.ID_TAREADOR),
                                                                                           new SqlParameter("@NUMERO_CELULAR", peObjTareadorDispositivo.NUMERO_CELULAR));
        }
    }
}
