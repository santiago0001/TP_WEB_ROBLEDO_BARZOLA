<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container well">
        <div class="text-center">
            <div>
                <h2>
                    <asp:Image ID="Image1" runat="server" ImageUrl="https://www.lotenal.gob.mx/Comercial/img/sespecial.png" Height="179px" />
                </h2>
            </div>
            <div class="form-group">
                <div>
                    <asp:Label ID="Label1" runat="server" ForeColor="Maroon" Text="Ingrese codigo de sorteo:" CssClass="control-label"></asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div>
                    <center>
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" CssClass="form-control"></asp:TextBox>
                     </center>
                </div>
            </div>
            <div>
                <asp:Button CssClass="btn btn-primary btn-lg" ID="Button1" runat="server" Text="Participar" OnClick="Button1_Click" Style="margin: 10px" />
            </div>
        </div>
    </div>
</asp:Content>














