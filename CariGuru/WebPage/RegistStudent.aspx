<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistStudent.aspx.cs" Inherits="CariGuru.WebPage.RegistStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contentStudent">

        <div class="headregister">
            <b>Register Student</b>
            <br />
        </div>

        <div class="isicontentstudent">

            <div>
                <b>Name</b>
                <br />
                <asp:TextBox class="textboxx" ID="usernameTxt" runat="server"></asp:TextBox>
                <asp:Label ID="usernameLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
            <div>
                <b>Password</b><br />
                <asp:TextBox class="textboxx" ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="passwordLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
            <div>
                <b>Email</b>
                <br />
                <asp:TextBox class="textboxx" ID="emailTxT" runat="server"></asp:TextBox>
                <asp:Label ID="emailLbl" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div>
                <b>Gender</b>
                <br />
                <asp:RadioButton ID="maleBtn" runat="server" Text="Male" />
                <asp:RadioButton ID="femaleBtn" runat="server" Text="Female" />
                <asp:Label ID="genderLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
            <div>
                <b>Address</b>
                <br />
                <textarea class="textareaa" id="Textarea1" cols="20" rows="3" runat="server"></textarea>
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
            <div>
                <b>Birthdate</b>
                <br />
                <asp:TextBox class="textboxx" ID="birthTxt" runat="server" TextMode="Date"></asp:TextBox>
                <asp:Label ID="birthLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
            <div>
                <b>PhoneNumber</b>
                <br />
                <asp:TextBox class="textboxx" ID="phoneTxt" runat="server" TextMode="Phone"></asp:TextBox>
                <asp:Label ID="phoneLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
            <div>
                <b>Degree</b>
                <br />
                <asp:DropDownList ID="degreeDL" runat="server">
                    <asp:ListItem>Select Degree</asp:ListItem>
                    <asp:ListItem>SD</asp:ListItem>
                    <asp:ListItem>SMP</asp:ListItem>
                    <asp:ListItem>SMA</asp:ListItem>
                    <asp:ListItem>S1</asp:ListItem>
                    <asp:ListItem>S2</asp:ListItem>
                    <asp:ListItem>S3</asp:ListItem>
                    <asp:ListItem>Lainnya</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="degreeLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>

            <div>
                <b>City</b><br />
                <asp:TextBox class="textboxx" ID="cityTxt" runat="server"></asp:TextBox>
                <asp:Label ID="cityLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>

            <div>
                <b>Province</b><br />
                <asp:DropDownList ID="DropDownListProvince" runat="server">
                    <asp:ListItem>Select Province</asp:ListItem>
                    <asp:ListItem>Aceh</asp:ListItem>
                    <asp:ListItem>Bali</asp:ListItem>
                    <asp:ListItem>Banten</asp:ListItem>
                    <asp:ListItem>Bengkulu</asp:ListItem>
                    <asp:ListItem>Gorontalo</asp:ListItem>
                    <asp:ListItem>DKI Jakarta</asp:ListItem>
                    <asp:ListItem>Jambi</asp:ListItem>
                    <asp:ListItem>Jawa Barat</asp:ListItem>
                    <asp:ListItem>Jawa Tengah</asp:ListItem>
                    <asp:ListItem>Jawa Timur</asp:ListItem>
                    <asp:ListItem>Kalimantan Barat</asp:ListItem>
                    <asp:ListItem>Kalimantan Tengah</asp:ListItem>
                    <asp:ListItem>Kalimantan Timur</asp:ListItem>
                    <asp:ListItem>Kalimantan Selatan</asp:ListItem>
                    <asp:ListItem>Kalimantan Utara</asp:ListItem>
                    <asp:ListItem>Bangka Belitung</asp:ListItem>
                    <asp:ListItem>Kepulauan Riau</asp:ListItem>
                    <asp:ListItem>Lampung</asp:ListItem>
                    <asp:ListItem>Maluku</asp:ListItem>
                    <asp:ListItem>Maluku Utara</asp:ListItem>
                    <asp:ListItem>NTT</asp:ListItem>
                    <asp:ListItem>NTB</asp:ListItem>
                    <asp:ListItem>Papua</asp:ListItem>
                    <asp:ListItem>Papua Barat</asp:ListItem>
                    <asp:ListItem>Riau</asp:ListItem>
                    <asp:ListItem>Sulawesi Utara</asp:ListItem>
                    <asp:ListItem>Sulawesi Barat</asp:ListItem>
                    <asp:ListItem>Sulawesi Tengah</asp:ListItem>
                    <asp:ListItem>Sulawesi Tenggara</asp:ListItem>
                    <asp:ListItem>Sulawesi Selatan</asp:ListItem>
                    <asp:ListItem>Sumatera Selatan</asp:ListItem>
                    <asp:ListItem>Sumatera Barat</asp:ListItem>
                    <asp:ListItem>Sumatera Utara</asp:ListItem>
                    <asp:ListItem>Yogyakarta</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="provinceLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
            <div>
                <b>Photo Profile</b><br />
                <asp:FileUpload ID="photoUpload" runat="server"></asp:FileUpload>
                <asp:Label ID="photoLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>

        </div>
        <asp:Button class="registbtn" ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />



    </div>
</asp:Content>
