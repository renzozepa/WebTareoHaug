<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="DispositivoDetalle.aspx.cs" Inherits="WebTareoHaug.DispositivoDetalle" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.1, Version=18.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>

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
            <td>Id</td>
            <td>
                <dx:ASPxLabel ID="LblId" runat="server" Text="ASPxLabel" Theme="DevEx"></dx:ASPxLabel>
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
            <td>&nbsp;</td>
            <td>Tareador</td>
            <td>
                <dx:ASPxLabel ID="LblIdTareador" runat="server" Theme="DevEx">
                </dx:ASPxLabel> - 
                <dx:ASPxLabel ID="LblTareador" runat="server" Theme="DevEx">
                </dx:ASPxLabel>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Token validación</td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" OnUnload="UpdatePanel1_Unload">
                    <ContentTemplate>                        
                        <dx:ASPxLabel ID="LblToken" CssClass="dxsplControl_DevEx" ClientInstanceName="LblToken" Theme="DevEx" runat="server" Text="ASPxLabel"></dx:ASPxLabel>
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
                    Modal="True">
                </dx:ASPxLoadingPanel>
            </td>
        </tr>
    </table>
</asp:Content>
