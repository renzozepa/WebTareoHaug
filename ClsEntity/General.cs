namespace ClsEntity
{
    using System;
    public class General
    {
        protected Boolean _ESTADO = false;
        protected Int32 _ID_USU_REG = 0;
        protected DateTime _FECHA_REGISTRO = DateTime.Now;
        protected Int32 _ID_USUARIO_MOD = 0;
        protected string _USUARIO = string.Empty;
        protected DateTime _FECHA_MODIFICACION = DateTime.Now;

        public Boolean ESTADO
        {
            get { return _ESTADO; }
            set { _ESTADO = value; }
        }

        public Int32 ID_USU_REG
        {
            get { return _ID_USU_REG; }
            set { _ID_USU_REG = value; }
        }

        public DateTime FECHA_REGISTRO
        {
            get { return _FECHA_REGISTRO; }
            set { _FECHA_REGISTRO = value; }
        }

        public Int32 ID_USUARIO_MOD
        {
            get { return _ID_USUARIO_MOD; }
            set { _ID_USUARIO_MOD = value; }
        }

        public string USUARIO
        {
            get { return _USUARIO; }
            set { _USUARIO = value; }
        }

        public DateTime FECHA_MODIFICACION
        {
            get { return _FECHA_MODIFICACION; }
            set { _FECHA_MODIFICACION = value; }
        }
    }
}
