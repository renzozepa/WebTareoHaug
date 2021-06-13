namespace ClsData
{
    using System;
    using System.Data.SqlClient;
    public class TareoCabecera
    {
        public static Int32 InsTareoCabecera(ClsEntity.TareoCabecera peObjTareoCabecera)
        {
            return ClsFunciones.BDFunciones.EjecutarProcedimiento("INS_TAREO_CABECERA",
                                                                new SqlParameter("@Id_Sucursal", peObjTareoCabecera.Id_Sucursal),
                                                                new SqlParameter("@CodProyecto", peObjTareoCabecera.CodProyecto),
                                                                new SqlParameter("@NroProyectoEsquema", peObjTareoCabecera.NroProyectoEsquema),
                                                                new SqlParameter("@Anno", peObjTareoCabecera.Anno),
                                                                new SqlParameter("@CodProyectoEsquemaPeriodoTareo", peObjTareoCabecera.CodProyectoEsquemaPeriodoTareo),
                                                                new SqlParameter("@CodPeriodo", peObjTareoCabecera.CodPeriodo),
                                                                new SqlParameter("@DesPeriodo", peObjTareoCabecera.DesPeriodo),
                                                                new SqlParameter("@CodTareador", peObjTareoCabecera.CodTareador),
                                                                new SqlParameter("@IdUsuario", peObjTareoCabecera.IdUsuario));
        }
        public static Int32 DelTareoCabecera(ClsEntity.TareoCabecera peObjTareoCabecera)
        {
            return ClsFunciones.BDFunciones.EjecutarProcedimiento("DEL_TAREO_CABECERA",
                                                                new SqlParameter("@Id", peObjTareoCabecera.Id));
        }
        public static SqlDataReader GetTareoCabeceraBySemanaAll(ClsEntity.TareoCabecera peObjTareoCabecera)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("LISTAR_TAREO_CABECERA",
                                                                new SqlParameter("@Id_Sucursal", peObjTareoCabecera.Id_Sucursal),
                                                                new SqlParameter("@CodProyecto", peObjTareoCabecera.CodProyecto),
                                                                new SqlParameter("@NroProyectoEsquema", peObjTareoCabecera.NroProyectoEsquema),
                                                                new SqlParameter("@Anno", peObjTareoCabecera.Anno),
                                                                new SqlParameter("@CodProyectoEsquemaPeriodoTareo", peObjTareoCabecera.CodProyectoEsquemaPeriodoTareo));
        }
    }
}
