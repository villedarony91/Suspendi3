using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Suspendidos.Negocio
{
    public class Suspendido : Ciudadano
    {
        public Suspendido()
        {

        }

        private int _TipoTJ;
        private int _noJuzgado;
        private int _depJuzgado;
        private int _munJuzgado;
        private int _tipoSuspension;
        private DateTime _fecIngreso;
        private DateTime _fecEgreso;
        private DateTime _fecSuspension;
        private string _observaciones;
        private string _observPadron;
        private string _resolucion;
        private string _condena;
        private string _oficio;

        public int TipoTJ
        {
            get { return _TipoTJ; }
            set { _TipoTJ = value; }
        }

        

        public int NoJuzgado
        {
            get { return _noJuzgado; }
            set { _noJuzgado = value; }
        }
        

        public int DepJuzgado
        {
            get { return _depJuzgado; }
            set { _depJuzgado = value; }
        }
        

        public int MunJuzgado
        {
            get { return _munJuzgado; }
            set { _munJuzgado = value; }
        }
        

        public int TipoSuspension
        {
            get { return _tipoSuspension; }
            set { _tipoSuspension = value; }
        }
        

        public DateTime FecIngreso
        {
            get { return _fecIngreso; }
            set { _fecIngreso = value; }
        }
        

        public DateTime FecEgreso
        {
            get { return _fecEgreso; }
            set { _fecEgreso = value; }
        }
        

        public DateTime FecSuspension
        {
            get { return _fecSuspension; }
            set { _fecSuspension = value; }
        }
        

        public string Condena
        {
            get { return _condena; }
            set { _condena = value; }
        }
        

        public string Oficio
        {
            get { return _oficio; }
            set { _oficio = value; }
        }
        

        public string Resolucion
        {
            get { return _resolucion; }
            set { _resolucion = value; }
        }
        

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        

        public string ObservPadron
        {
            get { return _observPadron; }
            set { _observPadron = value; }
        }
    }
}