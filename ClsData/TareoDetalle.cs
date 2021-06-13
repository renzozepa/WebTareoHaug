namespace ClsData
{
    using System;
    using System.Data.SqlClient;
    public class TareoDetalle
    {
        public static SqlDataReader GetTareoDetalleById(ClsEntity.TareoDetalle peObjTareoDetalle)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("LISTAR_TAREO_DETALLE",
                                                                new SqlParameter("@ID", peObjTareoDetalle.IdCabecera));
        }
        public static Int32 UpdTareoDetalleById(ClsEntity.TareoDetalle peObjTareoDetalle)
        {
            return ClsFunciones.BDFunciones.EjecutarProcedimiento("UPD_TAREO_DETALLE",
                                                                new SqlParameter("@IdDet", peObjTareoDetalle.IdDet),
                                                                new SqlParameter("@CodConcepto", peObjTareoDetalle.CodConcepto),
                                                                new SqlParameter("@CodActividad", peObjTareoDetalle.CodActividad),
                                                                new SqlParameter("@HNormales", peObjTareoDetalle.HNormales),
                                                                new SqlParameter("@HRefrigerio", peObjTareoDetalle.HRefrigerio),
                                                                new SqlParameter("@HExtras", peObjTareoDetalle.HExtras),
                                                                new SqlParameter("@HDomFeriados", peObjTareoDetalle.HDomFeriados),
                                                                new SqlParameter("@Observacion", peObjTareoDetalle.Observacion));
        }
    }
}
