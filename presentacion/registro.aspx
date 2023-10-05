<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="presentacion.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
    <link href="estilos-registro.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="row">
                    <div class="col-2"></div>
                    <div class="col-8">
                        <div class="contenedor-registro">
                            <div class="seccion1">
                                <div class="head">
                                    <div class="logo">
                                        <img src="imagenes/Chanchito.jpg" style="width: 40px; border-radius: 50%;" />
                                    </div>
                                    <div class="texto">
                                        <h1 class="titulo">Crea tu cuenta de tu super tienda</h1>
                                        <p>Datos personales</p>
                                    </div>
                                    <div class="formulario">
                                        <div class="txtBox">
                                            <asp:TextBox runat="server" CssClass="form-control nombre" placeholder="Nombre" ID="txtNombre" />
                                            <asp:TextBox runat="server" CssClass="form-control nombre" placeholder="Apellido" id="txtApellido"/>
                                            <asp:TextBox runat="server" CssClass="form-control email" placeholder="Email" ID="txtEmail" />
                                            <p>Deberás confirmar que este correo electrónico es tuyo.</p>
                                            <asp:TextBox runat="server" CssClass="form-control contraseña" placeholder="Contraseña" ID="txtContraseña" />
                                            <asp:TextBox runat="server" CssClass="form-control contraseña" placeholder="Confirmación" id="txtConfirmacionContraseña"/>
                                            <p>Usa 8 o más caracteres con una combinación de letras, números y símbolos</p>
                                        </div>
                                    </div>
                                    <asp:CheckBox Text="Mostrar contraseña" CssClass="form-check" runat="server" />
                                    <div class="acceder">
                                        <a href="#">Acceder a tu cuenta en su lugar</a>
                                        <asp:Button Text="Crear cuenta" runat="server" CssClass="btn btn-primary" ID="btnCrearCuenta" OnClick="btnCrearCuenta_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="seccion2">
                                <div class="imagen">
                                    <img src="imagenes/undraw_secure_login_pdn4 (1).svg" alt="Alternate Text" width="100%" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-2"></div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>
