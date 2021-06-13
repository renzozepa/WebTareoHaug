<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Tareador.aspx.cs" Inherits="WebTareoHaug.Tareador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;" class="dxsplControl_DevEx">
        <tr>
            <td colspan="2" style="text-align: center; font-family: Calibri; font-size: x-large;">Listado de administradores</td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <dx:ASPxGridView
                    ID="GVTareador"
                    runat="server"
                    Theme="DevEx"
                    AutoGenerateColumns="False" Width="100%" OnDataBinding="GVTareador_DataBinding">

                    <SettingsAdaptivity>
                        <AdaptiveDetailLayoutProperties ColCount="1"></AdaptiveDetailLayoutProperties>
                    </SettingsAdaptivity>

                    <SettingsPager AlwaysShowPager="True" NumericButtonCount="20"
                        PageSize="20">
                    </SettingsPager>

                    <Settings ShowGroupPanel="True" VerticalScrollBarMode="Auto" VerticalScrollBarStyle="VirtualSmooth" />
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

                    <EditFormLayoutProperties ColCount="1"></EditFormLayoutProperties>
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="ID_PERSONAL" Caption="Codigo" VisibleIndex="0">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="ID_ALTERNO_FICHA" Caption="Codigo S10" VisibleIndex="1">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="NOMBRE_COMPLETO" Caption="Tareador" ReadOnly="True" VisibleIndex="2">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataHyperLinkColumn>
                            <DataItemTemplate>
                                <dx:ASPxHyperLink ID="Link" NavigateUrl='<%# Eval("ID_PERSONAL", "Dispositivos.aspx?id={0}") %>'
                                    runat="server" Height="10px" Width="5px" Text="Ver">
                                </dx:ASPxHyperLink>
                            </DataItemTemplate>
                        </dx:GridViewDataHyperLinkColumn>
                    </Columns>
                    <GroupSummary>
                        <dx:ASPxSummaryItem FieldName="ID_PERSONAL" SummaryType="Count" />
                    </GroupSummary>
                </dx:ASPxGridView>

                <br />
                <asp:SqlDataSource
                    ID="SqlDtTareador"
                    ConnectionString="<%$ ConnectionStrings:constr %>"
                    runat="server"
                    SelectCommand="SP_TAREADOR"
                    SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>


</asp:Content>
