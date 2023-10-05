<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="presentacion._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="estilos-default.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/2e6a15d040.js" crossorigin="anonymous"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <div class="container">
        <div id="carouselExampleAutoplaying" class="carousel slide" data-bs-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="imagenes/c-d-x-PDX_a_82obo-unsplash.jpg" class="d -block w-100" alt="..." style="height: 300px;">
                </div>
                <div class="carousel-item">
                    <img src="imagenes/rachit-tank-2cFZ_FB08UM-unsplash.jpg" class="d-block w-100" alt="..." style="height: 300px;">
                </div>
                <div class="carousel-item">
                    <img src="imagenes/revolt-164_6wVEHfI-unsplash.jpg" class="d-block w-100" alt="..." style="height: 300px;">
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>

        <div class="contenedor-tipos-pago">
            <div class="caja-tipo-pago">
                <div class="contenido">
                    <div class="icono">
                        <i class="fa-solid fa-credit-card"></i>
                    </div>
                    <div class="texto">
                        <p>Tarjeta de crédito</p>
                        <a href="#">Ver promociones bancarias</a>
                    </div>

                </div>
            </div>
            <div class="caja-tipo-pago">
                <div class="contenido">
                    <div class="icono">
                        <i class="fa-solid fa-credit-card"></i>
                    </div>
                    <div class="texto">
                        <p>Tarjeta de débito</p>
                        <a href="#">Ver más</a>
                    </div>
                </div>
            </div>
            <div class="caja-tipo-pago">
                <div class="contenido">
                    <div class="icono">
                        <i class="fa-sharp fa-solid fa-hand-holding-dollar"></i>

                    </div>
                    <div class="texto">
                        <p>Cuotas sin tarjeta</p>
                        <a href="#">Conocé Mercado Crédito</a>
                    </div>
                </div>
            </div>
            <div class="caja-tipo-pago">
                <div class="contenido">
                    <div class="icono">
                        <i class="fa-sharp fa-solid fa-money-bills"></i>
                    </div>
                    <div class="texto">
                        <p>Efectivo</p>
                        <a href="#">Ver más</a>
                    </div>
                </div>
            </div>
            <div class="caja-tipo-pago" id="plus">
                <div class="contenido plus">
                    <div class="icono">
                        <i class="plus fa-sharp fa-solid fa-circle-plus"></i>
                    </div>
                </div>
            </div>
        </div>

        <asp:UpdatePanel runat="server">
            <ContentTemplate>

                <div class="cantidadArticulos">
                    <label>Cantidad de articulos visibles:</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCantidadArticulos" AutoPostBack="true" OnTextChanged="txtCantidadArticulos_TextChanged" />
                </div>

                <div class="row row-cols-1 row-cols-md-3 g-4">
                    <asp:Repeater ID="repetidor" runat="server">
                        <ItemTemplate>

                            <div class="col col-grilla">
                                <div class="card">
                                    <img src="<%#Eval("ImagenUrl") %>" class="card-img-top img-fluid" style="width: 80px;" alt="...">
                                    <div class="card-body">
                                        <h5 class="card-title"><%#Eval("Nombre") %></h5>
                                        <p class="card-text"><i class="fa-solid fa-dollar-sign"></i><%#Eval("Precio") %></p>
                                        <asp:Button Text="Ver" CssClass="btn btn-primary" runat="server" ID="btnVer" OnClick="btnVer_Click" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloId" Style="width: 80px;" />
                                        <asp:Button Text="Agregar a favoritos" CssClass="btn btn-primary" ID="btnFavoritos" OnClick="btnFavoritos_Click" runat="server" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloId" />
                                    </div>
                                </div>
                            </div>


                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>


        <div class="contenedorCategorias">
            <div class="titulo">
                <h1>Categorías populares</h1>
            </div>
            <div class="CajaCategorias">
                <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
                  <div class="caja">
                    <i class="fa-solid fa-car"></i>
                    <p>Auto, casa, jardin</p>
                </div>
            </div>
        </div>

    </div>


    <%--    <div class="container">
        <div class="row row-cols-1 row-cols-md-3 g-4">

            <%
                foreach (Dominio.Articulo item in ListaArticulos)
                {
            %>
            <div class="col">
                <div class="card">
                    <img src="<%:item.ImagenUrl %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                    </div>
                </div>
                <%} %>
            </div>
        </div>
    </div>--%>
</asp:Content>
