<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Tp_3_WebForm.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div id="PanelCarrito" class="panel" style="width: 100%">
        <div class="panel-heading">
            <span style="font-size: 20px; font-style: oblique"><span style="font-size: larger;"><span style="margin-right: 5px" class="glyphicon glyphicon-th-list"></span>Productos</span></span>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col">
                <table class="table">
                    <tr class="bg-primary">
                        <td>Nombre</td>
                        <td>Precio</td>
                        <td>Cantidad</td>
                        <td>Imagen</td>
                        <td>Subtotal</td>
                        <td>Eliminar</td>
                    </tr>

                    <% if (ListaCarrito != null)
                        { %>
                    <%foreach (var Element in ListaCarrito)
                        {
                    %>

                    <tr>
                        <td><% = Element.Articulo.Nombre %></td>
                        <td><% = Element.Articulo.Precio %></td>
                        <td><% = Element.Cantidad %></td>
                        <td>
                            <img src="<% =Element.Articulo.UrlImagen %>" alt="Alternate Text" width="100" height="80" /></td>
                        <td><% = Element.Cantidad * Element.Articulo.Precio %></td>
                        <td><a href="Carrito.aspx?ID=<% = Element.Articulo.Id.ToString() %>" class="glyphicon glyphicon-remove"></a></td>
                    </tr>


                    <% } %>
                    <% } %>
                </table>

            </div>

        </div>
    </div>


</asp:Content>
