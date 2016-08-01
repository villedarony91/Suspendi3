using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Suspendidos.Negocio
{
    public class Person
    {
        public Person(String PrimerNombre, String SegundoNombre, 
            String PrimerApellido, String SegundoApellido, String TercerApellido)
        {
            this._PrimerNombre = PrimerNombre;
            this._SegundoNombre = SegundoNombre;
            this._PrimerApellido = PrimerApellido;
            this._SegundoApellido = SegundoApellido;
            this._TercerApellido = TercerApellido;
        }

        public Person()
        {

        }
        private String _PrimerNombre;

        public String PrimerNombre
        {
            get { return _PrimerNombre; }
            set { _PrimerNombre = value; }
        }
        private String _SegundoNombre;

        public String SegundoNombre
        {
            get { return _SegundoNombre; }
            set { _SegundoNombre = value; }
        }
        private String _PrimerApellido;

        public String PrimerApellido
        {
            get { return _PrimerApellido; }
            set { _PrimerApellido = value; }
        }
        private String _SegundoApellido;

        public String SegundoApellido
        {
            get { return _SegundoApellido; }
            set { _SegundoApellido = value; }
        }
        private String _TercerApellido;

        public String TercerApelldio
        {
            get { return _TercerApellido; }
            set { _TercerApellido = value; }
        }
    }
}