<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="LamanUtama.aspx.cs"
    Inherits="Penerangan.Emedia2u.Web.LamanUtama" %>

<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
    <title></title>
    <link href="~/Styles/lamanutama.css" rel="stylesheet" type="text/css" />    
</head>
<body>
    <form id="Form1" runat="server">
    <div class="page">
        <div class="header">
            <div class="title">
                <h1>
                    &nbsp;</h1>
            </div>
            <asp:Image ID="Image1" runat="server" Height="130px" ImageUrl="~/Logo/LOGO.png" 
                Width="437px" />
        </div>
        <div class="main">
            <h2>
                SYARAT – SYARAT MEMOHON
            </h2>
            <p>
                1. Sila kemukakan :
            </p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            a. <b>Permohonan Baru :</b>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            i.&nbsp;&nbsp;&nbsp; Borang asal yang lengkap diisi
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            ii.&nbsp;&nbsp; 2 keping gambar terbaharu berukuran pasport
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            iii.&nbsp; Surat Perakuan dari Majikan/Kontrak Pekerja
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            b. <b>Memperbaharui</b>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            i.&nbsp;&nbsp; Borang asal yang lengkap diisi
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            ii.&nbsp;&nbsp; 2 keping gambar terbaharu berukuran passport
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            iii.&nbsp; Satu salinan Kad Pengenalan
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            iv.&nbsp; Surat Perakuan dari Majikan
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            v.&nbsp;&nbsp; Kad Perakuan Media yang lama / Salinan Laporan Polis jika kad hilang
            <br />
            <br />
            2. Nama pemohon dan nama pertubuhan/media yang diwakili hendaklah ditulis di belakang
            gambar.
            <br />
            <br />
            3. Pemohon yang layak memohon kad ini adalah mereka yang bertugas di lokai sesuatu
            acara rasmi kerajaan yang dihadiri oleh pemimpin utama Negara seperti SPBY di-Pertuan
            Agong dan YAB Perdana Menteri.<b>(Pengarang,Timbalan/Penolong Pengarang, Editor, Penerbit
                Rancangan, Wartawan Penyiaran, Wartawan, Juru Foto, Jurukamera dan Juruteknik Penyiaran)<br />
                <br />
            </b>&nbsp;4. Permohonan hendaklah disahkan oleh Pengarang atau wakil kanan pertubuhan/media
            yang diwakili oleh pemohon.Sila ambil perhatian, <b>petugas media yang sah dan berkerja
                dengan organisasi media yang tercatat sahaja boleh memohon Kad ini</b>.Sekiranya
            didapati ada pemohon dari luar organisasi yang memohon dengan menggunakan organisasi
            media tercatat dalam boring ini, organisasi media tersebut akan disenaraihitamkan.
            <br />
            <br />
            5. Kad Perakuan Media yang telah siap hendaklah diambil oleh pemohon sendiri/wakil
            dengan mengemukakan surat perwakilan kuasa.
            <br />
            <br />
            6. Borang Permohonan yang tidak lengkap dan tidak ditandatangani tidak akan diproses.<br />
            <br />
            &nbsp;7. Tempoh pemprosesan KPM adalah selama 3 hari bekerja.
            <br />
            <br />
            8. Pemohon adalah bertanggungjawab memberikan maklumat yang benar dan sahih.Sekiranya
            didapati pemohon memberikan maklumat palsu, pihak kami berhak menolak permohonan
            atau menarik balik Kad Perakuan Media yang telah diluluskan dan tindakan undang-undang
            sewajarnya boleh dikenakan kepada pemohon
            <br />
            <br />
            9. Pemohon tidak boleh memohon kad perakuan media yang sama dalam tempoh 7 hari.
             <br />
            <br />
        </div>
        <div class="clear">
        </div>
    </div>
    <div class="footer">
    </div>
    </form>
</body>
</html>
