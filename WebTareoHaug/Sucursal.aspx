<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Sucursal.aspx.cs" Inherits="WebTareoHaug.Sucursal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;" class="dxsplControl_DevEx">
        <tr>
            <td colspan="3" style="text-align: center; font-family: Calibri; font-size: x-large;">Sucursal</td>
        </tr>
        <tr>
            <td></td>
            <td>
                <center>
                    <label>Seleccionar sucursal</label>
                    <asp:DropDownList ID="DdlSucursal" runat="server" Width="80%" CssClass="dxsplControl_DevEx"></asp:DropDownList>
                </center>
            </td>
            <td></td>
        </tr>
        <tr>
            <td colspan="3">
                <center>
                    <dx:ASPxButton ID="BtnContinuar" runat="server" Text="Continuar" AutoPostBack="False" Width="100px" OnClick="BtnContinuar_Click" ImagePosition="Right" Theme="DevEx">
                        <ClientSideEvents Click="function(s, e) {                        
                            LoadingPanel.Show();
                            e.processOnServer = true; 
                        }" />
                        <Image IconID="programming_technology_16x16">
                        </Image>
                    </dx:ASPxButton>
                </center>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
                    Modal="True">
                </dx:ASPxLoadingPanel>
            </td>
        </tr>
    </table>
</asp:Content>
