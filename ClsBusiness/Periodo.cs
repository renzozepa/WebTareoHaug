namespace ClsBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    public class Periodo
    {
        public static List<ClsEntity.Periodo> GetPeriodoPorRegimen(string sucursal,ClsEntity.Periodo peObjPeriodo)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Periodo.GetPeriodoPorRegimen(sucursal,peObjPeriodo);
            List<ClsEntity.Periodo> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Periodo>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Periodo loobjPeriodo = new ClsEntity.Periodo
                    {
                        NroProyectoEsquemaPeriodoTareo = Convert.ToString(lodtrDataRead["NroProyectoEsquemaPeriodoTareo"]),
                        CodProyectoEsquemaPeriodoTareo = Convert.ToString(lodtrDataRead["CodProyectoEsquemaPeriodoTareo"]),
                        NroProyectoEsquema = Convert.ToString(lodtrDataRead["NroProyectoEsquema"]),
                        Descripcion = Convert.ToString(lodtrDataRead["Descripcion"]),
                        Del = Convert.ToString(lodtrDataRead["Del"]),
                        Al = Convert.ToString(lodtrDataRead["Al"]),
                        EstadoTareo = Convert.ToString(lodtrDataRead["EstadoTareo"]),
                        AprobacionTareoUsuario = Convert.ToString(lodtrDataRead["AprobacionTareoUsuario"]),
                        AprobacionTareoFecha = Convert.ToString(lodtrDataRead["AprobacionTareoFecha"]),
                        NumeroPartes = Convert.ToString(lodtrDataRead["NumeroPartes"])
                    };
                    loListRes.Add(loobjPeriodo);
                }
            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static List<ClsEntity.Periodo> GetPeriodoDiarioPorRegimen(string sucursal, ClsEntity.Periodo peObjPeriodo)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.Periodo.GetPeriodoDiarioPorRegimen(sucursal, peObjPeriodo);
            List<ClsEntity.Periodo> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.Periodo>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.Periodo loobjPeriodo = new ClsEntity.Periodo
                    {
                        CodProyecto = Convert.ToString(lodtrDataRead["CodProyecto"]),
                        CodPeriodo = Convert.ToString(lodtrDataRead["CodPeriodo"]),
                        DesPeriodo = Convert.ToString(lodtrDataRead["Descripcion"])
                    };
                    loListRes.Add(loobjPeriodo);
                }
            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
    }
}
