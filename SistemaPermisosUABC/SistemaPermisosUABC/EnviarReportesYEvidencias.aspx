<%@ Page Title="" Language="C#" MasterPageFile="~/MP_PrincipalConSesion.Master" AutoEventWireup="true" CodeBehind="EnviarReportesYEvidencias.aspx.cs" Inherits="SistemaPermisosUABC.EnviarReportesYEvidencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header5" runat="server">
     <a href="PrincipalConSesion.aspx">VOLVER</a> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="two">
        <div class="inner">
            <header class="major">
                <h2>Massa libero</h2>
            </header>
            <span class="image main"><img src="images/banner3.jpg" alt="" /></span><p>
        </div>
    </section>
 
    <center>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Panel ID="Panel1" runat="server">
            
        </asp:Panel>
        <br />
    <asp:Button ID="btnEnviar" runat="server" Text="Button" OnClick="btnEnviar_Click" />
    </center>
    <br />
    
</asp:Content>
