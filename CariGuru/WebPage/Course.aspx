<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Course.aspx.cs" Inherits="CariGuru.WebPage.Course" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Course
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <center>
     <asp:PlaceHolder ID="musikHld" runat="server">
       
         <div class="headcourse">
            Musik
        <table>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="gitarBtn" runat="server" Text="Gitar" OnClick="gitarBtn_Click" >Gitar</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="biolaBtn" runat="server" Text="Biola" OnClick="biolaBtn_Click" >Biola</asp:LinkButton>
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="pianoBtn" runat="server" Text="Piano" OnClick="pianoBtn_Click" >Piano</asp:LinkButton>
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="drumBtn" runat="server" Text="Drum" OnClick="drumBtn_Click" >Drum</asp:LinkButton>
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
        </table>
        </div>
    </asp:PlaceHolder>
    <asp:PlaceHolder ID="pengetahuanHld" runat="server">
        <div class="headcourse">
            Pengetahuan
        <table>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="matematikaBtn" runat="server" Text="Matematika" OnClick="matematikaBtn_Click" >Matematika</asp:LinkButton>
                     <br />
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="ipaBtn" runat="server" Text="IPA" OnClick="ipaBtn_Click" >IPA</asp:LinkButton>
                     <br />
                    
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="ipsBtn" runat="server" Text="IPS" OnClick="ipsBtn_Click" >IPS</asp:LinkButton>
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="bahasaBtn" runat="server" Text="Bahasa" OnClick="bahasaBtn_Click" >Bahasa</asp:LinkButton>
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
        </table>
        </div>
    </asp:PlaceHolder>
    <asp:PlaceHolder ID="olahragaHld" runat="server">
        <div class="headcourse">
            Olahraga
        <table>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="bolaBtn" runat="server" Text="Bola" OnClick="bolaBtn_Click" >Bola</asp:LinkButton>
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="bultangBtn" runat="server" Text="Bulu Tangkis" OnClick="bultangBtn_Click" >Bulu Tangkis</asp:LinkButton>
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="berenangBtn" runat="server" Text="Berenang" OnClick="berenangBtn_Click" >Berenang</asp:LinkButton>
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton class="isicourse" ID="silatBtn" runat="server" Text="Silat" OnClick="silatBtn_Click" >Silat</asp:LinkButton>
                </td>
            </tr>
             <tr>
                <td>
                    <br />
                </td>
            </tr>
        </table>
            
        </div>
    </asp:PlaceHolder>

    <div>
        <br /><br />
        <asp:Label ID="gridLbl" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:PlaceHolder ID="show" runat="server">
            <h2>
                <asp:Label ID="gridLbl2" runat="server" Text="Label"></asp:Label>
            </h2>
        </asp:PlaceHolder>
        <asp:GridView ID="GridViewTeacher" runat="server" AutoGenerateColumns="False">
            <Columns>
                
                <asp:HyperLinkField DataTextField="Name" HeaderText="Name" />
                
                <asp:ImageField DataImageUrlField="Photo" HeaderText="Profile Picture">
                    <ControlStyle Height="200px" Width="200px" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:ImageField>
            </Columns>
    </asp:GridView>
    </div>
    
    </center>
</asp:Content>
