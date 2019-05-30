<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        
            <h2>&nbsp;</h2>
<h2>&nbsp;</h2>
<h2> 
    <asp:Image ID="Image1" runat="server" ImageUrl="https://www.lotenal.gob.mx/Comercial/img/sespecial.png" Height="179px" />
</h2>
<h2>
   
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" ForeColor="Maroon" Text="Ingrese codigo de sorteo"></asp:Label>
           </h2>
        

<h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" Width="339px"></asp:TextBox>
</h2>
<h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Participar" OnClick="Button1_Click" />            

    
</h2>
<h2>&nbsp;</h2>
            

</asp:Content>
