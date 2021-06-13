namespace ClsEntity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Configuracion
    {
        protected string _ID_SUCURSAL = string.Empty;
        public string ID_SUCURSAL
        {
            get { return _ID_SUCURSAL; }
            set { _ID_SUCURSAL = value; }
        }

        protected string _SERVIDOR = string.Empty;
        public string SERVIDOR
        {
            get { return _SERVIDOR; }
            set { _SERVIDOR = value; }
        }

        protected string _BASEDEDATOS = string.Empty;
        public string BASEDEDATOS
        {
            get { return _BASEDEDATOS; }
            set { _BASEDEDATOS = value; }
        }

        protected string _USUARIO = string.Empty;
        public string USUARIO
        {
            get { return _USUARIO; }
            set { _USUARIO = value; }
        }

        protected string _CLAVE = string.Empty;
        public string CLAVE
        {
            get { return _CLAVE; }
            set { _CLAVE = value; }
        }

        protected string _CODPROYECTO = string.Empty;
        public string CODPROYECTO
        {
            get { return _CODPROYECTO; }
            set { _CODPROYECTO = value; }
        }

    }
}
