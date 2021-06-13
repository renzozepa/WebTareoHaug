namespace ClsEntity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class TareoProcesado
    {
        protected int _ID = 0;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
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

        protected string _ID_HORARIO = string.Empty;
        public string ID_HORARIO
        {
            get { return _ID_HORARIO; }
            set { _ID_HORARIO = value; }
        }

        protected string _HORARIO = string.Empty;
        public string HORARIO
        {
            get { return _HORARIO; }
            set { _HORARIO = value; }
        }

        protected string _ID_PUESTO = string.Empty;
        public string ID_PUESTO
        {
            get { return _ID_PUESTO; }
            set { _ID_PUESTO = value; }
        }

        protected string _PUESTO = string.Empty;
        public string PUESTO
        {
            get { return _PUESTO; }
            set { _PUESTO = value; }
        }

        protected DateTime _FECHA_TAREO;
        public DateTime FECHA_TAREO
        {
            get { return _FECHA_TAREO; }
            set { _FECHA_TAREO = value; }
        }

        protected DateTime _FECHA_TAREO_REG_ING;
        public DateTime FECHA_TAREO_REG_ING
        {
            get { return _FECHA_TAREO_REG_ING; }
            set { _FECHA_TAREO_REG_ING = value; }
        }


        protected string _HORA_TAREO_REG_ING;
        public string HORA_TAREO_REG_ING
        {
            get { return _HORA_TAREO_REG_ING; }
            set { _HORA_TAREO_REG_ING = value; }
        }

        protected DateTime _FECHA_TAREO_REG_SAL_ALM;
        public DateTime FECHA_TAREO_REG_SAL_ALM
        {
            get { return _FECHA_TAREO_REG_SAL_ALM; }
            set { _FECHA_TAREO_REG_SAL_ALM = value; }
        }


        protected string _HORA_TAREO_REG_SAL_ALM;
        public string HORA_TAREO_REG_SAL_ALM
        {
            get { return _HORA_TAREO_REG_SAL_ALM; }
            set { _HORA_TAREO_REG_SAL_ALM = value; }
        }

        protected DateTime _FECHA_TAREO_REG_REG_ALM;
        public DateTime FECHA_TAREO_REG_REG_ALM
        {
            get { return _FECHA_TAREO_REG_REG_ALM; }
            set { _FECHA_TAREO_REG_REG_ALM = value; }
        }


        protected string _HORA_TAREO_REG_REG_ALM;
        public string HORA_TAREO_REG_REG_ALM
        {
            get { return _HORA_TAREO_REG_REG_ALM; }
            set { _HORA_TAREO_REG_REG_ALM = value; }
        }

        protected DateTime _FECHA_TAREO_REG_SAL;
        public DateTime FECHA_TAREO_REG_SAL
        {
            get { return _FECHA_TAREO_REG_SAL; }
            set { _FECHA_TAREO_REG_SAL = value; }
        }


        protected string _HORA_TAREO_REG_SAL;
        public string HORA_TAREO_REG_SAL
        {
            get { return _HORA_TAREO_REG_SAL; }
            set { _HORA_TAREO_REG_SAL = value; }
        }

        protected string _HORAS_TRABAJADAS_DIARIAS;
        public string HORAS_TRABAJADAS_DIARIAS
        {
            get { return _HORAS_TRABAJADAS_DIARIAS; }
            set { _HORAS_TRABAJADAS_DIARIAS = value; }
        }
        protected string _HORAS_ALMUERZO_DIARIAS;
        public string HORAS_ALMUERZO_DIARIAS
        {
            get { return _HORAS_ALMUERZO_DIARIAS; }
            set { _HORAS_ALMUERZO_DIARIAS = value; }
        }
        protected string _HORAS_PRODUCTIVAS_DIARIAS;
        public string HORAS_PRODUCTIVAS_DIARIAS
        {
            get { return _HORAS_PRODUCTIVAS_DIARIAS; }
            set { _HORAS_PRODUCTIVAS_DIARIAS = value; }
        }

        protected string _OBSERVACION;
        public string OBSERVACION
        {
            get { return _OBSERVACION; }
            set { _OBSERVACION = value; }
        }

        protected Int32 _ID_USUARIO = 0;
        protected DateTime _FECHA_REGISTRO;
        protected Int32 _ID_USUARIO_MODIFICACION = 0;
        protected DateTime _FECHA_MODIFICACION;

        public Int32 ID_USUARIO
        {
            get { return _ID_USUARIO; }
            set { _ID_USUARIO = value; }
        }
        public DateTime FECHA_REGISTRO
        {
            get { return _FECHA_REGISTRO; }
            set { _FECHA_REGISTRO = value; }
        }
        public Int32 ID_USUARIO_MODIFICACION
        {
            get { return _ID_USUARIO_MODIFICACION; }
            set { _ID_USUARIO_MODIFICACION = value; }
        }
        public DateTime FECHA_MODIFICACION
        {
            get { return _FECHA_MODIFICACION; }
            set { _FECHA_MODIFICACION = value; }
        }


    }
}
