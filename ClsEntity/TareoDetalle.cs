using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsEntity
{
    public class TareoDetalle
    {
        protected int _IdDet = 0;
        protected int _IdCabecera = 0;
        protected string _CodTipoDocumento = string.Empty;
        protected string _TipoDocumento = string.Empty;
        protected string _NroDocumento = string.Empty;
        protected string _Trabajador = string.Empty;
        protected int _IdSituacion = 0;
        protected string _Situacion = string.Empty;
        protected string _CodProyecto = string.Empty;
        protected string _CodConcepto = string.Empty;
        protected string _CodActividad = string.Empty;
        protected Decimal _HNormales = 0;
        protected Decimal _HRefrigerio = 0;
        protected Decimal _HExtras = 0;
        protected Decimal _HDomFeriados = 0;
        protected string _Observacion = string.Empty;

        public int IdDet
        {
            get { return _IdDet; }
            set { _IdDet = value; }
        }
        public int IdCabecera
        {
            get { return _IdCabecera; }
            set { _IdCabecera = value; }
        }
        public string CodTipoDocumento
        {
            get { return _CodTipoDocumento; }
            set { _CodTipoDocumento = value; }
        }
        public string TipoDocumento
        {
            get { return _TipoDocumento; }
            set { _TipoDocumento = value; }
        }
        public string NroDocumento
        {
            get { return _NroDocumento; }
            set { _NroDocumento = value; }
        }
        public string Trabajador
        {
            get { return _Trabajador; }
            set { _Trabajador = value; }
        }
        public int IdSituacion
        {
            get { return _IdSituacion; }
            set { _IdSituacion = value; }
        }
        public string Situacion
        {
            get { return _Situacion; }
            set { _Situacion = value; }
        }
        public string CodProyecto
        {
            get { return _CodProyecto; }
            set { _CodProyecto = value; }
        }
        public string CodConcepto
        {
            get { return _CodConcepto; }
            set { _CodConcepto = value; }
        }
        public string CodActividad
        {
            get { return _CodActividad; }
            set { _CodActividad = value; }
        }
        public Decimal HNormales
        {
            get { return _HNormales; }
            set { _HNormales = value; }
        }
        public Decimal HRefrigerio
        {
            get { return _HRefrigerio; }
            set { _HRefrigerio = value; }
        }
        public Decimal HExtras
        {
            get { return _HExtras; }
            set { _HExtras = value; }
        }
        public Decimal HDomFeriados
        {
            get { return _HDomFeriados; }
            set { _HDomFeriados = value; }
        }
        public string Observacion
        {
            get { return _Observacion; }
            set { _Observacion = value; }
        }


    }
}
