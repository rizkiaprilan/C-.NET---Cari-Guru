<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MySchedule.aspx.cs" Inherits="CariGuru.WebPage.MySchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    MySchedule
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="scheduleContainer">
        <h1>
            Jadwal Mengajar Anda
        </h1>
        <br />
        <div class="scheduleView">
            
            <div class="scheduleDays">
                Senin <br />
                <asp:Button id="monday" onclick="monday_Click" class="square"  runat="server" Text="" />
            </div>
            <div class="scheduleDays">
                Selasa <br />
                <asp:Button id="tuesday" onclick="tuesday_Click" class="square"  runat="server" Text="" />
            </div>
            <div class="scheduleDays">
                Rabu <br />
                <asp:Button id="wednesday" onclick="wednesday_Click" class="square" runat="server" Text="" />
            </div>
            <div class="scheduleDays">
                Kamis <br />
                <asp:Button id="thursday" onclick="thursday_Click" class="square" runat="server" Text="" />
            </div>
            <div class="scheduleDays">
                Jumat <br />
                <asp:Button id="friday" onclick="friday_Click" class="square" runat="server" Text="" />
            </div>
            <div class="scheduleDays">
                Sabtu <br />
                <asp:Button id="saturday" onclick="saturday_Click" class="square" runat="server" Text="" />
            </div>
           <%-- <div class="scheduleDays">
                Minggu <br />
                <asp:Button id="sunday" onclick="sunday_Click" class="square"  runat="server" Text="" />
            </div>--%>
        </div>

     

       
    </div>
</asp:Content>
