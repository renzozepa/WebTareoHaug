namespace ClsEntity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Usuario
    {
        protected Int32 _ID_USUARIO = 0;
        protected string _USUARIO = string.Empty;
        protected string _CLAVE = string.Empty;
        protected string _NOMBRE = string.Empty;
        protected string _APELLIDO_PATERNO = string.Empty;
        protected string _APELLIDO_MATERNO = string.Empty;
        protected string _NOMBRE_COMPLETO = string.Empty;
        protected string _EMAIL = string.Empty;
        private int _ID_PERSONAL = 0;

        public Int32 ID_USUARIO
        {
            get { return _ID_USUARIO; }
            set { _ID_USUARIO = value; }
        }

        public string USUARIO
        {
            get { return _USUARIO; }
            set { _USUARIO = value; }
        }

        public string CLAVE
        {
            get { return _CLAVE; }
            set { _CLAVE = value; }
        }

        public string NOMBRE
        {
            get { return _NOMBRE; }
            set { _NOMBRE = value; }
        }
        public string APELLIDO_PATERNO
        {
            get { return _APELLIDO_PATERNO; }
            set { _APELLIDO_PATERNO = value; }
        }

        public string APELLIDO_MATERNO
        {
            get { return _APELLIDO_MATERNO; }
            set { _APELLIDO_MATERNO = value; }
        }

        public string NOMBRE_COMPLETO
        {
            get { return _NOMBRE_COMPLETO; }
            set { _NOMBRE_COMPLETO = value; }
        }
        public string EMAIL
        {
            get { return _EMAIL; }
            set { _EMAIL = value; }
        }
        public Int32 ID_PERSONAL
        {
            get { return _ID_PERSONAL; }
            set { _ID_PERSONAL = value; }
        }
    }
}
