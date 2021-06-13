using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTareoHaug
{
    public partial class Tareador : System.Web.UI.Page
    {
        ClsEntity.Tareador LoObjTareador = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                if (!string.IsNullOrEmpty(Convert.ToString(Session["SUCURSAL"])))
                {
                    LlenarTareador();
                    GVTareador.DataBind();
                }
                else {
                    Response.Redirect("Sucursal.aspx");
                }                
            }
        }
        public void LlenarTareador()
        {
            LoObjTareador = new ClsEntity.Tareador(); 
            List<ClsEntity.Tareador> ListObjTareador = new List<ClsEntity.Tareador>();
            ListObjTareador = ClsBusiness.Tareador.GetAllTareador(LoObjTareador);
            GVTareador.DataSource = ListObjTareador;            
        }

        protected void GVTareador_DataBinding(object sender, EventArgs e)
        {
            LlenarTareador();
        }
    }
}