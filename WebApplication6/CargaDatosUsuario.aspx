<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaDatosUsuario.aspx.cs" Inherits="WebApplication6.CargaDatosUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <center>
      <asp:Label ID="LabelDatos" runat="server"  Text="Datos de usuario"  Font-Size="XX-Large" Font-Italic="True" Height="39px" Width="405px"></asp:Label>
    <br><br>
    </center>
    <asp:Label ID="Label7" runat="server" Text="ID del usuario:"></asp:Label>
    <asp:Label ID="IDlab" runat="server" Text="Label"></asp:Label>

    <div class="row">

        <div class="col-md-6">
            <div class="col-xs-8">
                <label for="ex1">Dni:</label>
                <asp:TextBox ID="txtDni" runat="server" Style="margin-left: 0" OnTextChanged="txtDni_TextChanged" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Confirmar DNI" CssClass="btn btn-primary btn-sm" />
            </div>
            <div class="col-xs-8">
                <label for="ex1">Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-xs-8">
                <label for="ex1">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox><br>
            </div>
            <div class="col-xs-8">
                <label for="ex1">Ciudad:</label>
                <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="col-md-6">
            <div class="col-xs-8">
                <label for="ex1">Apellido:</label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-xs-8">
                <label for="ex1">Direccion:</label>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-xs-6">
                <label for="ex1">CP:</label>
                <asp:TextBox ID="txtCP" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
    <asp:Button ID="Button1" runat="server" Text="Participar" OnClick="Button1_Click" CssClass="btn btn-primary btn-lg" Style="margin: 10px" />
</asp:Content>
