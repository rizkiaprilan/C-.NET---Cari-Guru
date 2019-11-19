<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CariGuru.WebPage.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Register
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <center>
      <asp:Button class="registasteacher" ID="Button1" runat="server" Text="Register As Teacher" OnClick="Button1_Click" />
      <asp:Button class="registasteacher" ID="Button2" runat="server" Text="Register As Student" OnClick="Button2_Click" />
     </center>
</asp:Content>
