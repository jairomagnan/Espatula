<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarReceta.aspx.cs" Inherits="Espatula.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel panel-default"><br /><br /></div>

    <div class="panel panel-default">
        <h2>Registre su receta aqu&iacute;</h2>
        <div class="form-group">
        
            <label id="nombreRecetaLb">Nombre de la receta</label>
            <input type="text" id="nombreReceta" /><br/>
        </div>
        <div class="form-group">
            <label id="instruccionesLb">Instrucciones de la receta</label>
            <input type="text" id="instrucciones" /><br />
        </div>
        <div class="form-group">
            <label id="imagenLb">imagen</label>
            <input type="url" id="imagen" title="Link de la imagen que quiere subir" /><br/>
        </div>
        <div class="form-group">   
            <label id="tipsLb">Tips</label>
            <input type="text" id="tips"  title="Consejos para la preparaci&oacute;n" /><br/>
        </div>
        <div class="form-group">
            <label id="categoriaLb">Categor&iacute;a</label>
            <select id="categorias"  runat="server">
                
            </select>
            <br />
        </div>
        <div class="form-group">
            <input type="submit" />
        </div>
       
    </div>
</asp:Content>

