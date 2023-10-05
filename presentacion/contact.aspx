<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="presentacion.contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="estilo-contact.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero">
        <h1>¿En qué podemos ayudarte?</h1>
        <img src="imagenes/imgHeroContact.png" alt="Alternate Text" class="img-fluid" />
    </div>

    <div class="row">
        <div class="col-2"></div>
        <div class="col-5">
            <div class="contenedor-formulario">
                <div class="titulo">
                    <h1>¿Sobre qué temas te gustaría conversar?</h1>
                </div>
                <div class="circulos">
                    <a href="#">pepe</a>
                    <a href="#">pepe</a>
                    <a href="#">pepe</a>
                    <a href="#">pepe</a>
                </div>
                <div class="campoInfo">
                    <p>Correo electrónico</p>
                    <asp:TextBox runat="server" CssClass="form-control" placeholder="Correo electrónico" ID="txtEmail" />
                </div>
                <div class="campoInfo-doble">
                    <div class="caja-datos">
                        <p>Nombre</p>
                        <asp:TextBox runat="server" CssClass="form-control" placeholder="Nombre" id="txtNombre"/>
                    </div>
                    <div class="caja-datos">
                        <p>Apellido</p>
                        <asp:TextBox runat="server" CssClass="form-control" placeholder="Apellido" id="txtApellido"/>
                    </div>
                </div>
                <div class="campoInfo">
                    <p>Asunto</p>
                    <asp:TextBox runat="server" CssClass="form-control" placeholder="Asunto" ID="txtAsunto" />
                </div>
                <div class="campoInfo-doble">
                    <div class="caja-datos">
                        <p>Provincia</p>
                        <asp:DropDownList runat="server" CssClass="form-control" id="dropProvincia"/>
                    </div>
                    <div class="caja-datos">
                        <p>Ciudad</p>
                        <asp:DropDownList runat="server" CssClass="form-control" id="dropCiudad"/>
                    </div>
                </div>
                <div class="campoInfo">
                    <p>Mensaje</p>
                    <asp:TextBox TextMode="MultiLine" runat="server" CssClass="form-control" placeholder="Escriba su mensaje" style="max-height:200px;" ID="txtMensaje" />
                </div>
                <div class="boton-enviar">
                    <asp:Button Text="Enviar" CssClass="btn btn-primary" runat="server" ID="btnEnviar" OnClick="btnEnviar_Click" />
                </div>
            </div>
        </div>
        <div class="col-3">
            <div class="contenedor-tarjetas">
                <div class="titulo">
                    <p>Más información</p>
                </div>
                <div class="tarjeta">
                    <div class="imagen">
                        <img src="imagenes/Chanchito.jpg" class="img-fluid" alt="Alternate Text" />
                    </div>
                    <div class="texto">
                        <p class="primero">Nuestras oficinas</p>
                        <a href="#">
                            <p class="segundo">Ver más</p>
                        </a>
                    </div>
                </div>
                <div class="tarjeta">
                    <div class="imagen">
                        <img src="imagenes/Chanchito.jpg" class="img-fluid" alt="Alternate Text" />
                    </div>
                    <div class="texto">
                        <p class="primero">Carreras</p>
                        <a href="#">
                            <p class="segundo">Ver más</p>
                        </a>
                    </div>
                </div>
                <div class="tarjeta">
                    <div class="imagen">
                        <img src="imagenes/Chanchito.jpg" class="img-fluid" alt="Alternate Text" />
                    </div>
                    <div class="texto">
                        <p class="primero">Sala de prensa</p>
                        <a href="#">
                            <p class="segundo">Ver más</p>
                        </a>
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
