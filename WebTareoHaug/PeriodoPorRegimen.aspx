<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="PeriodoPorRegimen.aspx.cs" Inherits="WebTareoHaug.PeriodoPorRegimen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="script_local/select_value.js"></script>
    <table style="width: 100%;" class="dxsplControl_DevEx">
        <tr>
            <td style="width: 2%"></td>
            <td colspan="3" style="text-align: center; font-family: Calibri; font-size: x-large;">Tareo de Personal</td>
            <td style="width: 2%"></td>
        </tr>
        <tr>
            <td style="width: 2%"></td>
            <td>Tipo de Nómina : 
                <asp:DropDownList ID="DdlNomina" runat="server" Width="60%" CssClass="dxsplControl_DevEx"></asp:DropDownList>
            </td>
            <td>Periodo Anual: 
                <asp:DropDownList ID="ddlPeriodoAnual" runat="server" Width="20%" CssClass="dxsplControl_DevEx">
                    <asp:ListItem Value="0" Selected="True">--Seleccionar--</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem>2022</asp:ListItem>
                    <asp:ListItem>2023</asp:ListItem>
                    <asp:ListItem>2024</asp:ListItem>
                    <asp:ListItem>2025</asp:ListItem>
                    <asp:ListItem>2026</asp:ListItem>
                    <asp:ListItem>2027</asp:ListItem>
                    <asp:ListItem>2028</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <dx:ASPxButton ID="BtnVer" runat="server" Text="Ver" AutoPostBack="False" Width="20%" OnClick="BtnVer_Click" ImagePosition="Right" Theme="DevEx">
                    <ClientSideEvents Click="function(s, e) {                        
                        LoadingPanel.Show();
                        e.processOnServer = true; 
                    }" />
                    <Image IconID="find_find_16x16">
                    </Image>
                </dx:ASPxButton>
            </td>
            <td style="width: 2%"></td>
        </tr>
        <tr>
            <td style="width: 2%"></td>
            <td colspan="3">&nbsp;</td>
            <td style="width: 2%"></td>
        </tr>
        <tr>
            <td style="width: 2%"></td>
            <td colspan="3">
                <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" EnableTheming="True" Theme="DevEx" Width="100%">
                    <TabPages>
                        <dx:TabPage Text="Periodos">
                            <ContentCollection>
                                <dx:ContentControl runat="server" ID="Page1">
                                    <dx:ASPxGridView ID="GVPeriodos" runat="server" AutoGenerateColumns="False" EnableTheming="True" KeyFieldName="NroProyectoEsquemaPeriodoTareo"
                                        Theme="DevEx" Width="100%" EnableCallBacks="false"
                                        OnDataBinding="GVPeriodos_DataBinding" OnCustomButtonCallback="GVPeriodos_CustomButtonCallback">
                                        <SettingsAdaptivity>
                                            <AdaptiveDetailLayoutProperties ColCount="1">
                                            </AdaptiveDetailLayoutProperties>
                                        </SettingsAdaptivity>
                                        <SettingsPager AlwaysShowPager="True" NumericButtonCount="53" PageSize="53">
                                        </SettingsPager>
                                        <Settings ShowGroupPanel="True" VerticalScrollBarMode="Auto" />
                                        <SettingsResizing ColumnResizeMode="NextColumn" />
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
                                            <dx:GridViewDataTextColumn Caption="Id" FieldName="NroProyectoEsquemaPeriodoTareo" Visible="False" ReadOnly="True" VisibleIndex="0">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Código" FieldName="CodProyectoEsquemaPeriodoTareo" ReadOnly="False" VisibleIndex="1">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="NroProyectoEsquema" FieldName="NroProyectoEsquema" Visible="False" VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Descripcion" FieldName="Descripcion" VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Del" FieldName="Del" VisibleIndex="4" UnboundType="DateTime">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Al" FieldName="Al" VisibleIndex="5" UnboundType="DateTime">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="EstadoTareo" FieldName="EstadoTareo" VisibleIndex="6">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="AprobacionTareoUsuario" FieldName="AprobacionTareoUsuario" VisibleIndex="7">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="AprobacionTareoFecha" FieldName="AprobacionTareoFecha" VisibleIndex="8">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="NumeroPartes" FieldName="NumeroPartes" Visible="false" VisibleIndex="9">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewCommandColumn VisibleIndex="10" ButtonRenderMode="Image" ButtonType="Image"
                                                ShowEditButton="True" ShowInCustomizationForm="True">
                                                <CustomButtons>
                                                    <dx:GridViewCommandColumnCustomButton ID="BtnGenerar">
                                                        <Image IconID="actions_mailmerge_16x16devav" ToolTip="Generar">
                                                        </Image>
                                                    </dx:GridViewCommandColumnCustomButton>
                                                    <dx:GridViewCommandColumnCustomButton ID="BtnDetalle">
                                                        <Image ToolTip="Ver" IconID="actions_opendoc_16x16devav"></Image>
                                                    </dx:GridViewCommandColumnCustomButton>
                                                </CustomButtons>
                                            </dx:GridViewCommandColumn>
                                        </Columns>
                                        <GroupSummary>
                                            <dx:ASPxSummaryItem FieldName="NroProyectoEsquemaPeriodoTareo" SummaryType="Count" />
                                        </GroupSummary>
                                    </dx:ASPxGridView>
                                    <dx:ASPxPopupControl ID="pcAddDia" runat="server" Width="420" CloseAction="CloseButton"
                                        CloseOnEscape="true" Modal="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter"
                                        ClientInstanceName="pcEditar" HeaderText="Agregar Tareo" AllowDragging="True"
                                        PopupAnimationType="None" EnableViewState="False" AutoUpdatePosition="true" Theme="DevEx">
                                        <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroupEditar');  }" />
                                        <ContentCollection>
                                            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                                                <dx:ASPxPanel ID="ASPxPanel1" runat="server" DefaultButton="BtOkSave">
                                                    <PanelCollection>
                                                        <dx:PanelContent ID="PanelContent1" runat="server">
                                                            <dx:ASPxFormLayout runat="server" ID="ASPxFormLayout1" Width="100%" Height="100%">
                                                                <Items>
                                                                    <dx:LayoutItem Caption="Semana :">
                                                                        <LayoutItemNestedControlCollection>
                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                <dx:ASPxLabel ID="AlblCodSemana" runat="server" Text=""></dx:ASPxLabel>
                                                                                -
                                                                                <dx:ASPxLabel ID="AlblDescSemana" runat="server" Text=""></dx:ASPxLabel>
                                                                                <input id="hdCodSemana" runat="server" type="hidden" >
                                                                            </dx:LayoutItemNestedControlContainer>
                                                                        </LayoutItemNestedControlCollection>
                                                                    </dx:LayoutItem>
                                                                    <dx:LayoutItem Caption="Día :">
                                                                        <LayoutItemNestedControlCollection>
                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                <asp:DropDownList ID="ddlDia" runat="server" Width="60%" CssClass="dxsplControl_Aqua" onchange="showDiv(this)"></asp:DropDownList>
                                                                                <input id="hddia" runat="server" type="hidden" /> 
                                                                                <input id="hddiatext" runat="server" type="hidden" />
                                                                            </dx:LayoutItemNestedControlContainer>
                                                                        </LayoutItemNestedControlCollection>
                                                                    </dx:LayoutItem>
                                                                    <dx:LayoutItem ShowCaption="False" Paddings-PaddingTop="10">
                                                                        <LayoutItemNestedControlCollection>
                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                <dx:ASPxButton ID="BtnGenerarDia" AutoPostBack="false" runat="server" Text="Generar" Width="80px"
                                                                                    Style="float: left; margin-right: 8px" Theme="Aqua" OnClick="BtnGenerarDia_Click">                                                                                    
                                                                                </dx:ASPxButton>
                                                                            </dx:LayoutItemNestedControlContainer>
                                                                        </LayoutItemNestedControlCollection>
                                                                        <Paddings PaddingTop="19px"></Paddings>
                                                                    </dx:LayoutItem>
                                                                </Items>
                                                            </dx:ASPxFormLayout>
                                                        </dx:PanelContent>
                                                    </PanelCollection>
                                                </dx:ASPxPanel>
                                            </dx:PopupControlContentControl>
                                        </ContentCollection>
                                        <ContentStyle>
                                            <Paddings PaddingBottom="5px" />
                                        </ContentStyle>
                                    </dx:ASPxPopupControl>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                    </TabPages>
                </dx:ASPxPageControl>
            </td>
            <td style="width: 2%"></td>
        </tr>
        <tr>
            <td style="width: 2%"></td>
            <td colspan="3"></td>
            <td style="width: 2%"></td>
        </tr>
        <tr>
            <td style="width: 2%"></td>
            <td colspan="3">
                <dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
                    Modal="True">
                </dx:ASPxLoadingPanel>
            </td>
            <td style="width: 2%"></td>
        </tr>
    </table>
</asp:Content>
