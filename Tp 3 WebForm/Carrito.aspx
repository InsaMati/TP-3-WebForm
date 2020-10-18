<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Tp_3_WebForm.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="table">

        <%if(ListaCarrito != null) 

        {%>
             <tr>
            <td>Nombre</td>
            <td>Cantidad</td>
            <td>Precio</td>
            <td>Subtotal</td>
            <td>Eliminar</td>
            </tr>

            <% foreach (var Item in ListaCarrito) 

                {%>
        <tr>
            <td> <% = Item.Articulo.Nombre %> </td>
            <td> <% = Item.Cantidad %> </td>
            <td> <% = Item.Articulo.Precio %>   </td>
            <td> <% = Item.Cantidad * Item.Articulo.Precio %></td>
            <td> <a href="Carrito.aspx?ID=<% = Item.Articulo.Id.ToString() %>" class="glyphicon glyphicon-trash"></a></td>
        </tr>
        <% } %>
        <% } %>
    </table>

</asp:Content>