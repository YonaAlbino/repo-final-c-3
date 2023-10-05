<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="formulario.aspx.cs" Inherits="presentacion.formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="estilos-formulario.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <div class="container-fluid">
        <div class="row">
            <div class="col-12">
                <img src="imagenes/tienda-noche.jpg" alt="Alternate Text" class="img-fluid imagen-hero" />
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row">

            <div class="col-10">
                <div class="titulo">
                    Agregar un nuevo articulo
                </div>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="contenedor-general">
                            <div class="contenedor-info">
                                <div class="caja-info">
                                    <p>Nombre</p>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtNombre" />
                                </div>
                                <div class="caja-info-doble">
                                    <div class="doble">
                                        <p>Precio</p>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtPrecio" />
                                    </div>
                                    <div class="doble">
                                        <p>Código</p>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtCodigo" />
                                    </div>
                                </div>
                                <div class="caja-info-doble">
                                    <div class="doble">
                                        <p>Categoría</p>
                                        <asp:DropDownList runat="server" CssClass="form-select" ID="dropCategoria" />
                                    </div>
                                    <div class="doble">
                                        <p>Marca</p>
                                        <asp:DropDownList runat="server" CssClass="form-select" ID="dropMarca" />
                                    </div>
                                </div>
                                <div class="caja-info">
                                    <p>Descripción</p>
                                    <asp:TextBox runat="server" TextMode="MultiLine" Height="100px" Style="max-height: 150px;" CssClass="form-control" ID="txtDescripcion" />
                                </div>
                                <div class="boton">
                                    <asp:Button Text="Agregar" CssClass="btn btn-primary" runat="server" ID="btnAceptar" OnClick="btnAceptar_Click" />
                                    <asp:Button Text="Cancelar" CssClass="btn btn-primary" runat="server" ID="btnCancelar" OnClick="btnCancelar_Click" />
                                    <asp:Button Text="Eliminar" CssClass="btn btn-danger" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" />
                                </div>
                            </div>
                            <div class="contenedor-imagen">
                                <div class="contenido-texto">
                                    <p>Imagen</p>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtImagen" OnTextChanged="txtImagen_TextChanged" AutoPostBack="true" />
                                </div>
                                <div class="imagen">
                                    <asp:Image ImageUrl="imagenes/chanchito.jpg" runat="server" alt="Alternate Text" class="img-fluid" ID="imagenProducto" />
                                </div>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
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
