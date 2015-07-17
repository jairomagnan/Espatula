<%@ Page Title="Agregar Ingrediente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ver.aspx.cs" Inherits="Espatula.Recetas.ver" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
    
    <div class="container-fluid">
        <div class="jumbotron">


            
            
            <div class="row" style="float:left">
                <asp:TextBox ID="txBuscar" runat="server" placeholder="Buscar..."></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar"  />

            </div>
            <div class="row" >
                <asp:Button ID="btnLetra" runat="server" CssClass="btn btn-link" Text="a" OnClick="btnLetra_Click" />
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-link" Text="b" OnClick="btnLetra_Click" />
                <asp:Button ID="Button2" runat="server" CssClass="btn btn-link" Text="c" OnClick="btnLetra_Click" />
                <asp:Button ID="Button3" runat="server" CssClass="btn btn-link" Text="d" OnClick="btnLetra_Click" />
                <asp:Button ID="Button4" runat="server" CssClass="btn btn-link" Text="e" OnClick="btnLetra_Click" />
                <asp:Button ID="Button5" runat="server" CssClass="btn btn-link" Text="f" OnClick="btnLetra_Click" />
                <asp:Button ID="Button6" runat="server" CssClass="btn btn-link" Text="g" OnClick="btnLetra_Click" />
                <asp:Button ID="Button7" runat="server" CssClass="btn btn-link" Text="h" OnClick="btnLetra_Click" />
                <asp:Button ID="Button8" runat="server" CssClass="btn btn-link" Text="i" OnClick="btnLetra_Click" />
                <asp:Button ID="Button9" runat="server" CssClass="btn btn-link" Text="j" OnClick="btnLetra_Click" />
                <asp:Button ID="Button10" runat="server" CssClass="btn btn-link" Text="k" OnClick="btnLetra_Click" />
                <asp:Button ID="Button11" runat="server" CssClass="btn btn-link" Text="l" OnClick="btnLetra_Click" />
                <asp:Button ID="Button12" runat="server" CssClass="btn btn-link" Text="m" OnClick="btnLetra_Click" />
                <asp:Button ID="Button13" runat="server" CssClass="btn btn-link" Text="n" OnClick="btnLetra_Click" />
                <asp:Button ID="Button14" runat="server" CssClass="btn btn-link" Text="o" OnClick="btnLetra_Click" />
                <asp:Button ID="Button15" runat="server" CssClass="btn btn-link" Text="p" OnClick="btnLetra_Click" />
                <asp:Button ID="Button16" runat="server" CssClass="btn btn-link" Text="q" OnClick="btnLetra_Click" />
                <asp:Button ID="Button17" runat="server" CssClass="btn btn-link" Text="r" OnClick="btnLetra_Click" />
                <asp:Button ID="Button18" runat="server" CssClass="btn btn-link" Text="s" OnClick="btnLetra_Click" />
                <asp:Button ID="Button19" runat="server" CssClass="btn btn-link" Text="t" OnClick="btnLetra_Click" />
                <asp:Button ID="Button20" runat="server" CssClass="btn btn-link" Text="u" OnClick="btnLetra_Click" />
                <asp:Button ID="Button21" runat="server" CssClass="btn btn-link" Text="v" OnClick="btnLetra_Click" />
                <asp:Button ID="Button22" runat="server" CssClass="btn btn-link" Text="w" OnClick="btnLetra_Click" />
                <asp:Button ID="Button23" runat="server" CssClass="btn btn-link" Text="x" OnClick="btnLetra_Click" />
                <asp:Button ID="Button24" runat="server" CssClass="btn btn-link" Text="y" OnClick="btnLetra_Click" />
                <asp:Button ID="Button25" runat="server" CssClass="btn btn-link" Text="z" OnClick="btnLetra_Click" />


            </div>
               
            <div class="row">

                <asp:Table id="tblBuscar" runat="server">

                </asp:Table>
            </div>

        </div>
        
    </div>
    
</asp:Content>
