using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Suspendidos.Negocio;

namespace Suspendidos.Presentacion
{
    public partial class NestedMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if(Search.su != null && Search.su.cd != null)
                {
                    Ciudadano cd = Search.su.cd;
                    Estado.Value = cd.Estado;
                    Boleta.Value = cd.NroBoleta;
                    Dpi.Value = cd.Dpi;
                    firstName.Value = cd.PrimerNombre;
                    SecondName.Value = cd.SegundoNombre;
                    LastName1.Value = cd.PrimerApellido;
                    LastName2.Value = cd.SegundoApellido;
                    LastName3.Value = cd.TercerApelldio;
                }
                else
                {
                    Response.Redirect("Search.aspx");
                }

            }
        }

        public string getBoleta() { return this.Boleta.Value; }
    }
}