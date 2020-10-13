<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticuloSeleccionado.aspx.cs" Inherits="Tp_3_WebForm.ArticuloSeleccionado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />

    
        <img src="<% = MostrarArticulo.UrlImagen %>"  width="250"  height="300" alt="error">
        
            <h5 style="font-size:20px"><% = MostrarArticulo.Nombre %></h5>
            <p style="font-size:12px"><% = MostrarArticulo.Descripcion %></p>
            <p style="font-size:15px">Precio: $<%=MostrarArticulo.Precio%></p>

        <asp:Label Text="Cantidad" runat="server"></asp:Label>
        <asp:TextBox ID="TxtCantidad" Height="25px" Width="25px" runat="server"></asp:TextBox>
        <asp:Button ID="BtnDisminuir" CssClass="btn btn-primary" runat="server" Text="-" Height="30px" Width="33px" OnClick="BtnDisminuir_Click" />
        <asp:Button ID="BtnAumentar" CssClass="btn btn-primary" runat="server" Text="+" Height="30px" Width="33px" OnClick="BtnAumentar_Click" />
    

    <br />
    <br />

    <asp:Button ID="BtnAgregar" Text="Agregar" CssClass="btn btn-secondary" runat="server" OnClick="BtnAgregar_Click"/>
    </asp:Content>
