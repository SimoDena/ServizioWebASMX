using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServizioWebCalcolatore
{
    /// <summary>
    /// Descrizione di riepilogo per WsCalcolatore
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class WsCalcolatore : System.Web.Services.WebService
    {
        [WebMethod(EnableSession =true, Description ="Somma due numeri interi", CacheDuration = 20)]
        public int Somma(int x, int y)
        {
            List<string> calcoli;

            if (Session["CALCOLI"] == null)
            {
                calcoli = new List<string>();
            }
            else
            {
                calcoli = (List<string>)Session["CALCOLI"];
            }

            string calcolo = x + " + " + y + " = " + (x + y);
            calcoli.Add(calcolo);
            Session["CALCOLI"] = calcoli;
            return x + y;
        }

        [WebMethod(EnableSession=true)]
        public List<string> RitornaCalcoliSessione()
        {
            if (Session["CALCOLI"] == null)
            {
                List<string> calcoli = new List<string>();
                calcoli.Add("Nessun calcolo effettuato");
                return calcoli;
            }
            else
            {
                return (List<string>)Session["CALCOLI"];
            }
        }
    }
}
