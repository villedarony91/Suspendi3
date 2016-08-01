using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Suspendidos.Negocio
{
    public class Ciudadano : Person
    {
        public Ciudadano(String PrimerNombre, String SegundoNombre, String PrimerApellido,
            String SegundoApellido, String TercerApellido,
            String Dpi, String NroBoleta, String DeptoResidencia, String MunResidencia, String Estado, String Genero)
            : base(PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, TercerApellido)
        {

            this._Dpi = Dpi;
            this._NroBoleta = NroBoleta;
            this._DeptoResidencia = DeptoResidencia;
            this._MunResidencia = MunResidencia;
            this._Estado = Estado;
            this._Genero = Genero;
        } 
        public Ciudadano():base()
        {

        }
        private bool _Filled;

        private String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        private String _Genero;

        public String Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }
        private String _Dpi;

        public String Dpi
        {
            get { return _Dpi; }
            set { _Dpi = value; }
        }
        private String _NroBoleta;

        public String NroBoleta
        {
            get { return _NroBoleta; }
            set { _NroBoleta = value; }
        }
        private String _DeptoResidencia;

        public String DeptoResidencia
        {
            get { return _DeptoResidencia; }
            set { _DeptoResidencia = value; }
        }
        private String _MunResidencia;

        public String MunResidencia
        {
            get { return _MunResidencia; }
            set { _MunResidencia = value; }
        }

        public bool Filled
        {
            get
            {
                return _Filled;
            }

            set
            {
                _Filled = value;
            }
        }
    }
}