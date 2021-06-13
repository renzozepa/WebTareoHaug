using System;
using System.Collections.Generic;

namespace WebTareoHaug
{
    public partial class Configuracion : System.Web.UI.Page
    {

        ClsEntity.Configuracion LoObjConfiguracion = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["SUCURSAL"])))
                    LlenarSucursal();
                else
                    Response.Redirect("Sucursal.aspx");
            }
            
        }

        public void LlenarSucursal()
        {
            AlblCodigo.Text = Convert.ToString(Session["SUCURSAL"]);
            AlblDescripcion.Text = Convert.ToString(Session["Des_Sucursal"]);
            LoObjConfiguracion = new ClsEntity.Configuracion();
            List<ClsEntity.Configuracion> ListConfiguracion = new List<ClsEntity.Configuracion>();
            LoObjConfiguracion.ID_SUCURSAL = Convert.ToString(Session["SUCURSAL"]);
            ListConfiguracion = ClsBusiness.Configuracion.GetConfiguracionByID(LoObjConfiguracion);
            if (ListConfiguracion != null)
            {
                AtxtServidor.Text = ListConfiguracion[0].SERVIDOR.ToString();
                AtxtBD.Text = ListConfiguracion[0].BASEDEDATOS.ToString();
                ATxtUsuario.Text = ListConfiguracion[0].USUARIO.ToString();
                AtxtPassword.Text = ListConfiguracion[0].CLAVE.ToString();
                AtxtCodProyecto.Text = ListConfiguracion[0].CODPROYECTO.ToString();
            }
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            LoObjConfiguracion = new ClsEntity.Configuracion
            {
                ID_SUCURSAL = AlblCodigo.Text,
                SERVIDOR = AtxtServidor.Text.Trim(),
                BASEDEDATOS = AtxtBD.Text.Trim(),
                USUARIO = ATxtUsuario.Text.Trim(),
                CLAVE = AtxtPassword.Text.Trim(),
                CODPROYECTO = AtxtCodProyecto.Text.Trim()
            };

            int rpt = ClsBusiness.Configuracion.InsConfiguracion(LoObjConfiguracion);
        }
    }
}