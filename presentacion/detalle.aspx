<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="detalle.aspx.cs" Inherits="presentacion.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="estilos-detalle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://kit.fontawesome.com/2e6a15d040.css" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/2e6a15d040.js" crossorigin="anonymous"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%if (articulo == null)
            Response.Redirect("default.aspx");%>


    <div class="row">
        <div class="col-2"></div>
        <div class="col-8">
            <div class="contenedor-general">
                <div class="contenedor-hijo" id="imagen">
                    <asp:Image ImageUrl="" ID="imagenDetalle" runat="server" />
                </div>
                <div class="contenedor-hijo">
                    <div class="titulo">
                        <h1><%:articulo.Nombre %></h1>
                        <h1 id="h1" runat="server"></h1>
                    </div>
                    <div class="precio">
                        <span><%:articulo.Precio %></span>
                        <a href="#">Ver los medios de pagos</a>
                    </div>
                    <div class="descripcion">
                        <p>Lo que debes saber sobre este elemento</p>
                        <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control ocularBorde" TextMode="MultiLine" />
                    </div>
                </div>
                <div class="contenedor-hijo" id="detalles-envio">
                    <div class="detalles-envio">
                        <p class="imagen-camion"><i class="fa-sharp fa-solid fa-truck"></i>llega tal dia</p>
                        <p>Vendido por <a href="#">Pepe</a></p>
                        <p style="font-weight: 500;">Stock disponile</p>
                        <div class="drop-item">
                            <p>Cantidad:</p>
                            <asp:DropDownList CssClass="dropdown-item" ID="dropStock" runat="server">
                            </asp:DropDownList>
                        </div>

                    </div>
                    <div class="detalle-compra">
                        <div class="botones">
                            <asp:Button runat="server" Text="Comprar ahora" CssClass="btn btn-primary" />
                            <asp:Button runat="server" Text="Agregar al carrito" CssClass="btn btn-primary" />
                        </div>
                        <div class="informacion">
                            <p><i class="fa-sharp fa-solid fa-rotate-left"></i><a href="#">Devolución gratis.</a> Tenés 30 días desde que lo recibís.</p>
                            <p><i class="fa-sharp fa-solid fa-shield-heart"></i><a href="#">Compra protegida.</a> recibí el producto que esperabas o te devolvemos tu dinero.</p>
                            <p><i class="fa-sharp fa-solid fa-trophy"></i><a href="#">Mercado puntos.</a> Sumás 930 puntos.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-2"></div>
    </div>

    <footer>
        <div class="contenedor-footer">
            <div class="caja">
                <p class="titulo">Acerca de</p>
                <p>
                    Somos una empresa familiar que busca brindar servicio a la comunidad.
                </p>
            </div>
            <div class="caja">
                <p class="titulo">Ayuda</p>
                <p><a href="#">Comrar</a></p>
                <p><a href="#">Vender</a></p>
            </div>
            <div class="caja">
                <p class="titulo">Redes sociales</p>
                <p><a href="#">Github</a></p>
                <p><a href="#">Facebook</a></p>
                <p><a href="#">Instagram</a></p>
            </div>
        </div>
    </footer>
</asp:Content>
