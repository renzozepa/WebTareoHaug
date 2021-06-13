using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTareoHaug
{
    public partial class ReporteTareoProcesado : System.Web.UI.Page
    {
        ClsEntity.Tareador LoObjTareador = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["SUCURSAL"])))
                    LlenarTareador();
                else
                    Response.Redirect("Sucursal.aspx");
            }
        }
        public void LlenarTareador()
        {
            LoObjTareador = new ClsEntity.Tareador();
            List<ClsEntity.Tareador> ListObjTareador = new List<ClsEntity.Tareador>();
            ListObjTareador = ClsBusiness.Tareador.GetAllTareador(LoObjTareador);
            DdlTareador.DataSource = ListObjTareador;
            DdlTareador.DataTextField = "NOMBRE_COMPLETO";
            DdlTareador.DataValueField = "ID_ALTERNO_FICHA";
            DdlTareador.DataBind();
            DdlTareador.Items.Insert(0, new ListItem("Todos", "0"));
        }

        protected void BtnVer_Click(object sender, EventArgs e)
        {

        }
    }
}