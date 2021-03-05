<%@ Page Language="C#" MasterPageFile="~/Site.master"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Penerangan.Emedia2u.Web.MediaAdmin.Login" %>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 136px;
        }
        .auto-style3 {
            width: 136px;
            height: 20px;
        }
        .auto-style4 {
            height: 20px;
        }
        .auto-style5 {
            width: 136px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 136px;
            height: 30px;
        }
        .auto-style8 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
    <asp:Panel ID="loginPanel" runat="server" GroupingText="Log masuk ">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblError" runat="server" ForeColor="Red" Enabled="false"></asp:Label>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">Nama Pengguna :</td>
                <td>
                    <asp:TextBox ID="txtboxUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Kata Laluan :</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtboxPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">                  
                </td>
                <td class="auto-style8">
                    <asp:Label Visible="false" ID="lblResult" runat="server" />
                    <recaptcha:RecaptchaControl ID="recaptcha" runat="server" />
                    <asp:Button ID="txtButtonLoginSubmit" runat="server" Text="Hantar" OnClick="txtButtonLoginSubmit_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
   
</asp:Content>

