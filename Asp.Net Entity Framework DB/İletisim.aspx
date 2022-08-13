<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="İletisim.aspx.cs" Inherits="Asp.Net_Entity_Framework_DB.İletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered" style="margin-left: 20px; margin-right: 20px">
        <tr>
            <th>ID </th>
            <th>Ad Soyad </th>
            <th>Mail </th>
            <th>Konu </th>
            <th>Mesajı Gör </th>

        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td>
                        <%#Eval("ID") %>
                    </td>
                    <td><%#Eval("ADSOYAD") %></td>
                     <td><%#Eval("MAİL") %></td>
                     <td><%#Eval("KONU") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"MesajDetay.Aspx?ID=" + Eval("ID") %>'
                            CssClass="btn btn-warning" BackColor="#CC6699">
                            Mesajı GÖr</asp:HyperLink></td>

                    <%--                    <td><a ıd="<%#Eval("ID") %>" href="#" class="btn btn-success">Güncelle 2</a></td>--%>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
