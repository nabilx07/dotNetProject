<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="MediaRasmi.aspx.cs" Inherits="Penerangan.Emedia2u.Web.Borang.MediaRasmi" %>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 35px;
        }
        .style4
        {
            width: 121px;
            height: 20px;
        }
        .style5
        {
            width: 178px;
            height: 20px;
        }
        .style6
        {
            height: 20px;
        }
        .style9
        {
            height: 26px;
        }
        .style10
        {
            width: 121px;
            height: 26px;
        }
        .style11
        {
            width: 121px;
        }
        .style12
        {
            width: 100%;
        }
        .style14
        {
            width: 120px;
        }
        .style15
        {
            width: 178px;
            height: 26px;
        }
        .style16
        {
            width: 178px;
        }
        .style17
        {
            width: 181px;
        }
        .style18
        {
            width: 119px;
        }
        .style19
        {
            width: 186px;
        }
        .style22
        {
            width: 123px;
            height: 20px;
        }
        .style23
        {
            width: 177px;
            height: 20px;
        }
        .style24
        {
            width: 123px;
            height: 53px;
        }
        .style25
        {
            width: 177px;
            height: 53px;
        }
        .style26
        {
            height: 53px;
        }
        .auto-style2 {
            width: 188px;
        }
        .auto-style3 {
            width: 423px;
        }
        .auto-style4 {
            width: 141px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
       <script type="text/javascript">
        function WaterMarkFocus(txt, text) {
            if (txt.value == text) {
                txt.value = "";
                txt.style.color = "black";
            }
        }

        function WaterMarkBlur(txt, text) {
            if (txt.value == "") {
                txt.value = text;
                txt.style.color = "gray";
            }
        }
</script>
    <h2>
        Media Rasmi
    </h2>
    <asp:Panel ID="peribadiPanel" runat="server" 
        GroupingText="Maklumat Peribadi Pemohon" BackColor="#CCFF99">
        <table class="style1">
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td class="style15">
                    Nama:</td>
                <td class="style9">
                    <asp:TextBox ID="txtBoxNama" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Nama" ></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator1" controltovalidate="txtBoxNama" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    Alamat:</td>
                <td class="style6">
                    <asp:TextBox ID="txtBoxAlamat" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Alamat" ></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator2" controltovalidate="txtBoxAlamat" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                   Poskod :</td>
                <td>
                    <asp:TextBox ID="txtBoxPoskod" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Poskod" ></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator3" controltovalidate="txtBoxPoskod" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style10">
                </td>
                <td class="style15">
                    Negeri:</td>
                <td class="style9">
                    <asp:DropDownList ID="ddlNegeri" runat="server" ValidationGroup="valGroup1">
                        <asp:ListItem Value="0">Sila Pilih Negeri Anda</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator19" ValidationGroup="valGroup1" runat="server" ControlToValidate="ddlNegeri" ForeColor="Red"
    Text="*" errormessage="Pastikan tidak kosong"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Negara:</td>
                <td>
                    <asp:DropDownList ID="ddlNegara" runat="server" ValidationGroup="valGroup1">
                        <asp:ListItem Value="0">Sila Pilih Negara Anda</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator20" ValidationGroup="valGroup1" runat="server" ControlToValidate="ddlNegara" ForeColor="Red"
    Text="*" ErrorMessage="Pastikan tidak kosong"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style10">
                </td>
                <td class="style15">
                    Telefon Kediaman :
                </td>
                <td class="style9">
                    <asp:TextBox ID="txtBoxNoTelKediaman" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Telefon Kediaman" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator4" controltovalidate="txtBoxNoTelKediaman" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Telefon Bimbit:</td>
                <td>
                    <asp:TextBox ID="txtBoxBimbit" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Telefon Bimbit" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator5" controltovalidate="txtBoxBimbit" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Nombor Kad Pengenalan :</td>
                <td>
                    <asp:TextBox ID="txtBoxKadPengenalan" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Nombor Kad Pengenalan" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator6" controltovalidate="txtBoxKadPengenalan" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Tarikh Lahir :
                </td>
                <td>
                    <asp:TextBox ID="txtBoxTarikhLahir" runat="server" Width="310px" style="margin-bottom: 0px" ValidationGroup="valGroup1" Text="Masukkan Nombor Kad Pengenalan" >Contohnya : 28-02-2015</asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator27" controltovalidate="txtBoxTarikhLahir" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
                    <asp:Calendar ID="calendarTarikhLahir" runat="server" OnSelectionChanged="calendarTarikhLahir_SelectionChanged"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Jantina:</td>
                <td>
                    <asp:DropDownList ID="ddlJantina" runat="server" ValidationGroup="valGroup1">
                        <asp:ListItem>Sila Pilih Jantina</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" ValidationGroup="valGroup1" runat="server" ControlToValidate="ddlJantina" ForeColor="Red"
    Text="*" ErrorMessage="Pastikan tidak kosong"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Warganegara:</td>
                <td>
                    <asp:DropDownList ID="ddlWargaNegara" runat="server" ValidationGroup="valGroup1">
                        <asp:ListItem Value="0">Sila Pilih Kewargenaraan</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" ValidationGroup="valGroup1" runat="server" ControlToValidate="ddlWargaNegara" ForeColor="Red"
    Text="*" ErrorMessage="Pastikan tidak kosong"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Jawatan/Pekerjaan:</td>
                <td>
                    <asp:TextBox ID="txtBoxJawatanPekerjaan" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Jawatan/Pekerjaan" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator7" controltovalidate="txtBoxJawatanPekerjaan" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Emel:</td>
                <td>
                    <asp:TextBox ID="txtBoxEmel" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Emel" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator8" controltovalidate="txtBoxEmel" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Nombor Kad Lama:</td>
                <td>
                    <asp:TextBox ID="txtBoxNomborKadLama" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Nombor Kad Lama" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator9" controltovalidate="txtBoxNomborKadLama" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Warna Kad Lama:</td>
                <td>
                    <asp:DropDownList ID="ddlWarnaKad" runat="server" ValidationGroup="valGroup1">
                        <asp:ListItem Value="0">Sila pilih warna kad anda</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator23" ValidationGroup="valGroup1" runat="server" ControlToValidate="ddlWarnaKad" ForeColor="Red"
    Text="*" ErrorMessage="Pastikan tidak kosong"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style16">
                    Upload Gambar:</td>
                <td>
                    <asp:FileUpload ID="fileUpload" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="fileUpload"  ErrorMessage="Sila upload gambar" ForeColor="Red" ValidationGroup="valGroup1"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panelButirJabatan" runat="server" 
        GroupingText="Butir - Butir Jabatan/Organisasi Media" BackColor="#CCFF99">
        <table class="style12">
            <tr>
                <td class="style14">
                    &nbsp;</td>
                <td class="style17">
                    Nama Organisasi Media :
                </td>
                <td>
                    <asp:DropDownList ID="ddlMediaId" runat="server">
                        <asp:ListItem Value="0">Sila pilih organisasi media anda</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator24" ValidationGroup="valGroup1" runat="server" ControlToValidate="ddlMediaId" ForeColor="Red"
    Text="*" ErrorMessage="Pastikan tidak kosong"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style14">
                    &nbsp;</td>
                <td class="style17">
                    Singkatan Organisasi:</td>
                <td>
                    <asp:TextBox ID="txtBoxSingkatanOrganisasi" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan  Singkatan Organisasi:" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator11" controltovalidate="txtBoxSingkatanOrganisasi" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
 
                </td>
            </tr>
            <tr>
                <td class="style14">
                    &nbsp;</td>
                <td class="style17">
                    Alamat Media:</td>
                <td>
                    <asp:TextBox ID="txtBoxAlamatMedia" runat="server" style="margin-left: 0px" 
                        Width="310px" ValidationGroup="valGroup1" Text="Masukkan Alamat Media:" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator12" controltovalidate="txtBoxAlamatMedia" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
 
                </td>
            </tr>
            <tr>
                <td class="style14">
                    &nbsp;</td>
                <td class="style17">
                    Telefon Pejabat :</td>
                <td>
                    <asp:TextBox ID="txtBoxTelefonPejabat" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Telefon Pejabat" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator13" controltovalidate="txtBoxTelefonPejabat" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
 
                </td>
            </tr>
            <tr>
                <td class="style14">
                    &nbsp;</td>
                <td class="style17">
                    No Faks:</td>
                <td>
                    <asp:TextBox ID="txtBoxNoFaks" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan  No Faks" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator14" controltovalidate="txtBoxNoFaks" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
 
                </td>
            </tr>
            <tr>
                <td class="style14">
                    &nbsp;</td>
                <td class="style17">
                    Kategori:</td>
                <td>
                    <asp:TextBox ID="txtBoxKategori" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Kategori" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator15" controltovalidate="txtBoxKategori" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
 
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panelPengesahan" runat="server" 
        GroupingText="Pengesahan oleh Ketua Jabatan/Wakil Kanan Organisasi Media" BackColor="#CCFF99">
        <table class="style12">
            <tr>
                <td class="style18">
                    &nbsp;</td>
                <td class="style19">
                    Nama:</td>
                <td>
                    <asp:TextBox ID="txtBoxNamaKetuaJawatan" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Data" ></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator16" controltovalidate="txtBoxNamaKetuaJawatan" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
 
                </td>
            </tr>
            <tr>
                <td class="style18">
                    &nbsp;</td>
                <td class="style19">
                    Jawatan:</td>
                <td>
                    <asp:TextBox ID="txtBoxJawatanKetuaOrg" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Data" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator17" controltovalidate="txtBoxJawatanKetuaOrg" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
 
                </td>
            </tr>
            <tr>
                <td class="style18">
                    &nbsp;</td>
                <td class="style19">
                    Nama Jabatan/Organisasi Media:</td>
                <td>
                    <asp:TextBox ID="txtBoxNamaMedia" runat="server" Width="310px" ValidationGroup="valGroup1" Text="Masukkan Data" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator18" controltovalidate="txtBoxNamaMedia" validationgroup="valGroup1" errormessage="Pastikan tidak kosong" ForeColor="Red" runat="server" />
 
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server">
        <table class="style12">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;
                     <asp:Label Visible="false" ID="lblResult" runat="server" />
                    <recaptcha:RecaptchaControl ID="recaptcha" runat="server" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" ValidationGroup="valGroup1" Text="Hantar" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    </asp:Content>
           



   

