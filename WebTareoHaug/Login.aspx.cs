using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
using System.Security.Cryptography;
using System.Text;

namespace WebTareoHaug
{
    public partial class Login : System.Web.UI.Page
    {
        ClsEntity.Usuario LoObjUsuario = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["ID_USUARIO"] = string.Empty;
                Session["Usuario"] = string.Empty;
                Session["APELLIDO_PATERNO"] = string.Empty;
                Session["APELLIDO_MATERNO"] = string.Empty;
                Session["NOMBRE"] = string.Empty;
                Session["NOMBRE_COMPLETO"] = string.Empty;
                Session["ID_PERSONAL"] = string.Empty;
                Session["SUCURSAL"] = string.Empty;
                Session["Desc_Sucursal"] = string.Empty;
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Length > 0 && txtpassword.Text.Length > 0)
            {
                if (Llenarderecho() > 0)
                {
                    
                    if (Convert.ToInt32(Session["ID_USUARIO"]) != 0)
                    {
                        Response.Redirect("Sucursal.aspx");
                    }

                    else
                    {
                        Response.Redirect("Login.aspx");
                    }
                }
                else
                {
                    
                    ScriptManager.RegisterStartupScript((sender as Control), this.GetType(), "Popup", "ShowPopup('Usuairo y / o clave esta equivocada.');", true);
                }
            }
        }
        private Int32 Llenarderecho()
        {
            Int32 rpt = 0;

            LoObjUsuario = new ClsEntity.Usuario()
            {
                USUARIO = txtusername.Text
            };

            string contraseña = GetSwcSHA1(txtpassword.Text);
            LoObjUsuario.CLAVE = contraseña;

            List<ClsEntity.Usuario> ListUsuario = new List<ClsEntity.Usuario>();
            ListUsuario = ClsBusiness.Usuario.GetUsuarioLogin(LoObjUsuario);

            if (ListUsuario != null)
            {
                Session["ID_USUARIO"] = ListUsuario[0].ID_USUARIO;
                Session["Usuario"] = txtusername.Text.ToString();
                Session["APELLIDO_PATERNO"] = ListUsuario[0].APELLIDO_PATERNO;
                Session["APELLIDO_MATERNO"] = ListUsuario[0].APELLIDO_MATERNO;
                Session["NOMBRE"] = ListUsuario[0].NOMBRE;
                Session["NOMBRE_COMPLETO"] = ListUsuario[0].NOMBRE_COMPLETO;                
                Session["ID_PERSONAL"] = ListUsuario[0].ID_PERSONAL;
                rpt = Convert.ToInt32(Session["ID_USUARIO"]);
            }
            return rpt;
        }
        public static string GetSwcSHA1(string value)
        {
            SHA1 algorithm = SHA1.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
            string sh1 = "";
            for (int i = 0; i < data.Length; i++)
            {
                sh1 += data[i].ToString("x2").ToUpperInvariant();
            }
            return sh1;
        }
    }
}