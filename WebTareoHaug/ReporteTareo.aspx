<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ReporteTareo.aspx.cs" Inherits="WebTareoHaug.ReporteTareo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;" class="dxsplControl_DevEx" >
        <tr>
            <td colspan="2" style="text-align:center; font-family: Calibri; font-size: x-large;">Tareo de personal</td>
        </tr>
        <tr>
            <td >
                Tareador : 
                <asp:DropDownList ID="DdlTareador" runat="server" Width="80%" CssClass="dxsplControl_DevEx"></asp:DropDownList>
            </td>
            <td >
                <dx:ASPxButton ID="BtnVer" runat="server" Width="100px" Text="Ver" OnClick="BtnVer_Click" ImagePosition="Right" Theme="DevEx">
                    <Image IconID="find_find_16x16">
                    </Image>
                </dx:ASPxButton>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <dx:ASPxGridView ID="ASPxGridView1" runat="server" Theme="DevEx" AutoGenerateColumns="False" DataSourceID="SqlDtTareo" KeyFieldName="ID" Width="100%">
                    <SettingsAdaptivity>
                        <AdaptiveDetailLayoutProperties ColCount="1">
                        </AdaptiveDetailLayoutProperties>
                    </SettingsAdaptivity>
                    <Settings ShowGroupPanel="True" VerticalScrollBarMode="Visible" VerticalScrollBarStyle="VirtualSmooth" />
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
                    <EditFormLayoutProperties ColCount="1">
                    </EditFormLayoutProperties>
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="Id" FieldName="ID" ReadOnly="True" VisibleIndex="0">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Id Tareador" FieldName="ID_TAREADOR" VisibleIndex="1">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="NOMBRE_COMPLETO" Caption="Tareador" VisibleIndex="2" ReadOnly="True"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Id Personal" FieldName="ID_PERSONAL" VisibleIndex="3">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Personal" FieldName="PERSONAL" VisibleIndex="4">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Proyecto" FieldName="ID_PROYECTO" VisibleIndex="5">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Id Situacion" FieldName="ID_SITUACION" VisibleIndex="6" Visible="False">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Situacion" FieldName="SITUACION" VisibleIndex="7">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Id Clase Trabajador" FieldName="ID_CLASE_TRABAJADOR" VisibleIndex="8" Visible="False">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Clase Trabajador" FieldName="CLASE_TRABAJADOR" VisibleIndex="9">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataDateColumn Caption="F. Tareo" FieldName="FECHA_TAREO" VisibleIndex="10">
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataTextColumn Caption="Tipo Marcación" FieldName="TIPO_MARCACION" VisibleIndex="11" Visible="False">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Marcación" FieldName="MARCACION" VisibleIndex="12">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Hora" FieldName="HORA" VisibleIndex="13">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataDateColumn Caption="F. Sincronizado" FieldName="FECHA_SINCRONIZADO" VisibleIndex="14">
                        </dx:GridViewDataDateColumn>
                    </Columns>
                </dx:ASPxGridView>

            </td>
        </tr>

    </table>

    <br />
    <asp:SqlDataSource
        ID="SqlDtTareo"
        ConnectionString="<%$ ConnectionStrings:constr %>"
        runat="server"
        SelectCommand="LISTAR_TAREO_PERSONAL"
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
</asp:Content>
