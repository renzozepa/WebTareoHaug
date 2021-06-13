using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WebTareoHaug
{
    public partial class Personal : System.Web.UI.Page
    {
        ClsEntity.Tareador LoObjTareador = null;
        ClsEntity.Personal LoObjPersonal = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {

            }
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["SUCURSAL"])))
                {
                    LlenarTareador();
                    GVPersonal.DataBind();
                    GVPersonalCesado.DataBind();
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
            DdlTareador.DataSource = ListObjTareador;
            DdlTareador.DataTextField = "NOMBRE_COMPLETO";
            DdlTareador.DataValueField = "ID_ALTERNO_FICHA";
            DdlTareador.DataBind();
            DdlTareador.Items.Insert(0, new ListItem("Todos", "0"));
        }
        public void LlenarPersonal()
        {
            LoObjPersonal = new ClsEntity.Personal();
            List<ClsEntity.Personal> ListObjPersonal = new List<ClsEntity.Personal>();
            LoObjPersonal.ID_SUCURSAL = Convert.ToString(Session["SUCURSAL"]);
            ListObjPersonal = ClsBusiness.Personal.GetAllPersonal(LoObjPersonal);
            GVPersonal.DataSource = ListObjPersonal;
        }
        public void LlenarPersonalCesado()
        {
            LoObjPersonal = new ClsEntity.Personal();
            List<ClsEntity.Personal> ListObjPersonal = new List<ClsEntity.Personal>();
            LoObjPersonal.ID_SUCURSAL = Convert.ToString(Session["SUCURSAL"]);
            ListObjPersonal = ClsBusiness.Personal.GetAllPersonalCesado(LoObjPersonal);
            GVPersonalCesado.DataSource = ListObjPersonal;
        }
        public void LlenarPersonalTareador()
        {
            LoObjPersonal = new ClsEntity.Personal();
            List<ClsEntity.Personal> ListObjPersonal = new List<ClsEntity.Personal>();
            LoObjPersonal.ID_TAREADOR = DdlTareador.SelectedValue.ToString();
            LoObjPersonal.ID_SUCURSAL = Convert.ToString(Session["SUCURSAL"]);
            ListObjPersonal = ClsBusiness.Personal.GetAllPersonalTareador(LoObjPersonal);            
            GVPersonal.DataSource = ListObjPersonal;
        }
        public void LlenarPersonalTareadorCesado()
        {
            LoObjPersonal = new ClsEntity.Personal();
            List<ClsEntity.Personal> ListObjPersonal = new List<ClsEntity.Personal>();
            LoObjPersonal.ID_TAREADOR = DdlTareador.SelectedValue.ToString();
            LoObjPersonal.ID_SUCURSAL = Convert.ToString(Session["SUCURSAL"]);
            ListObjPersonal = ClsBusiness.Personal.GetAllPersonalTareadorCesado(LoObjPersonal);
            GVPersonalCesado.DataSource = ListObjPersonal;            
        }
        protected void GVPersonal_DataBinding(object sender, EventArgs e)
        {
            if (DdlTareador.SelectedValue.ToString() == "0")
            {
                LlenarPersonal();
            }
            else
            {
                LlenarPersonalTareador();
            }
        }
        protected void BtnVer_Click(object sender, EventArgs e)
        {
            GVPersonal.DataBind();
            GVPersonalCesado.DataBind();
            
            if (DdlTareador.SelectedValue.ToString() == "0")
            {
                LlenarPersonal();
                LlenarPersonalCesado();
            }
            else {
                LlenarPersonalTareador();
                LlenarPersonalTareadorCesado();
            }            
        }
        protected void GVPersonalCesado_DataBinding(object sender, EventArgs e)
        {
            if (DdlTareador.SelectedValue.ToString() == "0")
            {
                LlenarPersonalCesado();
            }
            else
            {
                LlenarPersonalTareadorCesado();
            }
        }
    }
}