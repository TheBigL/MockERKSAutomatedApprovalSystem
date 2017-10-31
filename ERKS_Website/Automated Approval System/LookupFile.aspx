<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LookupFile.aspx.cs" Inherits="Automated_Approval_System_LookupFile" MasterPageFile="~/Site.master" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <asp:Label runat="server" Text="Name" Font-Bold="true"></asp:Label>
        <asp:TextBox runat="server" MaxLength="120" style="margin-left: 93px" Width="299px"></asp:TextBox><br />

        <asp:Label runat="server" Text="From" Font-Bold="true"></asp:Label>
        <asp:TextBox runat="server" style="margin-left: 93px"></asp:TextBox>


        <asp:Label runat="server" Text="Form" Font-Bold="true"></asp:Label>



        <asp:Calendar runat="server"></asp:Calendar>

    </div>

    </div>

    </div>

</asp:Content>
