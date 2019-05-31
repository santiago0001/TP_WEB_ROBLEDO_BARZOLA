<%@ Page Title="Premios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="WebApplication6.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                <asp:Image ID="Image1" runat="server" ImageAlign="Baseline" Height="175px" Width="230px" /><br />
                <asp:Button ID="Button4" runat="server" Text="Quiero este" OnClick="Button1_Click" CssClass="btn btn-primary btn-lg" Style="margin: 10px" />
            </div>
            <div class="col-sm-4">
                <asp:Image ID="Image2" runat="server" Height="175px" Width="230px" /><br />
                <asp:Button ID="Button5" runat="server" Text="Quiero este" OnClick="Button2_Click" CssClass="btn btn-primary btn-lg" Style="margin: 10px" />
            </div>
            <div class="col-sm-4">
                <asp:Image ID="Image3" runat="server" Height="175px" Width="230px" /><br />
                <asp:Button ID="Button6" runat="server" Text="Quiero este" OnClick="Button3_Click" CssClass="btn btn-primary btn-lg" Style="margin: 10px" />
            </div>
        </div>
    </div>
</asp:Content>

