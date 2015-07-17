
<%@ Page Title="Agregar Ingrediente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="agregar.aspx.cs" Inherits="Espatula.Ingredientes.agregar" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
    <div class="row">

    </div>
    
    <div class="container-fluid">
        <div class="jumbotron">
            <div class ="row">
                <h2> Agregar un ingrediente</h2>
            </div>

            <div class="row">
                <hr />
            </div>

            <div class="row">

                <div class="col-md-3">
                    <asp:TextBox ID="txtNombre" placeholder="Nombre del Ingrediente" runat="server"  Font-Size="Large"></asp:TextBox>  
                </div>
                <div class="col-md-9">

                </div>
             
            </div>

            <div class="row">


            </div>

            <div class="row">

                <h3> Descripción: </h3>
            </div>

            <div class="row" id="fila4" runat="server">
                <div class="col-md-6">
                    <asp:TextBox id="txtDesc" TextMode="multiline"  Rows="14" runat="server" Width="100%"></asp:TextBox> 
                </div>
                <div class="col-md-1">

                </div>
                <div class="col-md-4">
                    <div class="row">
                        <asp:Label ID="lblImg" Text="Imagen:" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <asp:Image id="imgDesc" runat="server" Style="max-height:400px; max-width:400px"/>
                    </div>
                    <div class="row">
                        <div class="column-md-1">
                            <asp:TextBox ID="txtImagen" runat="server" placeholder="Url de la imagen" Width="100%"></asp:TextBox>
                        </div>
                        <div class="column-md-1">
                            <asp:Button ID="btnImagen" runat="server" Text="Buscar" OnClick="btnImagen_Click" />
                        </div>
                        
                    
                    </div> 
                
                </div>

            </div>
            <div class="row">
                <hr style="color:black; background-color:black; height: 2px;"/>
            </div>
            <div class="row">
                <div class="col-md-1">

                </div>
                <asp:Button ID="btnAgregar" Text="Guardar el ingrediente" runat="server" OnClick="btnAgregar_Click" />
            </div>
        </div>
        
    </div>
    
</asp:Content>
