using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTareoHaug
{
    public partial class NuevoDispositivo : System.Web.UI.Page
    {
        ClsEntity.TareadorDispositivo LoObjTareadorDispositivo = null;
        ClsEntity.Tareador LoObjTareador = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["SUCURSAL"])))
                    LlenarTareador(Convert.ToInt32(Request.QueryString["Id"]));
                else
                    Response.Redirect("Sucursal.aspx");
            }
        }

        public void LlenarTareador(int id)
        {
            LoObjTareador = new ClsEntity.Tareador
            {
                ID_PERSONAL = id
            };
            List<ClsEntity.Tareador> ListObjTareador = new List<ClsEntity.Tareador>();
            ListObjTareador = ClsBusiness.Tareador.GetTareadorId(LoObjTareador);
            if (ListObjTareador != null)
            {
                LblId.Text = ListObjTareador[0].ID_ALTERNO_FICHA.ToString();
                LblTareador.Text = ListObjTareador[0].NOMBRE_COMPLETO.ToString();                
            }
        }

        protected void BtnGenerar_Click(object sender, EventArgs e)
        {
            Guid obj = Guid.NewGuid();
            LblToken.Text = obj.ToString();
        }

        protected void UpdatePanel1_Unload(object sender, EventArgs e)
        {
            RegisterUpdatePanel((UpdatePanel)sender);
        }
        protected void RegisterUpdatePanel(UpdatePanel panel)
        {
            var sType = typeof(ScriptManager);
            var mInfo = sType.GetMethod("System.Web.UI.IScriptManagerInternal.RegisterUpdatePanel", BindingFlags.NonPublic | BindingFlags.Instance);
            if (mInfo != null)
                mInfo.Invoke(ScriptManager.GetCurrent(Page), new object[] { panel });
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dispositivos.aspx?id=" + Request.QueryString["Id"]);
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNroCelular.Text))
            {
                LoObjTareadorDispositivo = new ClsEntity.TareadorDispositivo
                {
                    DESCRIPCION = TxtDescripcion.Text,
                    NUMERO_CELULAR = TxtNroCelular.Text,
                    TOKEN = LblToken.Text,
                    ID_TAREADOR = LblId.Text,
                    FECHA_SOLICITUD = Convert.ToDateTime(DEFSolicitud.Value),
                    FECHA_ALTA = Convert.ToDateTime(DEFAlta.Value),
                    FECHA_VENCIMIENTO = Convert.ToDateTime(DEFExpiracion.Value),
                    ESTADO = CBEstado.Checked,
                    ID_USU_REG = Convert.ToInt32(Session["ID_USUARIO"])
                };

                int rpt_validar = 0;

                rpt_validar = ClsBusiness.TareadorDispositivo.ValidarExistenciaDispositivoTareador(LoObjTareadorDispositivo);

                if (rpt_validar == 0)
                {
                    int rpt = 0;
                    rpt = ClsBusiness.TareadorDispositivo.InsDispositivoTareador(LoObjTareadorDispositivo);
                    TxtDescripcion.Text = string.Empty;
                    TxtNroCelular.Text = string.Empty;
                    LblToken.Text = string.Empty;
                    DEFSolicitud.Value = DateTime.Now.Date;
                    DEFAlta.Value = DateTime.Now.Date;
                    DEFExpiracion.Value = DateTime.Now.Date;
                    CBEstado.Checked = false;
                }
                else {
                    lblMensaje.Text = string.Format("El Tareador ya tiene registrado el número de celular {0}. Registrar otro número.", TxtNroCelular.Text);
                    pcMensaje.ShowOnPageLoad = true;
                }   
            }
            else {
                lblMensaje.Text = "Completar los datos necesarios.";
                pcMensaje.ShowOnPageLoad = true;
            }            
        }
    }
}