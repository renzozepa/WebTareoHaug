namespace WebTareoHaug
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Web.UI.WebControls;
    public partial class PeriodoPorRegimen : System.Web.UI.Page
    {
        ClsEntity.RegimenLaboral LoObjRegLaboral = null;
        ClsEntity.Periodo LoObjPeriodo = null;
        ClsEntity.Configuracion LoObjConfiguracion = null;
        ClsEntity.TareoCabecera LoObjTareoCabecera = null;        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["SUCURSAL"])))
                {
                    LlenarRegimenLaboral();
                    GVPeriodos.DataBind();
                }
                else
                {
                    Response.Redirect("Sucursal.aspx");
                }
            }
        }
        public string CodProyecto()
        {
            LoObjConfiguracion = new ClsEntity.Configuracion();
            List<ClsEntity.Configuracion> ListObjConfiguracion = new List<ClsEntity.Configuracion>();
            string sucursal = Convert.ToString(Session["SUCURSAL"]);
            LoObjConfiguracion.ID_SUCURSAL = sucursal;
            ListObjConfiguracion = ClsBusiness.Configuracion.GetConfiguracionByID(LoObjConfiguracion);
            string CodProy = string.Empty;
            if (ListObjConfiguracion != null)
            {
                CodProy = ListObjConfiguracion[0].CODPROYECTO.ToString();
            }

            return CodProy;
        }
        public void LlenarRegimenLaboral()
        {
            LoObjRegLaboral = new ClsEntity.RegimenLaboral();
            List<ClsEntity.RegimenLaboral> ListObjRegimenLaboral = new List<ClsEntity.RegimenLaboral>();
            LoObjRegLaboral.CodProyecto = CodProyecto();
            string sucursal = Convert.ToString(Session["SUCURSAL"]);
            ListObjRegimenLaboral = ClsBusiness.RegimenLaboral.GetAllRegimenLaboral(sucursal, LoObjRegLaboral);
            DdlNomina.DataSource = ListObjRegimenLaboral;
            DdlNomina.DataTextField = "Descripcion";
            DdlNomina.DataValueField = "NroProyectoEsquema";
            DdlNomina.DataBind();
            DdlNomina.Items.Insert(0, new ListItem("Todos", "0"));
        }

        protected void GVPeriodos_DataBinding(object sender, EventArgs e)
        {
            LlenarPeriodos();
        }
        protected void BtnVer_Click(object sender, EventArgs e)
        {
            LlenarPeriodos();
            GVPeriodos.DataBind();
        }
        void LlenarPeriodos()
        {
            LoObjPeriodo = new ClsEntity.Periodo
            {
                NroProyectoEsquema = DdlNomina.SelectedValue,
                Anno = ddlPeriodoAnual.SelectedValue,
                CodProyecto = CodProyecto()
            };
            List<ClsEntity.Periodo> ListObjPeriodo = new List<ClsEntity.Periodo>();
            string sucursal = Convert.ToString(Session["SUCURSAL"]);
            ListObjPeriodo = ClsBusiness.Periodo.GetPeriodoPorRegimen(sucursal, LoObjPeriodo);

            GVPeriodos.DataSource = ListObjPeriodo;
        }
        Hashtable copiedValues = null;
        string[] copiedFields = new string[] { "CodProyectoEsquemaPeriodoTareo", "Descripcion" };
        protected void GVPeriodos_CustomButtonCallback(object sender, DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            if (e.ButtonID == "BtnGenerar")
            {
                string Cod = string.Empty;
                string Desc = string.Empty;

                copiedValues = new Hashtable();
                foreach (string fieldName in copiedFields)
                    copiedValues[fieldName] = GVPeriodos.GetRowValues(e.VisibleIndex, fieldName);

                Cod = copiedValues["CodProyectoEsquemaPeriodoTareo"].ToString();
                Desc = copiedValues["Descripcion"].ToString();

                AlblCodSemana.Text = Cod;
                AlblDescSemana.Text = Desc;

                hdCodSemana.Value = Cod;

                LoObjPeriodo = new ClsEntity.Periodo
                {
                    NroProyectoEsquema = DdlNomina.SelectedValue,
                    Anno = ddlPeriodoAnual.SelectedValue,
                    CodProyecto = CodProyecto(),
                    CodProyectoEsquemaPeriodoTareo = Cod
                };

                List<ClsEntity.Periodo> ListPeriodoDiario = new List<ClsEntity.Periodo>();
                string sucursal = Convert.ToString(Session["SUCURSAL"]);
                ListPeriodoDiario = ClsBusiness.Periodo.GetPeriodoDiarioPorRegimen(sucursal, LoObjPeriodo);
                if (ListPeriodoDiario != null)
                {
                    ddlDia.DataSource = ListPeriodoDiario;
                    ddlDia.DataTextField = "DesPeriodo";
                    ddlDia.DataValueField = "CodPeriodo";
                    ddlDia.DataBind();
                    ddlDia.Items.Insert(0, new ListItem("Todos", "0"));
                }
                pcAddDia.ShowOnPageLoad = true;
            }
        }
        protected void BtnGenerarDia_Click(object sender, EventArgs e)
        {
            LoObjTareoCabecera = new ClsEntity.TareoCabecera
            {
                Id_Sucursal = Convert.ToString(Session["SUCURSAL"]),
                CodProyecto = CodProyecto(),
                NroProyectoEsquema = DdlNomina.SelectedValue,
                Anno = Convert.ToInt32(ddlPeriodoAnual.SelectedValue),
                CodProyectoEsquemaPeriodoTareo = hdCodSemana.Value,
                CodPeriodo = hddia.Value,
                DesPeriodo = ddlDia.Text,
                CodTareador = "00028153",
                IdUsuario = Convert.ToInt32(Session["ID_USUARIO"])
            };            

            int ID_TAREO = ClsBusiness.TareoCabecera.InsTareoCabecera(LoObjTareoCabecera);
            Response.Redirect("PeriodoPorRegimenDiario.aspx?Id=" + ID_TAREO + "&Pl=" + DdlNomina.SelectedItem.Text + "&An=" + ddlPeriodoAnual.Text + "&Sem="+ hdCodSemana.Value + "&Di=" + hddiatext.Value);
        }
    }
}