<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CariGuru.WebPage.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="background">
        <asp:Image class="background" ID="Image1" runat="server" ImageUrl="~/Media/bluebackground.jpg" AlternateText="BlueBackground" />
        <div class="tulisan">
            "Education is the passport to the future, for tomorrow belongs to those who prepere for it today."
        </div>
      
    </div>
    <br />
    <br />
    <div>        
            <video class="video" src="~/Media/Opening Home.mp4" runat="server" autoplay="autoplay" loop="loop" ></video>   
    </div>
    <br />
    <br />
</asp:Content>
