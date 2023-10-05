<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="miPerfil.aspx.cs" Inherits="presentacion.miPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="estilos-miPerfil.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-3"></div>
        <div class="col-6">
            <div class="conetenedor-general">
                <div class="head">
                    <h1>Información básica</h1>
                    <p id="parrafo">Es posible que otros usuarios puedan ver parte de la información al usar los servicios de Google. <a href="#">Más información</a></p>
                </div>
                <div class="caja" id="imagen-perfil">
                    <p>Imagen de perfil</p>
                    <input type="file" name="name" class="form-control" id="txtFile" runat="server" />
                    <asp:Image ImageUrl="~/imagenes/Chanchito.jpg" alt="" ID="imgPerfil" CssClass="img-fluid mb-3" runat="server" Style="width: 60px; border-radius: 50%;" />
                </div>
                <div class="caja">
                    <p>Nombre</p>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtNombre" />
                </div>
                <div class="caja">
                    <p>Apellido</p>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtApellido" />
                </div>
                <div class="caja" id="fecha-nacimiento">
                    <p>Fecha de nacimiento</p>
                    <asp:TextBox runat="server" CssClass="form-control" i="txtFechaNacimiento"/>
                </div>
            </div>

            <div class="conetenedor-general" id="contenedor-2">
                <div class="head">
                    <h1>Información de contacto</h1>
                </div>
                <div class="caja">
                    <p>Email</p>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" ReadOnly="true" />
                </div>
                <div class="caja" id="contraseña">
                    <p>Contraseña</p>
                    <asp:TextBox runat="server" CssClass="form-control" id="txtContraseña"/>
                </div>
            </div>

            <div class="botones">
                <asp:Button Text="Guardar" CssClass="btn btn-primary" runat="server" id="btnGuardar" OnClick="btnGuardar_Click"/>
                <asp:Button Text="Eliminar" CssClass="btn btn-danger" runat="server" />
            </div>
        </div>
        <div class="col-3"></div>
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
