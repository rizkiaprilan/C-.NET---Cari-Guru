<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CariGuru.WebPage.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    About
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <br />

    <div class="contentAbout">
        <%--<div>
            <h1>Temukan Jawaban Anda di Sini!</h1>
        </div>--%>
        
        <br />
        <div>
            <h1>Pertanyaan Umum</h1>
        </div>
        <br />
        <hr />
        <br />
        <div class="button">
            <asp:Button class="btn" ID="Button1" runat="server" Text="Murid" OnClick="Button1_Click" />
            <asp:Button class="btn" ID="Button2" runat="server" Text="Guru" OnClick="Button2_Click"  />
        </div>
        <br />
        <div id="Murid" runat="server" visible="false">
            <p>
                1. Siapa saja yang bisa memakai aplikasi Cari Guru?
               
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Jawaban: Aplikasi ini bisa di pakai oleh semua kalangan. Mulai dari SD, SMP, SMA, dan juga perguruan tinggi. Aplikasi juga bisa diakses oleh kalangan yang ingin menjadi pengajar di aplikasi    Cari Guru.
            </p>
            <p>
                2. Bagaimana cara menjadi Murid di Cari Guru?</p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Jawaban: Cukup dengan registrasi langsung ke Web Cari Guru, kemudian isi seluruh data dengan lengkap dan kemudian login ke website.
            </p>
            <p>
                3. Bagaimana cara booking seorang guru di Cari Guru?

            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Jawaban: Anda bisa dengan memencet tab "Pelajaran" lalu memilih pelajaran yang sesuai anda inginkan lalu akan tampil booking untuk guru.
            </p>
            <p>
                4. Apakah saya bisa menghubungi Costumer Center?

            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Jawaban: Bisa, anda bisa menghubungi melalui:

            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Email: <a href="mailto:CariGuru@gmail.com">CariGuru@gmail.com</a>
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Telepon: 082134763465

            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Instagram: CariGuru
            </p>
            <p>
                5. Bagaimana cara pembayaran dalam booking guru?

            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Jawaban: Dalam aplikasi kita menggunakan pembayaran langsung ke pada gurunya, sesuai dengan harga yang ada di web.
            </p>
        </div>
        <div id="Guru" runat="server" visible="false">
            <p>
                1. Bagaimana cara Guru di Cari Guru?

            </p>
            <p style="width: 770px">
                &nbsp;&nbsp;&nbsp;&nbsp; Jawaban: Jika ingin mengajar, anda harus mengupload data registrasi beserta KTP, Ijazah(Optional) dan CV. Kemudian upload data.
            </p>
            <p>
                2. Bagaimana cara mencheck jika ada yang apply kelas?

            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Jawaban: Anda bisa check apply diEmail yang anda daftarkan pada Cari Guru.
            </p>
            <p>
                3. Bagaimana cara untuk mencancel atau memindahkan kelas yang sudah terdaftar?

            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Jawaban: Kelas masih bisa diCancel atau dipindahkan asalkan kelas belum disetujui oleh admin.
            </p>
            <p>
                4. Apakah saya bisa menghubungi Costumer Center?

            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Jawaban: Bisa, anda bisa menghubungi melalui:

            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Email: <a href="mailto:CariGuru@gmail.com">CariGuru@gmail.com</a>
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Telepon: 082134763465

            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp; Instagram: CariGuru
            </p>
            <p>
                5. Saya akan mendapat apa setelah saya mengajar?

            </p>
            <p style="width: 769px">
                &nbsp;&nbsp;&nbsp;&nbsp; Jawaban: Guru yang mengajar akan mendapat pembayaran langsung dari Student dengan nominal sesuai dengan harga yang ada di web dan Guru juga mendapat rating serta feedback dari    Student.
            </p>
        </div>
    </div>
</asp:Content>
