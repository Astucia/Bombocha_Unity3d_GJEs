using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeBombochaWS
{
    public partial class TestWS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.BombochaGJEsSoapClient BC = new ServiceReference1.BombochaGJEsSoapClient();

            Label1.Text = BC.UsuarioLogin2JSON("x", "x");


        }
    }
}