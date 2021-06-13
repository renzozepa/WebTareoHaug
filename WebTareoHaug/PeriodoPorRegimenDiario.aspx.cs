namespace WebTareoHaug
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Web.UI.WebControls;
    public partial class PeriodoPorRegimenDiario : System.Web.UI.Page
    {
        ClsEntity.TareoDetalle LoObjTareoDetalle = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["SUCURSAL"])))
                {
                    int id = Convert.ToInt32(Request.QueryString["Id"]);
                    string pl = Convert.ToString(Request.QueryString["Pl"]);
                    string anio = Convert.ToString(Request.QueryString["An"]);
                    string semana = Convert.ToString(Request.QueryString["Sem"]);
                    string dia = Convert.ToString(Request.QueryString["Di"]);

                    GVPersonal.DataSource = LlenarTareoDetalle(id);
                    GVPersonal.DataBind();                    
                }
                else
                {
                    Response.Redirect("Sucursal.aspx");
                }
            }
        }
        protected List<ClsEntity.TareoDetalle> LlenarTareoDetalle(int id)
        {
            LoObjTareoDetalle = new ClsEntity.TareoDetalle();
            List<ClsEntity.TareoDetalle> ListObjTareoDetalle = new List<ClsEntity.TareoDetalle>();
            LoObjTareoDetalle.IdCabecera = id;

            ListObjTareoDetalle = ClsBusiness.TareoCabecera.GetTareoDetalleById(LoObjTareoDetalle);
            return ListObjTareoDetalle;
        }
        protected void GVPersonal_DataBinding(object sender, EventArgs e)
        {            
            GVPersonal.DataSource = LlenarTareoDetalle(Convert.ToInt32(Request.QueryString["Id"]));
        }
        protected ClsEntity.TareoDetalle UpdateItem(OrderedDictionary keys, OrderedDictionary newValues)
        {
            var id = Convert.ToInt32(keys["IdDet"]);
            var item = LlenarTareoDetalle(Convert.ToInt32(Request.QueryString["Id"])).First(i => i.IdDet == id);
            LoadNewValues(item, newValues);
            return item;
        }
        protected void LoadNewValues(ClsEntity.TareoDetalle item, OrderedDictionary values)
        {
            item.IdDet = Convert.ToInt32(values["IdDet"]);
            item.CodConcepto = Convert.ToString(values["CodConcepto"]);
            item.CodActividad = Convert.ToString(values["CodActividad"]);
            item.HNormales = Convert.ToDecimal(values["HNormales"]);
            item.HRefrigerio = Convert.ToDecimal(values["HRefrigerio"]);
            item.HExtras = Convert.ToDecimal(values["HExtras"]);
            item.HDomFeriados = Convert.ToDecimal(values["HDomFeriados"]);
            item.Observacion = Convert.ToString(values["Observacion"]);

            int rpt_update = ClsBusiness.TareoCabecera.UpdTareoDetalleById(item);
        }
        protected void GVPersonal_BatchUpdate(object sender, DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs e)
        {
            foreach (var args in e.UpdateValues)
                UpdateItem(args.Keys, args.NewValues);

            e.Handled = true;
        }
        protected void GVPersonal_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            UpdateItem(e.Keys, e.NewValues);
            CancelEditing(e);
        }
        protected void CancelEditing(CancelEventArgs e)
        {
            e.Cancel = true;
            GVPersonal.CancelEdit();
        }
    }
}