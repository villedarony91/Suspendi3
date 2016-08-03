using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Suspendidos.Negocio;

namespace Suspendidos
{
    public partial class Search : System.Web.UI.Page
    {
        public static SearchUtils su;
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        public void searchEvent(object sender, EventArgs e)
        {
            su = new SearchUtils();
            string query = getStringToSearch();
            int rows = 0;
            rows = su.getCitizenInfo(query);
            if (rows == 1)
            {
                if (su.cd != null) { fillFields(su.cd); }
            }
            if (rows == 0)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), 
                    "","Materialize.toast('No se encontraron registros', 3000, 'rounded');",true);
                cleanFields();
            }
            if (rows > 1)
            {
                Page.ClientScript.RegisterStartupScript(GetType(),
                   "", "Materialize.toast('El registro no es único proceda a buscar por boleta', 3000, 'rounded');", true);
                cleanFields();
            }
        }

        private String getStringToSearch()
        {
            int boleta = 0;
            Int64 dpi = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("");
            sb.Append("SELECT tpadron.NROBOLETA AS BOLETA,")
                 .Append("FECINSCRIPCION AS FECHA_INS, NOM1 AS P_NOMBRE, NOM2 AS S_NOMBRE, APE1 AS P_APELLIDO,")
                .Append("APE2 AS S_APELLIDO, APE3 AS T_APELLIDO, STATUS AS ESTADO, GENERO, DEPRESIDENCIA AS DEP, MUNRESIDENCIA AS MUN, ")
                .Append("CUI AS DPI ")
                .Append("FROM TPADRON ")
                .Append("LEFT JOIN Tdpi ")
                .Append("ON tpadron.nroboleta = tdpi.nroboleta ");
                    
            if (checkBoleta.Checked && !boletaInput.Equals("")  && int.TryParse(boletaInput.Value.ToString(), out boleta))
            {       sb.Append("WHERE tpadron.NROBOLETA = ")
                    .Append(boleta);
            return sb.ToString();
            }
            if (checkDpi.Checked && !DpiInput.Equals("") && Int64.TryParse(DpiInput.Value.ToString(),out dpi))
            {
                
                sb.Append("WHERE tdpi.CUI = ")
                    .Append(dpi);
                return sb.ToString();
            }
            return "";
        }

        private void fillFields(Ciudadano citizen)
        {
            this.Estado.Value = citizen.Estado;
            this.Boleta.Value = citizen.NroBoleta;
            this.firstName.Value = citizen.PrimerNombre;
            this.SecondName.Value = citizen.SegundoNombre;
            this.LastName1.Value = citizen.PrimerApellido;
            this.LastName2.Value = citizen.SegundoApellido;
            this.LastName3.Value = citizen.TercerApelldio;
            this.Dpi.Value = citizen.Dpi;
            this.Departamento.Value = citizen.DeptoResidencia;
            this.Municipio.Value = citizen.MunResidencia;
        }

        private void cleanFields()
        {
            this.Estado.Value = "";
            this.Boleta.Value = "";
            this.firstName.Value = "";
            this.SecondName.Value = "";
            this.LastName1.Value = "";
            this.LastName2.Value = "";
            this.LastName3.Value = "";
            this.Dpi.Value = "";
            this.Departamento.Value = "";
            this.Municipio.Value = "";
        }


        protected void checkDpi_CheckedChanged(object sender, EventArgs e)
        {
            
            if (this.checkDpi.Checked)
            {
                this.checkBoleta.Enabled = false;
                this.boletaInput.Disabled = true;
            }
            else
            {
                this.checkBoleta.Enabled = true;
                this.boletaInput.Disabled = false;
            }

        }

        protected void checkBoleta_CheckedChanged(object sender, EventArgs e)
        {
            
            if (this.checkBoleta.Checked)
            {
                this.checkDpi.Enabled = false;
                this.DpiInput.Disabled = true;
            }
            else
            {
                this.checkDpi.Enabled = true;
                this.DpiInput.Disabled = false;
            }
        }

        protected void float_suspend_ServerClick(object sender, EventArgs e)
        {
            if (validateSearch())
            {
                Response.Redirect("Suspender.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(),
                   "", "Materialize.toast('Debe de realizar uan busqueda', 3000, 'rounded');", true);
            }   
        }

        protected void float_enable_ServerClick(object sender, EventArgs e)
        {
            if (validateSearch())
            {
                Response.Redirect("Enable.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(),
                   "", "Materialize.toast('Debe de realizar uan busqueda', 3000, 'rounded');", true);
            }   
        }

        public Boolean validateSearch()
        {
            return su != null && su.cd != null && su.cd.Filled;
        }
    }
}