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


        private int _noJuzgado;

        public int NoJuzgado
        {
            get { return _noJuzgado; }
            set { _noJuzgado = value; }
        }
        private int _depJuzgado;

        public int DepJuzgado
        {
            get { return _depJuzgado; }
            set { _depJuzgado = value; }
        }
        private int _munJuzgado;

        public int MunJuzgado
        {
            get { return _munJuzgado; }
            set { _munJuzgado = value; }
        }
        private int _tipoSuspension;

        public int TipoSuspension
        {
            get { return _tipoSuspension; }
            set { _tipoSuspension = value; }
        }
        private DateTime _fecIngreso;

        public DateTime FecIngreso
        {
            get { return _fecIngreso; }
            set { _fecIngreso = value; }
        }
        private DateTime _fecEgreso;

        public DateTime FecEgreso
        {
            get { return _fecEgreso; }
            set { _fecEgreso = value; }
        }
        private DateTime _fecSuspension;

        public DateTime FecSuspension
        {
            get { return _fecSuspension; }
            set { _fecSuspension = value; }
        }
        private string _condena;

        public string Condena
        {
            get { return _condena; }
            set { _condena = value; }
        }
        private string _oficio;

        public string Oficio
        {
            get { return _oficio; }
            set { _oficio = value; }
        }
        private string _resolucion;

        public string Resolucion
        {
            get { return _resolucion; }
            set { _resolucion = value; }
        }
        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        private string _observPadron;

        public string ObservPadron
        {
            get { return _observPadron; }
            set { _observPadron = value; }
        }
    }
}