<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="error.aspx.cs" Inherits="presentacion.error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="error-estilos.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-3"></div>
            <div class="col-6">
                <div class="contenedor-general">
                    <div class="imagen">
                        <img src="imagenes/undraw_cancel_re_pkdm.svg" alt="Alternate Text" class="img-fluid" />
                    </div>
                    <div class="texto">
                        <p>Al parecer algo salio mal..</p>
                    </div>
                    <div class="info-error">
                        <asp:TextBox runat="server" CssClass="form-control" TextMode="MultiLine" ID="txtError" />
                    </div>
                    <div class="boton">
                        <a class="btn btn-primary" href="Default.aspx"> Salir de aquí</a>
                    </div>
                </div>
            </div>
            <div class="col-3"></div>
        </div>
    </div>
</asp:Content>
