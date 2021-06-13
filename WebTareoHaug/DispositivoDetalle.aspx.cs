using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTareoHaug
{
    public partial class DispositivoDetalle : System.Web.UI.Page
    {
        ClsEntity.TareadorDispositivo LoObjTareadorDispositivo = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["SUCURSAL"])))
                {
                    LlenarDatosDispositivo(Convert.ToInt32(Request.QueryString["Id"]));
                }
                else {
                    Response.Redirect("Sucursal.aspx");
                }
                
            }
        }

        public void LlenarDatosDispositivo(int id)
        {
            LoObjTareadorDispositivo = new ClsEntity.TareadorDispositivo
            {
                ID = id
            };
            List<ClsEntity.TareadorDispositivo> ListObjTareadorDispositivo = new List<ClsEntity.TareadorDispositivo>();
            ListObjTareadorDispositivo = ClsBusiness.TareadorDispositivo.GetAllDispositivosTareadorById(LoObjTareadorDispositivo);

            if (ListObjTareadorDispositivo != null)
            {
                LblId.Text = ListObjTareadorDispositivo[0].ID.ToString();
                TxtDescripcion.Text = ListObjTareadorDispositivo[0].DESCRIPCION;
                TxtNroCelular.Text = ListObjTareadorDispositivo[0].NUMERO_CELULAR;
                //TxtIdTareador.Text = ListObjTareadorDispositivo[0].ID_TAREADOR;
                LblIdTareador.Text = ListObjTareadorDispositivo[0].ID_TAREADOR;
                LblTareador.Text = ListObjTareadorDispositivo[0].TAREADOR;
                LblToken.Text = ListObjTareadorDispositivo[0].TOKEN;
                DEFSolicitud.Value = ListObjTareadorDispositivo[0].FECHA_SOLICITUD.Date;
                DEFAlta.Value = ListObjTareadorDispositivo[0].FECHA_ALTA.Date;
                DEFExpiracion.Value = ListObjTareadorDispositivo[0].FECHA_VENCIMIENTO.Date;
                CBEstado.Checked = ListObjTareadorDispositivo[0].ESTADO;
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
            Response.Redirect("Dispositivos.aspx?id=" + Request.QueryString["IdT"]);
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            LoObjTareadorDispositivo = new ClsEntity.TareadorDispositivo();

            LoObjTareadorDispositivo.ID = Convert.ToInt32(LblId.Text);
            LoObjTareadorDispositivo.DESCRIPCION = TxtDescripcion.Text;
            LoObjTareadorDispositivo.NUMERO_CELULAR = TxtNroCelular.Text;
            LoObjTareadorDispositivo.ID_TAREADOR = LblIdTareador.Text;
            LoObjTareadorDispositivo.TOKEN = LblToken.Text;
            LoObjTareadorDispositivo.FECHA_ALTA = Convert.ToDateTime(DEFAlta.Value);
            LoObjTareadorDispositivo.FECHA_VENCIMIENTO = Convert.ToDateTime(DEFExpiracion.Value);
            LoObjTareadorDispositivo.ESTADO = CBEstado.Checked;

            int rpt = 0;

            rpt = ClsBusiness.TareadorDispositivo.UpdDispositivoTareador(LoObjTareadorDispositivo);

        }
    }
}