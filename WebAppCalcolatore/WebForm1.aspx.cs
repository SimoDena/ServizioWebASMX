using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCalcolatore
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReferenceCalcolatore.WsCalcolatoreSoapClient client = new ServiceReferenceCalcolatore.WsCalcolatoreSoapClient();
            int risultato = client.Somma(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            Label4.Text = risultato.ToString();

            ListBoxCalcoli.DataSource = client.RitornaCalcoliSessione();
            ListBoxCalcoli.DataBind();
        }
    }
}