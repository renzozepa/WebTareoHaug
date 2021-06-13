namespace ClsEntity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Personal
    {
        protected int _ID_PERSONAL = 0;
        public int ID_PERSONAL
        {
            get { return _ID_PERSONAL; }
            set { _ID_PERSONAL = value; }
        }

        protected string _NOMBRE = string.Empty;
        public string NOMBRE
        {
            get { return _NOMBRE; }
            set { _NOMBRE = value; }
        }

        protected string _ID_TIPODOCUIDEN = string.Empty;
        public string ID_TIPODOCUIDEN
        {
            get { return _ID_TIPODOCUIDEN; }
            set { _ID_TIPODOCUIDEN = value; }
        }

        protected string _TIPODOCUIDEN = string.Empty;
        public string TIPODOCUIDEN
        {
            get { return _TIPODOCUIDEN; }
            set { _TIPODOCUIDEN = value; }
        }

        protected string _NUMERO_DOCUIDEN = string.Empty;
        public string NUMERO_DOCUIDEN
        {
            get { return _NUMERO_DOCUIDEN; }
            set { _NUMERO_DOCUIDEN = value; }
        }
        protected int _ID_SITUACION = 0;
        public int ID_SITUACION
        {
            get { return _ID_SITUACION; }
            set { _ID_SITUACION = value; }
        }

        protected string _SITUACION = string.Empty;
        public string SITUACION
        {
            get { return _SITUACION; }
            set { _SITUACION = value; }
        }

        protected string _ID_PROYECTO = string.Empty;
        public string ID_PROYECTO
        {
            get { return _ID_PROYECTO; }
            set { _ID_PROYECTO = value; }
        }

        protected string _PROYECTO = string.Empty;
        public string PROYECTO
        {
            get { return _PROYECTO; }
            set { _PROYECTO = value; }
        }

        protected string _ID_TAREADOR = string.Empty;
        public string ID_TAREADOR
        {
            get { return _ID_TAREADOR; }
            set { _ID_TAREADOR = value; }
        }

        protected string _TAREADOR = string.Empty;
        public string TAREADOR
        {
            get { return _TAREADOR; }
            set { _TAREADOR = value; }
        }

        protected int _ID_CLASE_TRABAJADOR = 0;
        public int ID_CLASE_TRABAJADOR
        {
            get { return _ID_CLASE_TRABAJADOR; }
            set { _ID_CLASE_TRABAJADOR = value; }
        }

        protected string _CLASE_TRABAJADOR = string.Empty;
        public string CLASE_TRABAJADOR
        {
            get { return _CLASE_TRABAJADOR; }
            set { _CLASE_TRABAJADOR = value; }
        }

        protected string _ID_SUCURSAL = string.Empty;
        public string ID_SUCURSAL
        {
            get { return _ID_SUCURSAL; }
            set { _ID_SUCURSAL = value; }
        }

    }
}
