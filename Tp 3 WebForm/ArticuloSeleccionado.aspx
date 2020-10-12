<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticuloSeleccionado.aspx.cs" Inherits="Tp_3_WebForm.ArticuloSeleccionado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />

    <div class="card">
        <img src="<% = MostrarArticulo.UrlImagen %>" class="card-img-top" width="250" alt="...">
        <div class="card-body">
            <h5 class="card-title"><% = MostrarArticulo.Nombre %></h5>
            <p title="Descripcion:" class="card-text"><% = MostrarArticulo.Descripcion %></p>
            <p title="Precio: $" class="card-text"><%=MostrarArticulo.Precio%></p>

        </div>
        <asp:Label Text="Cantidad" runat="server"></asp:Label>
        <asp:TextBox ID="TxtCantidad" Height="25px" Width="25px" runat="server"></asp:TextBox>
        <asp:Button ID="BtnDisminuir" CssClass="btn btn-primary" runat="server" Text="-" Height="30px" Width="33px" OnClick="BtnDisminuir_Click" />
        <asp:Button ID="BtnAumentar" CssClass="btn btn-primary" runat="server" Text="+" Height="30px" Width="33px" OnClick="BtnAumentar_Click" />
    </div>





</asp:Content>
