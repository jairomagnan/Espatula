﻿<%@ Page Title="Ver" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ver.aspx.cs" Inherits="Espatula.WebForm1" %>

<asp:Content id="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Puré</h1>
        <asp:Label id="myLabel" runat="server" />

        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        
    </div>
</asp:Content>
