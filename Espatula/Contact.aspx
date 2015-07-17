<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Espatula.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
    
        <h2><%: Title %>.</h2>
        <h3>Contáctenos.</h3>
        <address>
            San José<br />
            Costa Rica<br />
            <abbr title="Phone">P:</abbr>
            8888-4545
        </address>

        <address>
            <strong>Soporte:</strong>   <a href="mailto:andony91@gmail.com">soporte@laespatula.com</a><br />
            <strong>Mercadeo:</strong> <a href="mailto:andony91@gmail.com">mercadeo@laespatula.com</a>
        </address>
    </div> 
</asp:Content>
