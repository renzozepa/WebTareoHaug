namespace ClsData
{
    using System;
    using System.Data.SqlClient;
    public class RegimenLaboral
    {
        public static SqlDataReader GetAllRegimenLaboral(string sucursal, ClsEntity.RegimenLaboral peObjRegimenLaboral)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReaderS10(sucursal," Select a.NroProyectoEsquema,b.NroEsquemaPlanilla,b.CodEsquemaPlanilla,b.Descripcion From ProyectoEsquema a " +
                                                                       " Inner Join EsquemaPlanilla b On a.NroEsquemaPlanilla = b.NroEsquemaPlanilla " +
                                                                       " Where a.CodProyecto = @CodProyecto And b.Activo = 1 " +
                                                                       " Order By 2 ",
                                                                       new SqlParameter("@CodProyecto", peObjRegimenLaboral.CodProyecto));
        }

        public static SqlDataReader GetAllRegimenLaboralxId(string sucursal, ClsEntity.RegimenLaboral peObjRegimenLaboral)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReaderS10(sucursal," Select a.NroProyectoEsquema,b.NroEsquemaPlanilla,b.CodEsquemaPlanilla,b.Descripcion From ProyectoEsquema a " +
                                                                       " Inner Join EsquemaPlanilla b On a.NroEsquemaPlanilla = b.NroEsquemaPlanilla " +
                                                                       " Where a.CodProyecto = '01002001' And b.Activo = 1 And a.NroProyectoEsquema = @NroProyectoEsquema " +
                                                                       " Order By 2 ",
                                                                       new SqlParameter("@NroProyectoEsquema", peObjRegimenLaboral.NroProyectoEsquema));
        }

    }
}
