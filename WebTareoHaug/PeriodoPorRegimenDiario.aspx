<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="PeriodoPorRegimenDiario.aspx.cs" Inherits="WebTareoHaug.PeriodoPorRegimenDiario" %>

<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v18.1, Version=18.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;" class="dxsplControl_DevEx">
        <tr>
            <td></td>
            <td colspan="3" style="text-align: center; font-family: Calibri; font-size: x-large;">Tareo de Personal Diario</td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>Tipo de Nómina :</td>
            <td>
                <dx:ASPxLabel ID="AlblTipNom" runat="server" Text=""></dx:ASPxLabel>
            </td>
            <td>Año</td>
            <td>
                <dx:ASPxLabel ID="AlblAnno" runat="server" Text=""></dx:ASPxLabel>
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>Semana :</td>
            <td>
                <dx:ASPxLabel ID="AlblSemana" runat="server" Text=""></dx:ASPxLabel>
            </td>
            <td>Día</td>
            <td>
                <dx:ASPxLabel ID="AlblDia" runat="server" Text=""></dx:ASPxLabel>
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>Tareador :</td>
            <td>
                <dx:ASPxLabel ID="AlblTareador" runat="server" Text=""></dx:ASPxLabel>
            </td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td colspan="4">
                <dx:ASPxGridView ID="GVPersonal" runat="server" AutoGenerateColumns="False" EnableTheming="True" KeyFieldName="IdDet"
                    Theme="DevEx" Width="100%" OnDataBinding="GVPersonal_DataBinding" OnBatchUpdate="GVPersonal_BatchUpdate" OnRowUpdating="GVPersonal_RowUpdating">
                    <SettingsAdaptivity>
                        <AdaptiveDetailLayoutProperties ColCount="1">
                        </AdaptiveDetailLayoutProperties>
                    </SettingsAdaptivity>
                    <SettingsPager AlwaysShowPager="false" NumericButtonCount="53" PageSize="53">
                    </SettingsPager>
                    <Settings ShowGroupPanel="True" VerticalScrollBarMode="Auto" />
                    <SettingsResizing ColumnResizeMode="NextColumn" />
                    <SettingsEditing Mode="Batch" />
                    <SettingsSearchPanel Visible="True" ShowApplyButton="True" ShowClearButton="True" />
                    <SettingsExport EnableClientSideExportAPI="True" ExcelExportMode="WYSIWYG">
                    </SettingsExport>
                    <Toolbars>
                        <dx:GridViewToolbar EnableAdaptivity="True">
                            <Items>
                                <dx:GridViewToolbarItem Command="ExportToXls" />
                                <dx:GridViewToolbarItem Command="ExportToXlsx" />
                            </Items>
                        </dx:GridViewToolbar>
                    </Toolbars>
                    <EditFormLayoutProperties ColCount="1">
                    </EditFormLayoutProperties>
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="IdDet" FieldName="IdDet" ReadOnly="True" VisibleIndex="0">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataColumn Caption="IdCab" FieldName="IdCabecera" Visible="False" ReadOnly="True" VisibleIndex="1">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataColumn>
                        <dx:GridViewDataColumn Caption="CodTipoDocumento" FieldName="CodTipoDocumento" Visible="False" ReadOnly="True" VisibleIndex="2">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataColumn>   
                        <dx:GridViewDataColumn Caption="TipoDocumento" FieldName="TipoDocumento" VisibleIndex="3" ReadOnly="True">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataColumn>  
                        <dx:GridViewDataColumn Caption="DNI" VisibleIndex="4" FieldName="NroDocumento" ReadOnly="True">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataColumn>
                        <dx:GridViewDataColumn Caption="Trabajador" VisibleIndex="5" FieldName="Trabajador" ReadOnly="True">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataColumn>    
                        <dx:GridViewDataColumn Caption="IdSituacion" VisibleIndex="6" FieldName="IdSituacion" ReadOnly="True">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataColumn> 
                        <dx:GridViewDataColumn Caption="Situacion" VisibleIndex="7" FieldName="Situacion" ReadOnly="True">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataColumn> 
                       <dx:GridViewDataComboBoxColumn Caption="Proyecto" VisibleIndex="8">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataTextColumn Caption="Concepto" FieldName="CodConcepto" VisibleIndex="9">
                            <HeaderStyle HorizontalAlign="Center" />                            
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Actividad" FieldName="CodActividad" VisibleIndex="10">
                            <HeaderStyle HorizontalAlign="Center" />                            
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="HN" FieldName="HNormales" VisibleIndex="11">
                            <HeaderStyle HorizontalAlign="Center" />                           
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="HREF" FieldName="HRefrigerio" VisibleIndex="12">
                            <HeaderStyle HorizontalAlign="Center" />                            
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="HE" FieldName="HExtras" VisibleIndex="13">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="HDOMFER" FieldName="HDomFeriados" VisibleIndex="14">
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataMemoColumn Caption="OBS" FieldName="Observacion" VisibleIndex="15">
                            <HeaderStyle HorizontalAlign="Center" />                            
                        </dx:GridViewDataMemoColumn>                        
                    </Columns>
                    <GroupSummary>
                        <dx:ASPxSummaryItem FieldName="Id" SummaryType="Count" />
                    </GroupSummary>
                </dx:ASPxGridView>
            </td>
            <td></td>
        </tr>

    </table>
</asp:Content>
