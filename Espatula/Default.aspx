﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Espatula._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="jumbotron">
        <h1>La Espatula</h1>
        <p class="lead">La Espatula es una p&aacute;gina especializada en recetas de cocina, en espa&ntilde;ol, en la cual los usuarios pueden compartir sus recetas, y buscar su receta 
        favorita, para toda ocasi&oacute;n.</p>
    
        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="http://www.casadelcamba.com/admin/uploads/bienvenidos4%20(1).JPG" alt="empanadas">
                </div>

                <div class="item">
                    <img src="http://www.cocinillas.es/wp-content/uploads/2015/03/recetas-san-patricio-3.jpg" alt="okonomiyaki">
                </div>

                <div class="item">
                    <img src="http://cocina.linio.com.co/wp-content/uploads/2013/09/huevos-rellenos.jpg" alt="champinones">
                </div>

                <div class="item">
                    <img src="http://papilasypupilas.com/wp-content/uploads/2013/11/tiramisu-1024x500.jpg" alt="chalupa">
                </div>
            </div>

            <!-- controles izquierda y derecha -->
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>

    
    <!--http://www.quericavida.com/recetas-y-cocina/#-->

    <div class="row">
        <div class="col-md-4">
       
            <div class="thumbnail">
                <div class="caption">
                    <h4>Empanadas de Jamón y Queso</h4>
                
                </div>
                <img src="http://s3.amazonaws.com/gmi-digital-library/226e0d9f-b30f-4063-a321-1309d200faf7.jpg" alt="..." class="img-responsive">
            </div>
        </div>
        <div class="col-md-4">
        
                <div class="thumbnail">
                    <a href="Ver.aspx?id=2">
                        <div class="caption">

                            <h4>Parfait de Ricotta, Mango y Lima</h4>

                        </div>
                    </a>
                        <img src="http://s3.amazonaws.com/gmi-digital-library/a316d314-8466-4c4a-8f09-fa47e62fd496.jpg" alt="..." class="img-responsive">
                
                </div>
        
        </div>
        <div class="col-md-4">
            <div class="thumbnail">
                <div class="caption">
                    <h4>Tallarines Caseros con Salsa Bolognesa</h4>
                
                </div>
                <img src="http://s3.amazonaws.com/gmi-digital-library/d07ebdd5-0cdf-4cb8-826b-f3639ad024a9.jpg" alt="..." class="img-responsive">
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
