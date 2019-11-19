<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="CariGuru.WebPage.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Profile
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Profile
    </h1>
    <div class="container">
        <div id="imageHeader">
            <asp:Image ID="profileImage" runat="server" Width="200px" Height="200px" />
        </div>
        <div id="ViewProfile">

            <table class="about">
                <tr>

                    <td>
                        <b>
                            <asp:Label ID="NameTxt" runat="server" Text="Name"></asp:Label></b>
                    </td>
                </tr>


                <asp:PlaceHolder ID="teacherHolder1" runat="server">
                    <tr>
                        <td>
                            <p class="tooltip">TEACHER</p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p class="blueInfo">
                                <asp:Label ID="detail1Txt" runat="server" Text="Degree"></asp:Label>
                            </p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p class="blueInfo">
                                <asp:Label ID="detail2Txt" runat="server" Text="Degree"></asp:Label>
                            </p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p class="tooltip">RATINGS</p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="RatingTxt" runat="server" Text="Rating"></asp:Label>
                        </td>
                    </tr>
                </asp:PlaceHolder>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>

                <asp:PlaceHolder ID="studentHolder" runat="server">
                    <tr>
                        <td>
                            <p class="tooltip">STUDENT</p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p class="blueInfo">
                                <asp:Label ID="Degreetxt" runat="server" Text="Degree"></asp:Label>
                            </p>
                        </td>
                    </tr>
                </asp:PlaceHolder>
            </table>
            <br />
            <p class="tooltip">About</p>
            <div>
            </div>
            <hr style="width: 700px" />
            <br />
            <table class="about">
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <p class="tooltip">BASIC INFORMATION</p>
                    </td>
                </tr>


                <asp:PlaceHolder ID="studentHolder1" runat="server">
                    <tr>
                        <td>City:
                        </td>
                        <td>
                            <asp:Label ID="CityTxt" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>Province:
                        </td>
                        <td>
                            <asp:Label ID="ProvinceTxt" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>

                </asp:PlaceHolder>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>

                <tr>
                    <td>Email:
                    </td>
                    <td>
                        <asp:Label ID="EmailTxt" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>Gender:
                    </td>
                    <td>
                        <asp:Label ID="GenderTxt" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>Address:
                    </td>
                    <td>
                        <asp:Label ID="AddressTxt" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>Date of Birth:
                    </td>
                    <td>
                        <asp:Label ID="DOBTxt" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>Telephone:
                    </td>
                    <td>
                        <asp:Label ID="TelephoneTxt" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <asp:PlaceHolder ID="teacherHolder" runat="server">
                    <tr>
                        <td>cv:
                        </td>
                        <td>
                            <asp:Image ID="CVImg" runat="server" Width="200px" Height="200px" />
                        </td>
                    </tr>

                    <tr>
                        <td>Ijazah:
                        </td>
                        <td>
                            <asp:Image ID="IjazahImg" runat="server" Width="200px" Height="200px" />
                        </td>
                    </tr>
                    <tr>
                        <td>KTP:
                        </td>
                        <td>
                            <asp:Image ID="KTPImg" runat="server" Width="200px" Height="200px" />
                        </td>
                    </tr>

                </asp:PlaceHolder>
                

            </table>
            <asp:PlaceHolder ID="insertHld" runat="server">Category 1
                    <asp:DropDownList ID="category1" runat="server" OnSelectedIndexChanged="category1DL_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>Select Item</asp:ListItem>
                        <asp:ListItem>Musik</asp:ListItem>
                        <asp:ListItem>Pengetahuan</asp:ListItem>
                        <asp:ListItem>Olahraga</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="detailMusik1" runat="server" AutoPostBack="false">
                        <asp:ListItem>Gitar</asp:ListItem>
                        <asp:ListItem>Biola</asp:ListItem>
                        <asp:ListItem>Piano</asp:ListItem>
                        <asp:ListItem>Drum</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="detailPengetahuan1" runat="server" AutoPostBack="false">
                        <asp:ListItem>Matematika</asp:ListItem>
                        <asp:ListItem>IPA</asp:ListItem>
                        <asp:ListItem>IPS</asp:ListItem>
                        <asp:ListItem>Bahasa</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="detailOlahraga1" runat="server" AutoPostBack="false">
                        <asp:ListItem>Bola</asp:ListItem>
                        <asp:ListItem>Bulu Tangkis</asp:ListItem>
                        <asp:ListItem>Berenang</asp:ListItem>
                        <asp:ListItem>Silat</asp:ListItem>
                    </asp:DropDownList>
                </asp:PlaceHolder>

                <asp:PlaceHolder ID="insertHld2" runat="server">Category 2
                    <asp:DropDownList ID="category2" runat="server" OnSelectedIndexChanged="category2DL_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>Select Item</asp:ListItem>
                        <asp:ListItem>Musik</asp:ListItem>
                        <asp:ListItem>Pengetahuan</asp:ListItem>
                        <asp:ListItem>Olahraga</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="detailMusik2" runat="server" AutoPostBack="false">
                        <asp:ListItem>Gitar</asp:ListItem>
                        <asp:ListItem>Biola</asp:ListItem>
                        <asp:ListItem>Piano</asp:ListItem>
                        <asp:ListItem>Drum</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="detailPengetahuan2" runat="server" AutoPostBack="false">
                        <asp:ListItem>Matematika</asp:ListItem>
                        <asp:ListItem>IPA</asp:ListItem>
                        <asp:ListItem>IPS</asp:ListItem>
                        <asp:ListItem>Bahasa</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="detailOlahraga2" runat="server" AutoPostBack="false">
                        <asp:ListItem>Bola</asp:ListItem>
                        <asp:ListItem>Bulu Tangkis</asp:ListItem>
                        <asp:ListItem>Berenang</asp:ListItem>
                        <asp:ListItem>Silat</asp:ListItem>
                    </asp:DropDownList>
                </asp:PlaceHolder>
            <div>
                <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
            </div>
        </div>
    </div>

</asp:Content>
