<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarReceta.aspx.cs" Inherits="Espatula.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <br />
    <br />
    <br />

    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h2>Registre su receta aqu&iacute;</h2>
                    <div class="form-group">
        
                        <label id="nombreRecetaLb">Nombre de la receta</label><br/>
                        <input type="text" size="40" id="nombreReceta" /><br/>
                    </div>
                    <div class="form-group">
                        <label id="instruccionesLb">Instrucciones de la receta</label><br/>
                        <textarea name="instruccion" cols="40" rows="6" id="instrucciones"></textarea><br />
                    </div>
                    <div class="form-group">
                        <label id="imagenLb">imagen</label><br/>
                        <input type="url" size="40" id="imagen" title="Link de la imagen que quiere subir" /><br/>
                    </div>
                    <div class="form-group">   
                        <label id="tipsLb">Tips</label><br/>
                        <input type="text" size="40" id="tips"  title="Consejos para la preparaci&oacute;n" /><br/>
                    </div>
                    <div class="form-group">
                        <label id="categoriaLb">Categor&iacute;a</label><br/>
                        <select id="categorias"  runat="server">
                
                        </select>
                        <br />
                    </div>
                    <div class="form-group">
                        <input type="submit" />
                    </div>
                </div>
            </div>
       </div>
       <div class="col-md-4"></div>
    </div>
</asp:Content>

