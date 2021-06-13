using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTareoHaug
{
    public partial class Dispositivos : System.Web.UI.Page
    {
        ClsEntity.TareadorDispositivo LoObjTareadorDispositivo = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["SUCURSAL"])))
                    GVDispositivos.DataBind();                
                else
                    Response.Redirect("Sucursal.aspx");
            }
        }
        public void LlenarTareadorDispositivo(int id)
        {
            LoObjTareadorDispositivo = new ClsEntity.TareadorDispositivo
            {
                ID_PERSONAL = id
            };
            List<ClsEntity.TareadorDispositivo> ListObjTareadorDispositivo = new List<ClsEntity.TareadorDispositivo>();
            ListObjTareadorDispositivo = ClsBusiness.TareadorDispositivo.GetAllDispositivosTareador(LoObjTareadorDispositivo);
            if (ListObjTareadorDispositivo != null)
            {
                LblId.Text = ListObjTareadorDispositivo[0].ID_TAREADOR.ToString();
                LblTareador.Text = ListObjTareadorDispositivo[0].TAREADOR.ToString();

                GVDispositivos.DataSource = ListObjTareadorDispositivo;                
            }
        }
        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tareador.aspx");
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoDispositivo.aspx?Id="+ Request.QueryString["id"]);
        }

        protected void GVDispositivos_DataBinding(object sender, EventArgs e)
        {
            LlenarTareadorDispositivo(Convert.ToInt32(Request.QueryString["id"]));
        }
    }
}