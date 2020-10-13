<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Tp_3_WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="container">
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <div class="col-md-3">
                    <div class="card">
                        <img src="<%#Eval("UrlImagen") %>" class="card-img top" style="max-width: 250px; max-height: 300px" alt="Error" />
                        <div class="card-body cards">
                            <h5 class="card-tittle" style="font-size: 15px"><%#Eval("Nombre")%></h5>
                            <p class="card-text" style="font-size: 15px"><%#Eval("Descripcion")%></p>
                        </div>
                    </div>
                     <a class="btn btn-primary" style="font-size: 12px;" href="ArticuloSeleccionado.aspx?id=<%#Eval("Id")%>">Ver</a>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>
    <br />
    <br />
    

</asp:Content>
