<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="administracion.aspx.cs" Inherits="presentacion.administracion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administración</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
    <script src="https://kit.fontawesome.com/2e6a15d040.js" crossorigin="anonymous"></script>
    <link href="estilos-administracion.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" />
        <div class="head">
            <div class="foto-head">
                <a href="default.aspx">
                    <img src="imagenes/Chanchito.jpg" style="width: 60px; border-radius: 50%;" /></a>
            </div>
        </div>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <div class="barraBusqueda">
                                <div class="filtroRapido">
                                    <asp:TextBox runat="server" CssClass="form-control" placeholder="Buscar" ID="txtFiltroRapido" OnTextChanged="txtFiltroRapido_TextChanged" AutoPostBack="true" />
                                    <i class="fa-solid fa-magnifying-glass"></i>
                                </div>
                                <div class="checkFiltroAvanzado">
                                    <asp:CheckBox Text="Filtro avanzado" runat="server" ID="checkFiltroAvanzado"
                                        AutoPostBack="true" OnCheckedChanged="checkFiltroAvanzado_CheckedChanged" />
                                </div>
                            </div>
                            <%if(checkFiltroAvanzado.Checked) { %>
                            <div class="contenedorFiltroAvanzado">
                                <div class="filtros">
                                    <div class="camposBusqueda">
                                        <p>Campo</p>
                                        <asp:DropDownList runat="server" CssClass="form-control" id="dropCampo" 
                                            OnSelectedIndexChanged="dropCampo_SelectedIndexChanged" AutoPostBack="true">
                                            <asp:ListItem Text="Nombre" />
                                            <asp:ListItem Text="Categoria" />
                                            <asp:ListItem Text="Marca" />
                                            <asp:ListItem Text="Precio" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="camposBusqueda">
                                        <p>Criterio</p>
                                        <asp:DropDownList runat="server" CssClass="form-control" id="dropCriterio"/>
                                    </div>
                                    <div class="camposBusqueda">
                                        <p>Filtro</p>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtFiltroAvanzado" />
                                    </div>
                                    <div class="camposBusqueda">
                                        <p>Estado</p>
                                        <asp:DropDownList runat="server" ID="dropEstado" CssClass="form-control">
                                            <asp:ListItem Text="Todos" />
                                            <asp:ListItem Text="Activo" />
                                            <asp:ListItem Text="Inactivo" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="boton">
                                    <asp:Button Text="Buscar" CssClass="btn btn-primary" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" />
                                </div>
                            </div>
                           <% }%>
                            <div class="contenedor-general">
                                <div class="grilla">
                                    <asp:GridView ID="dgvAticulos" DataKeyNames="Id" OnSelectedIndexChanged="dgvAticulos_SelectedIndexChanged" CssClass="table table-striped" runat="server" AutoGenerateColumns="false"
                                        AllowPaging="true" PageSize="20" OnPageIndexChanging="dgvAticulos_PageIndexChanging">
                                        <Columns>
                                            <%--<asp:BoundField HeaderText="id" DataField="Id" />--%>
                                            <asp:BoundField HeaderText="Código" DataField="Codigo" />
                                            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                                            <asp:BoundField HeaderText="Descripción" DataField="Descripcion" />
                                            <asp:BoundField HeaderText="Precio" DataField="Precio" />
                                            <asp:BoundField HeaderText="Marca" DataField="MarcaArticulo.Descripcion" />
                                            <asp:BoundField HeaderText="Categoría" DataField="CategoriaArticulo.Descripcion" />
                                            <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Acción" />
                                        </Columns>
                                    </asp:GridView>
                                </div>
                                <div class="botones">
                                    <asp:Button Text="Agregar" runat="server" CssClass="btn btn-primary" ID="btnAgregar" OnClick="btnAgregar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>


    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>
