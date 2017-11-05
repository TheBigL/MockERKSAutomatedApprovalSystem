<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrganizationForm.aspx.cs" Inherits="Automated_Approval_System_OrganizationForm" MasterPageFile="~/Site.master" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div class="row">
        <asp:Label AssociatedControlID="OrgID" Text="Organization ID" runat="server"></asp:Label>
        <asp:TextBox ID="OrgName" Wrap Enabled="false" runat="server"></asp:TextBox>

        <asp:Label AssociatedControlID="OrgName" Text="Organization Name" runat="server"></asp:Label>
        <asp:TextBox ID="OrgName" runat="server" Wrap></asp:TextBox>

        <asp:Label AssociatedControlID="OrgAddress" Text="Organization Address" runat="server"></asp:Label>
        <asp:TextBox ID="OrgAddress" Wrap runat="server"></asp:TextBox>

        




    </div>

</asp:Content>