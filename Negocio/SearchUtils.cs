using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Suspendidos.Negocio
{
    public class SearchUtils
    {
        public Ciudadano cd;

        public SearchUtils()
        {
            cd = null;
        }

        public int getCitizenInfo(String query){
            Utility utility = new Utility();
            ConnectDB conn = new ConnectDB();
            DataTable dt = conn.executeQuery(query);
            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                String boleta = dr["BOLETA"].ToString();
                String fName = dr["P_NOMBRE"].ToString();
                String sName = dr["S_NOMBRE"].ToString();
                String lName1 = dr["P_APELLIDO"].ToString();
                String lName2 = dr["S_APELLIDO"].ToString();
                String lName3 = dr["T_APELLIDO"].ToString();
                String status = dr["ESTADO"].ToString();
                String dpi = dr["DPI"].ToString();
                String genre = dr["GENERO"].ToString();
                String dep = dr["DEP"].ToString();
                String mun = dr["MUN"].ToString();
                String desDep = utility.getDepto(dep);
                string desMun = utility.getMun(dep, mun);
                cd = new Ciudadano(fName, sName, lName1, lName2, lName3, dpi, boleta,
                    desDep, desMun, status, genre);
                cd.Filled = true;
            }
            else
            {
                cd = new Ciudadano();
                cd.Filled = false;
            }
            
            return dt.Rows.Count;
        }
    }
}