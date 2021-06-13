using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

namespace WebTareoHaug {
    public partial class RootMaster : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxLabel2.Text = DateTime.Now.Year + Server.HtmlDecode(" &copy; Copyright by [Haug S.A. - TI]");
            AlblUsuario.Text = Convert.ToString(Session["NOMBRE_COMPLETO"]);
            AlblSucursal.Text = Convert.ToString(Session["Des_Sucursal"]);
        }
    }
}