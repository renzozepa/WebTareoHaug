<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ReporteTareoProcesado.aspx.cs" Inherits="WebTareoHaug.ReporteTareoProcesado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;" class="dxsplControl_DevEx">
        <tr>
            <td colspan="3" style="text-align: center; font-family: Calibri; font-size: x-large;">Tareo de personal</td>
        </tr>
        <tr>
            <td>Tareador : 
            </td>
            <td>
                <asp:DropDownList ID="DdlTareador" runat="server" Width="300px" CssClass="dxsplControl_DevEx"></asp:DropDownList>
            </td>
            <td rowspan="3">
                <dx:ASPxButton ID="BtnVer" runat="server" Width="100px" Text="Ver" Theme="DevEx" ImagePosition="Right" OnClick="BtnVer_Click">
                    <Image IconID="find_find_16x16">
                    </Image>
                </dx:ASPxButton>
            </td>
        </tr>
        <tr>
            <td>Desde : </td>
            <td>
                <dx:ASPxDateEdit ID="DEFDesde" runat="server" Width="150px" CssClass="dxsplControl_DevEx">
                </dx:ASPxDateEdit>
            </td>
        </tr>
        <tr>
            <td>Hasta : 
            </td>
            <td>
                <dx:ASPxDateEdit ID="DEFHasta" runat="server" Width="150px" CssClass="dxsplControl_DevEx">
                </dx:ASPxDateEdit>
            </td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <dx:ASPxGridView ID="ASPxGridView1" runat="server" Theme="DevEx" AutoGenerateColumns="False" DataSourceID="SqlDtTareoProcesado" KeyFieldName="ID" Width="100%"  >
                    <SettingsAdaptivity>
                        <AdaptiveDetailLayoutProperties ColCount="1">
                        </AdaptiveDetailLayoutProperties>
                    </SettingsAdaptivity>
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
                    <GroupSummary>
                        <dx:ASPxSummaryItem FieldName="ID" SummaryType="Count" />
                    </GroupSummary>
                    <EditFormLayoutProperties ColCount="1">
                    </EditFormLayoutProperties>
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" VisibleIndex="0" Visible="False">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewBandColumn Caption="Tareador" HeaderStyle-HorizontalAlign="Center" VisibleIndex="1">
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <Columns>
                                <dx:GridViewDataTextColumn Caption="Tareador" FieldName="TAREADOR" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Id Tareador" FieldName="ID_TAREADOR" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                </dx:GridViewDataTextColumn>
                            </Columns>
                        </dx:GridViewBandColumn>
                        <dx:GridViewBandColumn Caption="Datos trabajador" HeaderStyle-HorizontalAlign="Center" VisibleIndex="2">
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <Columns>
                                <dx:GridViewDataTextColumn Caption="Id personal" FieldName="ID_PERSONAL" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Personal" FieldName="NOMBRE" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Id proyecto" FieldName="ID_PROYECTO" ShowInCustomizationForm="True" VisibleIndex="4">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Proyecto" FieldName="PROYECTO" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Id situación" FieldName="ID_SITUACION" ShowInCustomizationForm="True" Visible="False" VisibleIndex="3">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Situación" FieldName="SITUACION" ShowInCustomizationForm="True" VisibleIndex="6">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Id clase trabajador" FieldName="ID_CLASE_TRABAJADOR" ShowInCustomizationForm="True" Visible="False" VisibleIndex="5">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Clase trabajador" FieldName="CLASE_TRABAJADOR" ShowInCustomizationForm="True" VisibleIndex="8">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Id horario" FieldName="ID_HORARIO" ShowInCustomizationForm="True" Visible="False" VisibleIndex="7">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Horario" FieldName="HORARIO" ShowInCustomizationForm="True" VisibleIndex="10">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Id puesto" FieldName="ID_PUESTO" ShowInCustomizationForm="True" Visible="False" VisibleIndex="9">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Puesto" FieldName="PUESTO" ShowInCustomizationForm="True" VisibleIndex="11">
                                </dx:GridViewDataTextColumn>
                            </Columns>
                        </dx:GridViewBandColumn>
                        <dx:GridViewBandColumn Caption="Tareo" HeaderStyle-HorizontalAlign="Center" VisibleIndex="14">
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <Columns>
                                <dx:GridViewDataDateColumn Caption="F. tareo" FieldName="FECHA_TAREO" ShowInCustomizationForm="True" VisibleIndex="0">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="F. ingreso" FieldName="FECHA_TAREO_REG_ING" ShowInCustomizationForm="True" VisibleIndex="1">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataTextColumn Caption="H. ingreso" FieldName="HORA_TAREO_REG_ING" ShowInCustomizationForm="True" VisibleIndex="2">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataDateColumn Caption="F. salida almorzar" FieldName="FECHA_TAREO_REG_SAL_ALM" ShowInCustomizationForm="True" VisibleIndex="3">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataTextColumn Caption="H. salida almorzar" FieldName="HORA_TAREO_REG_SAL_ALM" ShowInCustomizationForm="True" VisibleIndex="4">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataDateColumn Caption="F. regreso almorzar" FieldName="FECHA_TAREO_REG_REG_ALM" ShowInCustomizationForm="True" VisibleIndex="5">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataTextColumn Caption="H. regreso almorzar" FieldName="HORA_TAREO_REG_REG_ALM" ShowInCustomizationForm="True" VisibleIndex="6">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataDateColumn Caption="F. salida" FieldName="FECHA_TAREO_REG_SAL" ShowInCustomizationForm="True" VisibleIndex="7">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataTextColumn Caption="H. salida" FieldName="HORA_TAREO_REG_SAL" ShowInCustomizationForm="True" VisibleIndex="8">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="H. trabajadas" FieldName="HORAS_TRABAJADAS_DIARIAS" ShowInCustomizationForm="True" VisibleIndex="9">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="H. almuerzo" FieldName="HORAS_ALMUERZO_DIARIAS" ShowInCustomizationForm="True" VisibleIndex="10">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="H. productivas" FieldName="HORAS_PRODUCTIVAS_DIARIAS" ShowInCustomizationForm="True" VisibleIndex="12">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Obs." FieldName="OBSERVACION" ShowInCustomizationForm="True" Visible="False" VisibleIndex="11">
                                </dx:GridViewDataTextColumn>
                            </Columns>
                        </dx:GridViewBandColumn>
                    </Columns>
                </dx:ASPxGridView>
            </td>
        </tr>

    </table>

    <br />
    <asp:SqlDataSource
        ID="SqlDtTareoProcesado"
        ConnectionString="<%$ ConnectionStrings:constr %>"
        runat="server"
        SelectCommand="LISTAR_TAREO_PROCESADO_ALL"
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
</asp:Content>
