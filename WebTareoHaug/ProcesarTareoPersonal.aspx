<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ProcesarTareoPersonal.aspx.cs" Inherits="WebTareoHaug.ProcesarTareoPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width: 100%;" class="dxsplControl_DevEx">
        <tr>
            <td colspan="3" style="text-align: center; font-family: Calibri; font-size: x-large;">Procesar tareo de personal</td>
        </tr>
        <tr>
            <td>Tareador : 
                <asp:DropDownList ID="DdlTareador" runat="server" Width="80%" CssClass="dxsplControl_DevEx"></asp:DropDownList>
            </td>
            <td>
            </td>
            <td>
                <dx:ASPxButton ID="BtnProcesar" runat="server" Text="Procesar" AutoPostBack="False" Width="100px" OnClick="BtnProcesar_Click" ImagePosition="Right" Theme="DevEx">
                    <ClientSideEvents Click="function(s, e) {                        
                        LoadingPanel.Show();
                        e.processOnServer = true; 
                    }" />
                    <Image IconID="programming_technology_16x16">
                    </Image>
                </dx:ASPxButton>  
            </td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
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
