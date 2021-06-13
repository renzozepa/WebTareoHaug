using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsEntity
{
    public class Tareador
    {

        private int _ID_PERSONAL = 0;
        private string _ID_ALTERNO_FICHA = string.Empty;
        private string _NOMBRE_COMPLETO = string.Empty;

        public int ID_PERSONAL
        {
            get { return _ID_PERSONAL; }
            set { _ID_PERSONAL = value; }
        }

        public string ID_ALTERNO_FICHA
        {
            get { return _ID_ALTERNO_FICHA; }
            set { _ID_ALTERNO_FICHA = value; }
        }
        public string NOMBRE_COMPLETO
        {
            get { return _NOMBRE_COMPLETO; }
            set { _NOMBRE_COMPLETO = value; }
        }

    }
}
