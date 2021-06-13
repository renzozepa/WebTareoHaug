namespace ClsEntity
{
    using System;
    using System.Data;

    public class Periodo
    {
        private string _NroProyectoEsquemaPeriodoTareo = string.Empty;
        private string _CodProyectoEsquemaPeriodoTareo = string.Empty;
        private string _NroProyectoEsquema = string.Empty;
        private string _Descripcion = string.Empty;
        private string _Anno = string.Empty;
        private string _Del = string.Empty;
        private string _Al = string.Empty;
        private string _EstadoTareo = string.Empty;
        private string _AprobacionTareoUsuario = string.Empty;
        private string _AprobacionTareoFecha = string.Empty;
        private string _NumeroPartes = string.Empty;
        private string _CodProyecto = string.Empty;
        private string _CodPeriodo = string.Empty;
        private string _DesPeriodo = string.Empty;

        public string NroProyectoEsquemaPeriodoTareo
        {
            get { return _NroProyectoEsquemaPeriodoTareo; }
            set { _NroProyectoEsquemaPeriodoTareo = value; }
        }
        public string CodProyectoEsquemaPeriodoTareo
        {
            get { return _CodProyectoEsquemaPeriodoTareo; }
            set { _CodProyectoEsquemaPeriodoTareo = value; }
        }
        public string NroProyectoEsquema
        {
            get { return _NroProyectoEsquema; }
            set { _NroProyectoEsquema = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public string Anno
        {
            get { return _Anno; }
            set { _Anno = value; }
        }
        public string Del
        {
            get { return _Del; }
            set { _Del = value; }
        }
        public string Al
        {
            get { return _Al; }
            set { _Al = value; }
        }
        public string EstadoTareo
        {
            get { return _EstadoTareo; }
            set { _EstadoTareo = value; }
        }
        public string AprobacionTareoUsuario
        {
            get { return _AprobacionTareoUsuario; }
            set { _AprobacionTareoUsuario = value; }
        }
        public string AprobacionTareoFecha
        {
            get { return _AprobacionTareoFecha; }
            set { _AprobacionTareoFecha = value; }
        }
        public string NumeroPartes
        {
            get { return _NumeroPartes; }
            set { _NumeroPartes = value; }
        }
        public string CodProyecto
        {
            get { return _CodProyecto; }
            set { _CodProyecto= value; }
        }
        public string CodPeriodo
        {
            get { return _CodPeriodo; }
            set { _CodPeriodo = value; }
        }
        public string DesPeriodo
        {
            get { return _DesPeriodo; }
            set { _DesPeriodo = value; }
        }


    }
}
