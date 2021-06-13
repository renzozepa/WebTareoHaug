<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Personal.aspx.cs" Inherits="WebTareoHaug.Personal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;" class="dxsplControl_DevEx">
        <tr>
            <td colspan="2" style="text-align: center; font-family: Calibri; font-size: x-large;">Personal disponible</td>
        </tr>
        <tr>
            <td>Tareador : 
                <asp:DropDownList ID="DdlTareador" runat="server" Width="80%" CssClass="dxsplControl_DevEx"></asp:DropDownList>
            </td>
            <td>
                <dx:ASPxButton ID="BtnVer" runat="server" Text="Ver" AutoPostBack="False" Width="100px" OnClick="BtnVer_Click" ImagePosition="Right" Theme="DevEx">
                    <ClientSideEvents Click="function(s, e) {                        
                        LoadingPanel.Show();
                        e.processOnServer = true; 
                    }" />
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
                <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" EnableTheming="True" Theme="DevEx" Width="100%">
                    <TabPages>
                        <dx:TabPage Text="Personal disponible">
                            <ContentCollection>
                                <dx:ContentControl runat="server" ID="Page1">
                                    <dx:ASPxGridView ID="GVPersonal" runat="server" AutoGenerateColumns="False" EnableTheming="True" KeyFieldName="ID_PERSONAL"
                                        Theme="DevEx" Width="100%"
                                        OnDataBinding="GVPersonal_DataBinding">
                                        <SettingsAdaptivity>
                                            <AdaptiveDetailLayoutProperties ColCount="1">
                                            </AdaptiveDetailLayoutProperties>
                                        </SettingsAdaptivity>
                                        <SettingsPager AlwaysShowPager="True" NumericButtonCount="20" PageSize="20">
                                        </SettingsPager>
                                        <Settings ShowGroupPanel="True" VerticalScrollBarMode="Auto" />
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
                                            <dx:GridViewDataTextColumn Caption="Id Personal" FieldName="ID_PERSONAL" ReadOnly="True" VisibleIndex="0">
                                                <EditFormSettings Visible="False" />
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Personal" FieldName="NOMBRE" ReadOnly="True" VisibleIndex="1">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Id Tipo Documento" FieldName="ID_TIPODOCUIDEN" Visible="False" VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Tipo Documento" FieldName="TIPODOCUIDEN" VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="DNI" FieldName="NUMERO_DOCUIDEN" VisibleIndex="4">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Id Situacion" FieldName="ID_SITUACION" Visible="False" VisibleIndex="5">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Situacion" FieldName="SITUACION" VisibleIndex="6">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Id Proyecto" FieldName="ID_PROYECTO" VisibleIndex="7">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Proyecto" FieldName="PROYECTO" VisibleIndex="8">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Id Tareador" FieldName="ID_TAREADOR" VisibleIndex="9">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Tareador" FieldName="TAREADOR" ReadOnly="True" VisibleIndex="10">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Id Clase Trabajador" FieldName="ID_CLASE_TRABAJADOR" Visible="False" VisibleIndex="11">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Clase Trabajador" FieldName="CLASE_TRABAJADOR" VisibleIndex="12">
                                            </dx:GridViewDataTextColumn>
                                        </Columns>
                                        <GroupSummary>
                                            <dx:ASPxSummaryItem FieldName="ID_PERSONAL" SummaryType="Count" />
                                        </GroupSummary>
                                    </dx:ASPxGridView>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Text="Personal cesado">
                            <ContentCollection>
                                <dx:ContentControl runat="server" ID="Page2">
                                    <dx:ASPxGridView ID="GVPersonalCesado" runat="server" AutoGenerateColumns="False"
                                        EnableTheming="True" KeyFieldName="ID_PERSONAL"
                                        Theme="DevEx" Width="100%"
                                        OnDataBinding="GVPersonalCesado_DataBinding">
                                        <SettingsAdaptivity>
                                            <AdaptiveDetailLayoutProperties ColCount="1">
                                            </AdaptiveDetailLayoutProperties>
                                        </SettingsAdaptivity>
                                        <SettingsPager AlwaysShowPager="True" NumericButtonCount="20" PageSize="20">
                                        </SettingsPager>
                                        <Settings ShowGroupPanel="True" VerticalScrollBarMode="Auto" />
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
                                            <dx:GridViewDataTextColumn Caption="Id Personal" FieldName="ID_PERSONAL" ReadOnly="True" VisibleIndex="0">
                                                <EditFormSettings Visible="False" />
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Personal" FieldName="NOMBRE" ReadOnly="True" VisibleIndex="1">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Id Tipo Documento" FieldName="ID_TIPODOCUIDEN" Visible="False" VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Tipo Documento" FieldName="TIPODOCUIDEN" VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="DNI" FieldName="NUMERO_DOCUIDEN" VisibleIndex="4">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Id Situacion" FieldName="ID_SITUACION" Visible="False" VisibleIndex="5">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Situacion" FieldName="SITUACION" VisibleIndex="6">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Id Proyecto" FieldName="ID_PROYECTO" VisibleIndex="7">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Proyecto" FieldName="PROYECTO" VisibleIndex="8">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Id Tareador" FieldName="ID_TAREADOR" VisibleIndex="9">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Tareador" FieldName="TAREADOR" ReadOnly="True" VisibleIndex="10">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Id Clase Trabajador" FieldName="ID_CLASE_TRABAJADOR" Visible="False" VisibleIndex="11">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Clase Trabajador" FieldName="CLASE_TRABAJADOR" VisibleIndex="12">
                                            </dx:GridViewDataTextColumn>
                                        </Columns>
                                        <GroupSummary>
                                            <dx:ASPxSummaryItem FieldName="ID_PERSONAL" SummaryType="Count" />
                                        </GroupSummary>
                                    </dx:ASPxGridView>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                    </TabPages>
                </dx:ASPxPageControl>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
                    Modal="True">
                </dx:ASPxLoadingPanel>
            </td>
        </tr>
    </table>

</asp:Content>
