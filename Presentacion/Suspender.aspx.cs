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

            }else{
                Page.ClientScript.RegisterStartupScript(GetType(),
                    "", "Materialize.toast('Date failed', 3000, 'rounded');", true);
            }
        }
    }
}