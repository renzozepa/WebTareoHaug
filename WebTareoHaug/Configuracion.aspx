<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Configuracion.aspx.cs" Inherits="WebTareoHaug.Configuracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;" class="dxsplControl_DevEx">
        <tr>
            <td colspan="4" style="text-align: center; font-family: Calibri; font-size: x-large;">Configuración General
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
            <td>Sucursal</td>
            <td>
                <dx:ASPxLabel ID="AlblCodigo" runat="server" Text="ASPxLabel"></dx:ASPxLabel>
                -
                <dx:ASPxLabel ID="AlblDescripcion" runat="server" Text="ASPxLabel"></dx:ASPxLabel>
            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Servidor</td>
            <td>
                <dx:ASPxTextBox ID="AtxtServidor" runat="server" Width="200px" Theme="DevEx"></dx:ASPxTextBox>
            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Base de datos</td>
            <td>
                <dx:ASPxTextBox ID="AtxtBD" runat="server" Width="200px" Theme="DevEx"></dx:ASPxTextBox>
            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Usuario</td>
            <td>
                <dx:ASPxTextBox ID="ATxtUsuario" runat="server" Width="200px" Theme="DevEx"></dx:ASPxTextBox>
            </td>
            <td></td>
        </tr>        
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Clave</td>
            <td>
                <dx:ASPxTextBox ID="AtxtPassword" Password="true" runat="server" Width="200px" Theme="DevEx"></dx:ASPxTextBox>
            </td>
            <td></td>
        </tr>
        <tr style="padding-bottom: 3px; padding-top: 3px; height: 30px;">
            <td></td>
            <td>Proyecto</td>
            <td>
                <dx:ASPxTextBox ID="AtxtCodProyecto" runat="server" Width="200px" Theme="DevEx"></dx:ASPxTextBox>
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
