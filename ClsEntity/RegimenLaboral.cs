using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsEntity
{
    public class RegimenLaboral
    {

        private string _NroProyectoEsquema = string.Empty;
        private string _NroEsquemaPlanilla = string.Empty;
        private string _CodEsquemaPlanilla = string.Empty;
        private string _Descripcion = string.Empty;
        private string _CodProyecto = string.Empty;

        public string NroProyectoEsquema
        {
            get { return _NroProyectoEsquema; }
            set { _NroProyectoEsquema = value; }
        }
        public string NroEsquemaPlanilla
        {
            get { return _NroEsquemaPlanilla; }
            set { _NroEsquemaPlanilla = value; }
        }
        public string CodEsquemaPlanilla
        {
            get { return _CodEsquemaPlanilla; }
            set { _CodEsquemaPlanilla = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public string CodProyecto
        {
            get { return _CodProyecto; }
            set { _CodProyecto = value; }
        }

    }
}

