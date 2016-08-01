using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;

namespace Suspendidos.Negocio
{
    public class SuspenderBehind
    {
        public DataTable getDeptoList()
        {
            List<String> listDepto = new List<String>();
            ConnectDB connection = new ConnectDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT deslarga FROM trefdepmun")
                .Append(" WHERE CODMUN = 0 ")
                .Append("AND DESLARGA <> 'LOCAL' ")
                .Append("AND DESLARGA <> 'NACIO EN EL EXTRANJERO'")
                .Append("AND DESLARGA <> 'DISPONIBLE'")
                .Append("ORDER BY CODDEP");
            DataTable dt = connection.executeQuery(sb.ToString());
            return dt;
        }

        public DataTable getMuniList(String codeDepto)
        {
            List<String> listDepto = new List<String>();
            ConnectDB connection = new ConnectDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT deslarga FROM trefdepmun")
                .Append(" WHERE CODMUN <> 0 ")
                .Append("AND CODDEP = ").Append(codeDepto)
                .Append(" ORDER BY CODMUN");
            DataTable dt = connection.executeQuery(sb.ToString());
            return dt;
        }

        public bool validState(string NroBoleta)
        {
            ConnectDB conn = new ConnectDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT STATUS FROM TPADRON WHERE NROBOLETA = ")
                .Append(NroBoleta);
            String codeStatus = conn.executeScalar(sb.ToString()).ToString();
            switch (codeStatus)
            {
                case "0":
                    return false;
                case "2":
                    return false;
                case "3":
                    return false;
                case "4":
                    return false;
                case "6":
                    return false;
                case "10":
                    return false;
                case "":
                    return false;
                default:
                    return true;
            }
                
        }


    }
}