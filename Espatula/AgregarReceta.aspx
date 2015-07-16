<%@ Page Title="Agregar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarReceta.aspx.cs" Inherits="Espatula.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <br />
    <br />
    <br />  
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
               <div id="form-box">
                     <div class="panel panel-info">
                        <div class="panel-heading">
                            <h1>Registre su receta aqu&iacute;</h1>
                            <div class="form-group">
        
                                <label id="nombreRecetaLb">Nombre de la receta</label><br/>
                                <input type="text" size="40" id="nombreReceta" runat="server"/><br/>
                            </div>
                            <div class="form-group">
                                <label id="instruccionesLb">Instrucciones de la receta</label><br/>
                                <textarea name="instruccion" cols="40" rows="6" id="instrucciones" runat="server"></textarea><br />
                            </div>
                            <div class="form-group">
                                <label id="imagenLb">imagen</label><br/>
                                <input type="url" size="40" id="imagen" title="Link de la imagen que quiere subir" runat="server" /><br/>
                            </div>
                            <div class="form-group">   
                                <label id="tipsLb">Tips</label><br/>
                                <input type="text" size="40" id="tips"  title="Consejos para la preparaci&oacute;n" runat="server" /><br/>
                            </div>
                            <div class="form-group">
                                <label id="categoriaLb">Categor&iacute;a</label><br/>
                                <select id="categorias"  runat="server">
                
                                </select>
                                <br />
                            </div>
                            <div class="form-group">
                                <input type="submit" runat="server" onClick="submitMethod"/>
                            </div>
                        </div>
                    </div>
                </div>
           </div>
           <div class="col-md-3"></div>
        </div>
</asp:Content>

