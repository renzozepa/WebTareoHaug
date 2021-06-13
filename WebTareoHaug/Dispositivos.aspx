<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Dispositivos.aspx.cs" Inherits="WebTareoHaug.Dispositivos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;" class="dxsplControl_DevEx">
        <tr>
            <td colspan="2" style="text-align: center; font-family: Calibri; font-size: x-large;">Listado de dispositivos</td>
        </tr>
        <tr>
            <td colspan="2">
                <dx:ASPxLabel ID="LblId" runat="server" Text=""></dx:ASPxLabel> - <dx:ASPxLabel ID="LblTareador" runat="server" Text=""></dx:ASPxLabel>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <dx:ASPxGridView ID="GVDispositivos" runat="server" Theme="DevEx" AutoGenerateColumns="False"
                    KeyFieldName="ID"
                    Width="100%" OnDataBinding="GVDispositivos_DataBinding">

                    <SettingsAdaptivity>
                        <AdaptiveDetailLayoutProperties ColCount="1">
                        </AdaptiveDetailLayoutProperties>
                    </SettingsAdaptivity>

                    <EditFormLayoutProperties ColCount="1">
                    </EditFormLayoutProperties>

                    <SettingsPager AlwaysShowPager="True" NumericButtonCount="20"
                        PageSize="20">
                    </SettingsPager>

                    <Settings ShowGroupPanel="True" VerticalScrollBarMode="Visible" VerticalScrollBarStyle="VirtualSmooth" />
                    <SettingsResizing ColumnResizeMode="Control" />
                    <SettingsSearchPanel Visible="True" />
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

                    <Columns>
                        <dx:GridViewDataTextColumn Caption="Id" FieldName="ID" ReadOnly="True" VisibleIndex="0">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Descripción" FieldName="DESCRIPCION" VisibleIndex="1">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Número celular" FieldName="NUMERO_CELULAR" VisibleIndex="2">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Id Tareador" FieldName="ID_TAREADOR" VisibleIndex="3">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Tareador" FieldName="TAREADOR" ReadOnly="True" VisibleIndex="4">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Token" FieldName="TOKEN" VisibleIndex="5">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataDateColumn Caption="F. Solicitud" FieldName="FECHA_SOLICITUD" VisibleIndex="6">
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataDateColumn Caption="F. Alta" FieldName="FECHA_ALTA" VisibleIndex="7">
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataDateColumn Caption="F. Vencimiento" FieldName="FECHA_VENCIMIENTO" VisibleIndex="8">
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataCheckColumn Caption="Estado" FieldName="ESTADO" VisibleIndex="9">
                        </dx:GridViewDataCheckColumn>
                        <dx:GridViewDataTextColumn FieldName="ID_USU_REG" Visible="False" VisibleIndex="10">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataDateColumn FieldName="FECHA_REGISTRO" Visible="False" VisibleIndex="11">
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataTextColumn FieldName="ID_USUARIO_MOD" Visible="False" VisibleIndex="12">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataDateColumn FieldName="FECHA_MODIFICACION" Visible="False" VisibleIndex="13">
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataHyperLinkColumn>
                            <DataItemTemplate>
                                <dx:ASPxHyperLink ID="Link1" NavigateUrl='<%# Eval("Id", "DispositivoDetalle.aspx?Id={0}&IdT=" + Request["id"]) %>'
                                    runat="server" Height="10px" Width="5px" Text="Ver">
                                </dx:ASPxHyperLink>
                            </DataItemTemplate>
                        </dx:GridViewDataHyperLinkColumn>
                    </Columns>
                    <GroupSummary>
                        <dx:ASPxSummaryItem FieldName="ID" SummaryType="Count" />
                    </GroupSummary>
                </dx:ASPxGridView>
            </td>
        </tr>
        <tr style="height:30px;">
            <td colspan="2"></td>
        </tr>
        <tr>
            <td colspan="2">
                <center>                    
                    <dx:ASPxButton ID="BtnNuevo" runat="server" CssClass="dxsplControl_DevEx" Text="Nuevo" Width="100px" ImagePosition="Right" Theme="DevEx" OnClick="BtnNuevo_Click">
                        <Image IconID="mail_news_16x16">
                        </Image>
                    </dx:ASPxButton>
                    &nbsp;
                    <dx:ASPxButton ID="BtnRegresar" runat="server" CssClass="dxsplControl_DevEx" Text="Regresar" Width="100px" OnClick="BtnRegresar_Click" ImagePosition="Right" Theme="DevEx">
                        <Image IconID="navigation_backward_16x16">
                        </Image>
                    </dx:ASPxButton>
                </center>
            </td>
        </tr>
    </table>

</asp:Content>
