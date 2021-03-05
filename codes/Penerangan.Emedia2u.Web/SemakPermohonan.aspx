<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="SemakPermohonan.aspx.cs" Inherits="Penerangan.Emedia2u.Web.SemakPermohonan" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .auto-style7 {
            width: 100%;
        }
        .auto-style8 {
            width: 167px;
        }
        .auto-style9 {
            width: 290px;
        }
        .auto-style10 {
            width: 167px;
            height: 26px;
            text-align: left;
        }
        .auto-style11 {
            width: 290px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
        }
        .auto-style13 {
            width: 167px;
            height: 26px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <h2>Semak Permohonan</h2><br />
    <p>Sila Masukkan No Borang <strong>ATAU</strong> No Kad Pengenalan untuk menyemak pendaftaran anda </p>
    <table class="auto-style7">
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:RadioButtonList ID="rdBtnListBorang" runat="server" Height="46px" Width="147px">
                    <asp:ListItem Value="0">No Borang</asp:ListItem>
                    <asp:ListItem Value="1">No Kad Pengenalan</asp:ListItem>
                </asp:RadioButtonList>     
                <asp:RequiredFieldValidator runat="server" ID="rdListValidate" ValidationGroup="valGroup1" ControlToValidate="rdBtnListBorang" ErrorMessage="Tolong pilih antara satu"/>           
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="txtBoxNoBorang" runat="server" validationgroup="valGroup1"></asp:TextBox>               
                <br />
                <asp:TextBox ID="txtBoxKadPengenalan" runat="server" validationgroup="valGroup1"></asp:TextBox>                
            </td>
            <td class="auto-style12">
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="btnHantar" runat="server" Text="Hantar" OnClick="btnHantar_Click" ValidationGroup="valGroup1" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <strong>Result:</strong></td>
            <td class="auto-style9">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="txtNoBorang" runat="server" Text="No Borang :"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtRsltNoBorang" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="lblNamaMedia" runat="server" Text="Nama Pemohon :"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtRsltMedia" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">
                <asp:Label ID="lblTarikhPermohonan" runat="server" Text="No Kad Pengenalan :"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="txtRsltTarikh" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="lblStatus" runat="server" Text="Jawatan :"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtRsltStatus" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>


</asp:Content>
