<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="SenaraiPermohonan.aspx.cs" Inherits="Penerangan.Emedia2u.Web.SenaraiPermohonan" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:GridView ID="permohonanGridview" onrowdatabound="permohonanGridview_RowDataBound" AllowPaging="True" AllowSorting="True" runat="server"></asp:GridView> 
    <div> <%=permohonanGridview.PageIndex + 1%>
        of
        <%=permohonanGridview.PageCount%></div>
</asp:Content>