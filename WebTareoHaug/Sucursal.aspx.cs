using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTareoHaug
{
    public partial class Sucursal : System.Web.UI.Page
    {
        ClsEntity.Sucursal LoObjSucursal = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarSucursal();
            }
        }

        public void LlenarSucursal()
        {
            LoObjSucursal = new ClsEntity.Sucursal();
            List<ClsEntity.Sucursal> ListSucursal = new List<ClsEntity.Sucursal>();

            ListSucursal = ClsBusiness.Sucursal.GetSucursal(LoObjSucursal);
            DdlSucursal.DataSource = ListSucursal;
            DdlSucursal.DataTextField = "DESCRIPCION";
            DdlSucursal.DataValueField = "ID_SUCURSAL";
            DdlSucursal.DataBind();
        }

        protected void BtnContinuar_Click(object sender, EventArgs e)
        {
            Session["SUCURSAL"] = DdlSucursal.SelectedValue;
            Session["Des_Sucursal"] = DdlSucursal.SelectedItem.Text.ToString();
            Response.Redirect("Tareador.aspx");
        }
    }
}