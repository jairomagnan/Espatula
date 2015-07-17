<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerTodas.aspx.cs" Inherits="Espatula.VerTodas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class ="jumbotron">

         <span class="lead">
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
         </span>


         <div class="row">
        <div class="col-md-4">
       
            <div class="thumbnail">
                <a href="Ver.aspx?id=2">
                    <div class="caption">
                        <h4>Empanadas de Jamón y Queso</h4>
                
                    </div>
                </a>
                <img src="http://s3.amazonaws.com/gmi-digital-library/226e0d9f-b30f-4063-a321-1309d200faf7.jpg" alt="..." class="img-responsive">
            </div>
        </div>
        <div class="col-md-4">
        
                <div class="thumbnail">
                    <a href="Ver.aspx?id=3">
                        <div class="caption">

                            <h4>Parfait de Ricotta, Mango y Lima</h4>

                        </div>
                    </a>
                        <img src="http://s3.amazonaws.com/gmi-digital-library/a316d314-8466-4c4a-8f09-fa47e62fd496.jpg" alt="..." class="img-responsive">
                
                </div>
        
        </div>
        <div class="col-md-4">
            <div class="thumbnail">
                <a href="Ver.aspx?id=4">
                    <div class="caption">
                        <h4>Tallarines Caseros con Salsa Bolognesa</h4>
                    </div>
                </a>
                <img src="http://s3.amazonaws.com/gmi-digital-library/d07ebdd5-0cdf-4cb8-826b-f3639ad024a9.jpg" alt="..." class="img-responsive">
            </div>
        </div>
    </div>



    </div>

    <script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
    <script src="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.1/js/bootstrap.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("[rel='tooltip']").tooltip();

            $('.thumbnail').hover(
                function () {
                    $(this).find('.caption').slideDown(250); //.fadeIn(250)
                },
                function () {
                    $(this).find('.caption').slideUp(250); //.fadeOut(205)
                }
            );
        });


        $(document).ready(function () {
            $(".dropdown-toggle").dropdown();
        });
        </script>




</asp:Content>
