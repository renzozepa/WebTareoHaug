namespace ClsEntity
{
    public class Sucursal : General
    {
        protected string _ID_SUCURSAL = string.Empty;
        protected string _DESCRIPCION = string.Empty;
        protected string _RUC = string.Empty;

        public string ID_SUCURSAL
        {
            get { return _ID_SUCURSAL; }
            set { _ID_SUCURSAL = value; }
        }

        public string DESCRIPCION
        {
            get { return _DESCRIPCION; }
            set { _DESCRIPCION = value; }
        }
        public string RUC
        {
            get { return _RUC; }
            set { _RUC = value; }
        }
    }
}
