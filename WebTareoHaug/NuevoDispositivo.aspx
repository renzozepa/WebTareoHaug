<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="NuevoDispositivo.aspx.cs" Inherits="WebTareoHaug.NuevoDispositivo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
    <table style="width: 100%;" class="dxsplControl_DevEx">
        <tr>
            <td colspan="4" style="text-align: center; font-family: Calibri; font-size: x-large;">Detalle de dispositivo
            </td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td style="width: 20%;">&nbsp;</td>
            <td style="width: 20%;">&nbsp;</td>
            <td style="width: 50%;">&nbsp;</td>
            <td style="width: 10%;">&nbsp;</td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Tareador</td>
            <td>
                <dx:ASPxLabel ID="LblId" runat="server" Text="" Theme="DevEx"></dx:ASPxLabel> - <dx:ASPxLabel ID="LblTareador" runat="server" Text="" Theme="DevEx"></dx:ASPxLabel>
            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Descripción</td>
            <td>
                <dx:ASPxTextBox ID="TxtDescripcion" runat="server" Width="200px" Theme="DevEx"></dx:ASPxTextBox>
            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Nro. Celular</td>
            <td>
                <dx:ASPxTextBox ID="TxtNroCelular" runat="server" Width="150px" Theme="DevEx"></dx:ASPxTextBox>
            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Token validación</td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" OnUnload="UpdatePanel1_Unload">
                    <ContentTemplate>                        
                        <dx:ASPxLabel ID="LblToken" CssClass="dxsplControl_DevEx" Theme="DevEx" runat="server" ClientInstanceName="LblToken" Text=""></dx:ASPxLabel>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="BtnGenerar" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
                <dx:ASPxButton ID="BtnGenerar" AutoPostBack="false" runat="server" CssClass="dxsplControl_DevEx" Text="Generar Token" Width="300px" OnClick="BtnGenerar_Click" Theme="DevEx">
                    <Image IconID="actions_refresh_16x16">
                    </Image>
                </dx:ASPxButton>
                <br />

            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Fecha solicitud</td>
            <td>
                <dx:ASPxDateEdit ID="DEFSolicitud" runat="server" Width="190" Theme="DevEx">
                    <CalendarProperties>
                        <FastNavProperties DisplayMode="Inline" />
                    </CalendarProperties>
                </dx:ASPxDateEdit>
            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Fecha alta</td>
            <td>
                <dx:ASPxDateEdit ID="DEFAlta" runat="server" Width="190" Theme="DevEx">
                    <CalendarProperties>
                        <FastNavProperties DisplayMode="Inline" />
                    </CalendarProperties>
                </dx:ASPxDateEdit>
            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Fecha expiración</td>
            <td>
                <dx:ASPxDateEdit ID="DEFExpiracion" runat="server" Width="190" Theme="DevEx">
                    <CalendarProperties>
                        <FastNavProperties DisplayMode="Inline" />
                    </CalendarProperties>
                </dx:ASPxDateEdit>
            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Estado</td>
            <td>
                <asp:CheckBox ID="CBEstado" CssClass="dxsplControl_DevEx" runat="server" />
            </td>
            <td></td>
        </tr>
        <tr>
            <td colspan="4" style="height: 25px; width: 100px;"></td>
        </tr>
        <tr>
            <td colspan="4">
                <center>
                    <dx:ASPxButton ID="BtnGuardar" runat="server" AutoPostBack="False" CssClass="dxsplControl_DevEx" Text="Guardar" Width="100px" OnClick="BtnGuardar_Click" ImagePosition="Right" Theme="DevEx">
                        <ClientSideEvents Click="function(s, e) {                        
                            LoadingPanel.Show();
                            e.processOnServer = true; 
                        }" />
                        <Image IconID="save_save_16x16">
                        </Image>
                    </dx:ASPxButton>                     
                    <dx:ASPxButton ID="BtnRegresar" runat="server" CssClass="dxsplControl_DevEx" Text="Regresar" Width="100px" OnClick="BtnRegresar_Click" ImagePosition="Right" Theme="DevEx">
                        <Image IconID="navigation_backward_16x16">
                        </Image>
                    </dx:ASPxButton>
                </center>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
                    Modal="True" Theme="DevEx">
                </dx:ASPxLoadingPanel>
            </td>
        </tr>
    </table>
    <dx:ASPxPopupControl ID="pcMensaje" runat="server" Width="420px" CloseAction="CloseButton" CloseOnEscape="true" Modal="True"
                        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcMensaje"
                        HeaderText="Mensaje" AllowDragging="True" PopupAnimationType="None" EnableViewState="False" AutoUpdatePosition="true" Theme="DevEx">
                        <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroup'); btCancel.Focus(); }" />
                        <ContentCollection>
                            <dx:PopupControlContentControl runat="server">
                                <dx:ASPxPanel ID="ASPxPanel4" runat="server" DefaultButton="btOK">
                                    <PanelCollection>
                                        <dx:PanelContent runat="server">
                                            <dx:ASPxFormLayout runat="server" ID="ASPxFormLayout5" Width="100%" Height="100%">
                                                <Items>
                                                    <dx:LayoutItem ShowCaption="False" Paddings-PaddingTop="10">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer>
                                                                <asp:Label ID="lblMensaje" runat="server" Text="Label" CssClass="dxsplControl_DevEx"></asp:Label>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <Paddings PaddingTop="10px"></Paddings>
                                                    </dx:LayoutItem>
                                                    <dx:LayoutItem ShowCaption="False" Paddings-PaddingTop="10">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer>
                                                                <dx:ASPxButton ID="btCancel" runat="server" ClientInstanceName="btCancel" Text="Ok" Width="80px" AutoPostBack="False" Style="float: left; margin-right: 8px" Theme="DevEx">
                                                                    <ClientSideEvents Click="function(s, e) { pcMensaje.Hide(); }" />
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
</asp:Content>
