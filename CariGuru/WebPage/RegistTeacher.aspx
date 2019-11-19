<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistTeacher.aspx.cs" Inherits="CariGuru.WebPage.RegistTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contentStudent">

        <div class="headregister">
            <b>Register Teacher</b>
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
                <b>Password</b>
                <br />
                <asp:TextBox class="textboxx" ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="passwordLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
            <div>
                <b>Email</b>
                <br />
                <asp:TextBox class="textboxx" ID="emailTxT" runat="server"></asp:TextBox>
                <asp:Label ID="emailLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
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
                <b>BirthDate</b>
                <br />
                <asp:TextBox class="textboxx" ID="birthTxt" runat="server" TextMode="Date"></asp:TextBox>
                <asp:Label ID="birthLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
            <div>
                <b>Phone Number</b>
                <br />
                <asp:TextBox class="textboxx" ID="phoneTxt" runat="server" TextMode="Phone"></asp:TextBox>
                <asp:Label ID="phoneLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>
            <div>
                <b>CV</b>
                <br />
                <asp:FileUpload ID="cvUpload" runat="server"></asp:FileUpload>
                <asp:Label ID="cvLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>

            <div>
                <b>Ijazah</b><br />
                <asp:FileUpload ID="ijazahUpload" runat="server"></asp:FileUpload>
                <asp:Label ID="ijazahLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>

            <div>
                <b>KTP</b><br />
                <asp:FileUpload ID="ktpUpload" runat="server"></asp:FileUpload>
                <asp:Label ID="ktpLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>

            <div>
                <b>Rating</b><br />
                <asp:TextBox class="textboxx" ID="ratingTxt" runat="server"></asp:TextBox>
                <asp:Label ID="ratingLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>

            <div>
                <b>Photo Profile</b><br />
                <asp:FileUpload ID="photoUpload" runat="server"></asp:FileUpload>
                <asp:Label ID="photoLbl" runat="server" Text=""></asp:Label><br />
                <br />
            </div>

        </div>

        <asp:Button class="registbtn" ID="registBtn" runat="server" Text="Register" OnClick="registBtn_Click" />

    </div>
</asp:Content>
