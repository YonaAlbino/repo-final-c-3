<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loguin.aspx.cs" Inherits="presentacion.loguin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Loguin</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
    <link href="estilo-loguin.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/2e6a15d040.js" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="Container">
                <div class="head">
                    <div class="foto-head">
                        <a href="default.aspx">
                            <img src="imagenes/Chanchito.jpg" style="width: 60px; border-radius: 50%;" /></a>
                    </div>
                </div>
                <div class="row">
                    <div class="col-3"></div>
                    <div class="col-6 contenedor-loguin">
                        <div class="caja-loguin">
                            <h1>Ingresá tu e‑mail, teléfono o usuario de tu Super tienda</h1>
                            <p>Reporta un problema</p>
                            <p>
                                <a class="borde" href="#"><i class="fa-sharp fa-solid fa-mobile-screen"></i>Robo o pérdida de teléfono <i class="fa-sharp fa-solid fa-angle-right"></i></a>
                            </p>
                            <p>
                                <a class="" href="#"><i class="fa-sharp fa-solid fa-user"></i>Robo de cuenta</a>
                            </p>
                            <a href="#">Necestio ayuda con otros temas</a>
                        </div>
                        <div class="caja-loguin1">
                            <label class="form-label">Ingrese su usuario</label>
                            <asp:TextBox CssClass="form-control" runat="server" id="txtUsuario"/>
                            <label class="form-label">Ingrese su Contraseña</label>
                            <asp:TextBox CssClass="form-control" runat="server" id="txtContraseña"/>
                            <asp:Button Text="Aceptar" CssClass="botones boton1" runat="server" id="btnAceptar" OnClick="btnAceptar_Click"/>
                            <a href="#">Crear cuenta</a>
                        </div>
                    </div>
                    <div class="col-3"></div>
                </div>
            </div>

            <div class="footer">
                <div class="contenedor-footer">
                    <div class="seccion1">
                        <a href="#">Cómo cuidamos tu privacidad</a>
                        <p>Copyright © 1999-2023 SuperTienda S.R.L.</p>
                    </div>
                    <div class="seccion2">
                        <p>Protegido por CAPTCHA</p>
                        <a href="#">Privacidad</a>
                        <a href="#">Condiciones</a>
                    </div>
                </div>
            </div>
        </div>

    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>
