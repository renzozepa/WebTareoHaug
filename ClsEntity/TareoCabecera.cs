namespace ClsEntity
{
    using System;
    public class TareoCabecera
    {
        protected int _Id = 0;
        protected string _Id_Sucursal = string.Empty;
        protected string _CodProyecto = string.Empty;
        protected string _NroProyectoEsquema = string.Empty;
        protected int _Anno = 0;
        protected string _CodProyectoEsquemaPeriodoTareo = string.Empty;
        protected string _CodPeriodo = string.Empty;
        protected string _DesPeriodo = string.Empty;
        protected string _CodTareador = string.Empty;
        protected string _Tareador = string.Empty;
        protected int _IdUsuario = 0;
        protected string _Usuario = string.Empty;
        protected DateTime? _FechaRegistroTareo;
        protected int _IdEstadoTareo = 0;
        protected int _IdUsuarioaprobador = 0;
        protected string _Usuarioaprobador = string.Empty;
        protected DateTime? _FechaAprobacion;
        protected int _IdUsuarioRRHH = 0;
        protected string _UsuarioRRHH = string.Empty;
        protected DateTime? _FechaAprobacionRRHH;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Id_Sucursal
        {
            get { return _Id_Sucursal; }
            set { _Id_Sucursal = value; }
        }
        public string CodProyecto
        {
            get { return _CodProyecto; }
            set { _CodProyecto = value; }
        }
        public string NroProyectoEsquema
        {
            get { return _NroProyectoEsquema; }
            set { _NroProyectoEsquema = value; }
        }
        public int Anno
        {
            get { return _Anno; }
            set { _Anno = value; }
        }
        public string CodProyectoEsquemaPeriodoTareo
        {
            get { return _CodProyectoEsquemaPeriodoTareo; }
            set { _CodProyectoEsquemaPeriodoTareo = value; }
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
        public string CodTareador
        {
            get { return _CodTareador; }
            set { _CodTareador = value; }
        }
        public string Tareador
        {
            get { return _Tareador; }
            set { _Tareador = value; }
        }
        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public DateTime? FechaRegistroTareo
        {
            get { return _FechaRegistroTareo; }
            set { _FechaRegistroTareo = value; }
        }
        public int IdEstadoTareo
        {
            get { return _IdEstadoTareo; }
            set { _IdEstadoTareo = value; }
        }
        public int IdUsuarioaprobador
        {
            get { return _IdUsuarioaprobador; }
            set { _IdUsuarioaprobador = value; }
        }
        public string Usuarioaprobador
        {
            get { return _Usuarioaprobador; }
            set { _Usuarioaprobador = value; }
        }
        public DateTime? FechaAprobacion
        {
            get { return _FechaAprobacion; }
            set { _FechaAprobacion = value; }
        }
        public int IdUsuarioRRHH
        {
            get { return _IdUsuarioRRHH; }
            set { _IdUsuarioRRHH = value; }
        }
        public string UsuarioRRHH
        {
            get { return _UsuarioRRHH; }
            set { _UsuarioRRHH = value; }
        }
        public DateTime? FechaAprobacionRRHH
        {
            get { return _FechaAprobacionRRHH; }
            set { _FechaAprobacionRRHH = value; }
        }

    }
}
