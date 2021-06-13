<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.master" CodeBehind="Default.aspx.cs" Inherits="WebTareoHaug._Default" %>


<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <%-- DXCOMMENT: Configure ASPxGridView control --%>
<dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="True" DataSourceID="SqlDataSource1" ClientInstanceName="ASPxGridView1" KeyFieldName="CustomerID" Width="100%">
<SettingsAdaptivity>
<AdaptiveDetailLayoutProperties ColCount="1"></AdaptiveDetailLayoutProperties>
</SettingsAdaptivity>

    <SettingsPager PageSize="32" />
    <Settings VerticalScrollBarMode="Visible" VerticalScrollableHeight="350" ShowGroupPanel="True" />
    <Paddings Padding="0px" />
    <Border BorderWidth="0px" />
    <BorderBottom BorderWidth="1px" />
    <%-- DXCOMMENT: Configure ASPxGridView's columns in accordance with datasource fields --%>
    <SettingsSearchPanel Visible="True" />

<EditFormLayoutProperties ColCount="1"></EditFormLayoutProperties>
    <Columns>
        <dx:GridViewCommandColumn VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn FieldName="ContactName" VisibleIndex="2">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CompanyName" VisibleIndex="1">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ContactTitle" VisibleIndex="3">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="City" VisibleIndex="5">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Phone" VisibleIndex="9">
        </dx:GridViewDataTextColumn>
    </Columns>
</dx:ASPxGridView>


<%-- DXCOMMENT: Configure your datasource for ASPxGridView --%>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:NWindConnectionString %>" 
        SelectCommand="SELECT * FROM [Customers]">
</asp:SqlDataSource>

</asp:Content>