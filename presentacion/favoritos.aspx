<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="favoritos.aspx.cs" Inherits="presentacion.favoritos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos-favoritos.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/2e6a15d040.js" crossorigin="anonymous"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--    <div class="contenedor-general">
        <div class="head">
            <asp:CheckBox Text="" CssClass="mb-3" runat="server" />
            <p>Eliminar favoritos seleccionados</p>
        </div>--%>

    <div class="container">
        <div class="row">

            <div class="col-12">

                <%if (Session["articuloFav"] == null)
                    {
                        Response.Redirect("default.aspx");
                    }%>

                <%else if (((List<Dominio.Articulo>)Session["articuloFav"]).Count == 0)
                    { %>
                <div class="contenedor-favoritos">
                    <div class="titulo">
                        <h1>Favoritos</h1>
                    </div>
                    <div class="cabezeraFavoritos">
                        <div class="seccion1">
                            <asp:CheckBox Text="" runat="server" />
                            <p>Eliminar favoritos seleccionados</p>
                        </div>
                        <div class="seccion2">
                            <p>Favoritos...</p>
                        </div>
                    </div>
                    <div class="cuerpoFavoritos">
                        <i class="fa-solid fa-image"></i>
                        <p>Nada por acá...</p>
                        <p>Aún no tenés productos en favoritos</p>
                    </div>
                </div>
                <% } %>

                <%else
                    { %>
                <div class="row row-cols-1 row-cols-md-3 g-4">
                    <asp:Repeater ID="repetidorFavoritos" runat="server">
                        <ItemTemplate>
                            <div class="col">
                                <div class="card">
                                    <img src="<%#Eval("ImagenUrl") %>" class="card-img-top" alt="..." style="width: 100px;">
                                    <div class="card-body">
                                        <h5 class="card-title"><%#Eval("Nombre") %></h5>
                                        <p class="card-text"><%#Eval("Descripcion") %></p>
                                        <asp:Button Text="Ver" CssClass="btn btn-primary" ID="btnVer" OnClick="btnVer_Click" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloId" runat="server" />
                                        <asp:Button Text="Eliminar favoritos" CssClass="btn btn-primary" ID="btnFavoritos" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloId" runat="server" OnClick="btnFavoritos_Click" />
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <% }%>
            </div>

        </div>
    </div>

    <%--  </div>--%>
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
