namespace ClsData
{
    using System.Data;
    using System.Data.SqlClient;
    public class Periodo
    {
        public static SqlDataReader GetPeriodoPorRegimen(string sucursal,ClsEntity.Periodo peObjPeriodo)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReaderS10(sucursal,
                                                                  " Select NroProyectoEsquemaPeriodoTareo,CodProyectoEsquemaPeriodoTareo,NroProyectoEsquema, " +
                                                                  " Descripcion, Convert(varchar(10),Del,103) As Del,Convert(varchar(10),Al,103) as Al, EstadoTareo, AprobacionTareoUsuario, AprobacionTareoFecha, NumeroPartes " +
                                                                  " From vw_15_ProyectoEsquemaPeriodoTareo " +
                                                                  " Where NroProyectoEsquema = @NroProyectoEsquema " +
                                                                  " And CodProyecto = @CodProyecto " +
                                                                  " And Anno = @Anno " +
                                                                  " Order By CodProyectoEsquemaPeriodoTareo" ,
                                                                  new SqlParameter("@NroProyectoEsquema", peObjPeriodo.NroProyectoEsquema),
                                                                  new SqlParameter("@Anno", peObjPeriodo.Anno),
                                                                  new SqlParameter("@CodProyecto", peObjPeriodo.CodProyecto));
        }
        public static SqlDataReader GetPeriodoDiarioPorRegimen(string sucursal, ClsEntity.Periodo peObjPeriodo)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReaderS10(sucursal,
                                                                  " Select CodProyecto,CodPeriodo,Descripcion From Periodo Where CodProyecto = @CodProyecto " +
                                                                  " And ( Del >= ( Select Del From vw_15_ProyectoEsquemaPeriodoTareo Where NroProyectoEsquema = @NroProyectoEsquema " +
                                                                  "              And CodProyecto = @CodProyecto And Anno = @Anno And CodProyectoEsquemaPeriodoTareo = @CodProyectoEsquemaPeriodoTareo) " +
                                                                  " And   Al <=  ( Select Al From vw_15_ProyectoEsquemaPeriodoTareo Where NroProyectoEsquema = @NroProyectoEsquema " +
                                                                  "              And CodProyecto = @CodProyecto And Anno = @Anno And CodProyectoEsquemaPeriodoTareo = @CodProyectoEsquemaPeriodoTareo ) " +
                                                                  " ) And Visible = 1 ",
                                                                  new SqlParameter("@NroProyectoEsquema", peObjPeriodo.NroProyectoEsquema),
                                                                  new SqlParameter("@Anno", peObjPeriodo.Anno),
                                                                  new SqlParameter("@CodProyecto", peObjPeriodo.CodProyecto),
                                                                  new SqlParameter("@CodProyectoEsquemaPeriodoTareo", peObjPeriodo.CodProyectoEsquemaPeriodoTareo));
        }
    }
}
