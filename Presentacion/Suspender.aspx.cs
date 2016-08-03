using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Suspendidos.Negocio;

namespace Suspendidos.Presentacion
{
    public partial class Suspender : System.Web.UI.Page
    {
        Utility util = new Utility();
        static Suspendido suspendido = new Suspendido();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                fillDepto();
                fillMun("1");
            }
            
        }

        private void fillDepto()
        {
            SuspenderBehind suspBehind = new SuspenderBehind();
            selectDepto.DataSource = suspBehind.getDeptoList();
            selectDepto.DataTextField = "deslarga";
            selectDepto.DataValueField = "deslarga";
            selectDepto.DataBind();
        }

        protected void selectDepto_ServerChange(object sender, EventArgs e)
        {
            String codDep = (selectDepto.SelectedIndex + 1).ToString();
            fillMun(codDep);

      }
        private void fillMun(String codDep)
        {
            SuspenderBehind suspBehind = new SuspenderBehind();
            selectMun.DataSource = suspBehind.getMuniList(codDep.ToString());
            selectMun.DataTextField = "deslarga";
            selectMun.DataValueField = "deslarga";
            selectMun.DataBind();
        }

        protected void btnSuspend_ServerClick(object sender, EventArgs e)
        {
            SuspenderBehind suspBehind = new SuspenderBehind();
            DateTime ingreso;
            DateTime egreso;
            bool ingresoValido = DateTime.TryParse(Ingreso.Value, out ingreso);
            bool egresoValido= DateTime.TryParse(Egreso.Value, out egreso);
            bool egresoMayorEgreso = egreso > ingreso;
            bool datesValid = ingresoValido && egresoValido && egresoMayorEgreso;
            bool validState = suspBehind.validState(Search.su.cd.NroBoleta);
            if(datesValid && validState)
            {
                Page.ClientScript.RegisterStartupScript(GetType(),
                    "", "Materialize.toast('Date validation', 3000, 'rounded');", true);
                saveSuspendidoData();

            }else{
                Page.ClientScript.RegisterStartupScript(GetType(),
                    "", "Materialize.toast('Date failed', 3000, 'rounded');", true);
            }
        }

        protected void location_Click(object sender, EventArgs e)
        {
            suspendido.DepJuzgado = selectDepto.SelectedIndex + 1;
            suspendido.MunJuzgado = selectMun.SelectedIndex + 1;
            selectDepto.Disabled = true;
            selectMun.Disabled = true;
            btn2.Disabled = true;
            enableControls();
        }

        private void enableControls()
        {
            TipoJuz.Disabled = false;
            TipoSuspension.Disabled = false;
            NoJuzgado.Disabled = false;
            Ingreso.Disabled = false;
            Egreso.Disabled = false;
            Condena.Disabled = false;
            Providencia.Disabled = false;
            Resolucion.Disabled = false;
            TextObservaciones.Disabled = false;
        }

        private bool saveSuspendidoData()
        {
            Utility utils = new Utility();
            suspendido.TipoSuspension = TipoSuspension.SelectedIndex;
            //TODO: convertir a T o J
            suspendido.TipoTJ = TipoJuz.SelectedIndex;
            int noJuzgado;
            if(!int.TryParse(NoJuzgado.Value,out noJuzgado)){
                return false;
            }
            else
            {
                suspendido.NoJuzgado = noJuzgado;
            }
            suspendido.FecIngreso = utils.convertToDate(Ingreso.Value);
            suspendido.FecEgreso = utils.convertToDate(Egreso.Value);
            suspendido.Condena = Condena.Value;
            suspendido.Oficio = Providencia.Value;
            suspendido.Resolucion = Providencia.Value;
            suspendido.Observaciones = TextObservaciones.Value;
            return true;
        }
    }
}