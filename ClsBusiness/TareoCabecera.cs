namespace ClsBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    public class TareoCabecera
    {
        public static Int32 InsTareoCabecera(ClsEntity.TareoCabecera peObjTareoCabecera)
        {
            return ClsData.TareoCabecera.InsTareoCabecera(peObjTareoCabecera);
        }
        public static Int32 DelTareoCabecera(ClsEntity.TareoCabecera peObjTareoCabecera)
        {
            return ClsData.TareoCabecera.DelTareoCabecera(peObjTareoCabecera);
        }
        public static List<ClsEntity.TareoCabecera> GetTareoCabeceraBySemanaAll(ClsEntity.TareoCabecera peObjTareoCabecera)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.TareoCabecera.GetTareoCabeceraBySemanaAll(peObjTareoCabecera);
            List<ClsEntity.TareoCabecera> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.TareoCabecera>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.TareoCabecera loobjTareoCabecera = new ClsEntity.TareoCabecera
                    {
                        Id = Convert.ToInt32(lodtrDataRead["Id"]),
                        Id_Sucursal = Convert.ToString(lodtrDataRead["Id_Sucursal"]),
                        CodProyecto = Convert.ToString(lodtrDataRead["CodProyecto"]),
                        NroProyectoEsquema = Convert.ToString(lodtrDataRead["NroProyectoEsquema"]),
                        Anno = Convert.ToInt32(lodtrDataRead["Anno"]),
                        CodProyectoEsquemaPeriodoTareo = Convert.ToString(lodtrDataRead["CodProyectoEsquemaPeriodoTareo"]),
                        CodPeriodo = Convert.ToString(lodtrDataRead["CodPeriodo"]),
                        DesPeriodo = Convert.ToString(lodtrDataRead["DesPeriodo"]),
                        CodTareador = Convert.ToString(lodtrDataRead["CodTareador"]),
                        Tareador = Convert.ToString(lodtrDataRead["Tareador"]),
                        IdUsuario = Convert.ToInt32(lodtrDataRead["IdUsuario"]),
                        Usuario = Convert.ToString(lodtrDataRead["Usuario"]),
                        FechaRegistroTareo = Convert.ToDateTime(lodtrDataRead["FechaRegistroTareo"]),
                        IdEstadoTareo = Convert.ToInt32(lodtrDataRead["IdEstadoTareo"]),
                        IdUsuarioaprobador = Convert.ToInt32(lodtrDataRead["IdUsuarioaprobador"]),
                        Usuarioaprobador = Convert.ToString(lodtrDataRead["Usuarioaprobador"]),
                        FechaAprobacion = Convert.ToDateTime(lodtrDataRead["FechaAprobacion"]),
                        IdUsuarioRRHH = Convert.ToInt32(lodtrDataRead["IdUsuarioRRHH"]),
                        UsuarioRRHH = Convert.ToString(lodtrDataRead["UsuarioRRHH"]),
                        FechaAprobacionRRHH = Convert.ToDateTime(lodtrDataRead["FechaAprobacionRRHH"])
                    };

                    loListRes.Add(loobjTareoCabecera);
                }
            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static List<ClsEntity.TareoDetalle> GetTareoDetalleById(ClsEntity.TareoDetalle peObjTareoDetalle)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.TareoDetalle.GetTareoDetalleById(peObjTareoDetalle);
            List<ClsEntity.TareoDetalle> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.TareoDetalle>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.TareoDetalle loobjTareoDetalle = new ClsEntity.TareoDetalle
                    {
                        IdDet = Convert.ToInt32(lodtrDataRead["IdDet"]),
                        IdCabecera = Convert.ToInt32(lodtrDataRead["IdCabecera"]),
                        CodTipoDocumento = Convert.ToString(lodtrDataRead["CodTipoDocumento"]),
                        TipoDocumento = Convert.ToString(lodtrDataRead["TipoDocumento"]),
                        NroDocumento = Convert.ToString(lodtrDataRead["NroDocumento"]),
                        Trabajador = Convert.ToString(lodtrDataRead["Trabajador"]),
                        IdSituacion = Convert.ToInt32(lodtrDataRead["IdSituacion"]),
                        Situacion = Convert.ToString(lodtrDataRead["Situacion"]),
                        CodProyecto = Convert.ToString(lodtrDataRead["CodProyecto"]),
                        CodConcepto = Convert.ToString(lodtrDataRead["CodConcepto"]),
                        CodActividad = Convert.ToString(lodtrDataRead["CodActividad"]),
                        HNormales = Convert.ToDecimal(lodtrDataRead["HNormales"]),
                        HRefrigerio = Convert.ToDecimal(lodtrDataRead["HRefrigerio"]),
                        HExtras = Convert.ToDecimal(lodtrDataRead["HExtras"]),
                        HDomFeriados = Convert.ToDecimal(lodtrDataRead["HDomFeriados"]),
                        Observacion = Convert.ToString(lodtrDataRead["Observacion"])
                    };
                    loListRes.Add(loobjTareoDetalle);
                }
            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static Int32 UpdTareoDetalleById(ClsEntity.TareoDetalle peObjTareoDetalle)
        {
            return ClsData.TareoDetalle.UpdTareoDetalleById(peObjTareoDetalle); 
        }

    }
}
