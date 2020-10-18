<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Tp_3_WebForm.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="table">

        <%if(ListaCarrito != null) 

        {%>
             <tr>
            <td>
                <h3> Nombre   </h3>
            </td>
            <td>
                <h3> Cantidad </h3>
            </td>
            <td> <h3> Precio </h3>
            </td>
            <td>
                <h3> Subtotal </h3>
            </td>
            <td>
                <h3 style="color: red"> Eliminar </h3>
            </td>
            </tr>

            <% foreach (var Item in ListaCarrito) 

                {%>
        <tr>
            <td> &nbsp &nbsp<% = Item.Articulo.Nombre %> </td>
            <td> &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp <% = Item.Cantidad %> </td>
            <td> &nbsp &nbsp <% = Item.Articulo.Precio %>   </td>
            <td> &nbsp &nbsp &nbsp <% = Item.Cantidad * Item.Articulo.Precio %></td>
            <td> &nbsp &nbsp &nbsp <a href="Carrito.aspx?ID=<% = Item.Articulo.Id.ToString() %>" class="glyphicon glyphicon-trash"></a></td>
        </tr>
        <% } %>
        <% } %>
    </table>

    <asp:Button Text="Vaciar" ID="btnVaciar" runat="server" OnClick="btnVaciar_Click" class="btn btn-primary" />
    &nbsp
    <asp:Button Text="Volver" ID="btnVolver" runat="server" OnClick="btnVolver_Click" class="btn btn-primary" />
    &nbsp
    <asp:Button Text="Comprar" runat="server" class="btn btn-success"/>

</asp:Content>