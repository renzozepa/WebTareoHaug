using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsEntity
{
    public class TareadorDispositivo
    {
        protected Int32 _ID = 0;
        protected Int32 _ID_PERSONAL = 0;
        protected string _DESCRIPCION = string.Empty;
        protected string _NUMERO_CELULAR = string.Empty;
        protected string _ID_TAREADOR = string.Empty;
        protected string _TAREADOR = string.Empty;
        protected string _TOKEN = string.Empty;
        protected DateTime _FECHA_SOLICITUD;
        protected DateTime _FECHA_ALTA;
        protected DateTime _FECHA_VENCIMIENTO;
        protected Boolean _ESTADO = false;
        protected Int32 _ID_USU_REG = 0;
        protected DateTime _FECHA_REGISTRO;
        protected Int32 _ID_USUARIO_MOD = 0;
        protected DateTime _FECHA_MODIFICACION;

        public Int32 ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public Int32 ID_PERSONAL
        {
            get { return _ID_PERSONAL; }
            set { _ID_PERSONAL = value; }
        }
        public string DESCRIPCION
        {
            get { return _DESCRIPCION; }
            set { _DESCRIPCION = value; }
        }
        public string NUMERO_CELULAR
        {
            get { return _NUMERO_CELULAR; }
            set { _NUMERO_CELULAR = value; }
        }
        public string ID_TAREADOR
        {
            get { return _ID_TAREADOR; }
            set { _ID_TAREADOR = value; }
        }
        public string TAREADOR
        {
            get { return _TAREADOR; }
            set { _TAREADOR = value; }
        }
        public string TOKEN
        {
            get { return _TOKEN; }
            set { _TOKEN = value; }
        }
        public DateTime FECHA_SOLICITUD
        {
            get { return _FECHA_SOLICITUD; }
            set { _FECHA_SOLICITUD = value; }
        }
        public DateTime FECHA_ALTA
        {
            get { return _FECHA_ALTA; }
            set { _FECHA_ALTA = value; }
        }
        public DateTime FECHA_VENCIMIENTO
        {
            get { return _FECHA_VENCIMIENTO; }
            set { _FECHA_VENCIMIENTO = value; }
        }
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
        public DateTime FECHA_MODIFICACION
        {
            get { return _FECHA_MODIFICACION; }
            set { _FECHA_MODIFICACION = value; }
        }
    }
}
