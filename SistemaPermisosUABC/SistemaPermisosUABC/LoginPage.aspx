<%@ Page Title="" Language="C#" MasterPageFile="~/MP_PrincipalSinSesion.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SistemaPermisosUABC.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="header1">
    <a href="default.aspx">VOLVER</a> 
</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="ContentPlaceHolder1">

    <div class ="form">

         <center>
            <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="images/usuario.png" />
        
             <br />
             <h3>Iniciar sesión</h3>
        <asp:TextBox ID="txtCorreoFacultativo" runat="server" TextMode="Email" placeholder="Correo facultativo"></asp:TextBox>
        <br />
        <div class="field-wrap">
            <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
        </div>
             <br />
        <asp:Panel ID="pnlResultadoSolicitud" runat="server" Visible="false" Height="57px">
            <center>
                <asp:Label ID="lblResultadoSolicitud" runat="server" ForeColor="Red" Text="RESULTADO DE SOLICITUD"></asp:Label>
            </center>
            <br />
            <br />
        </asp:Panel>
        <asp:Button ID="btnEntrar" runat="server" Text="ENTRAR" OnClick="btnEntrar_Click"  />

             </center>

    </div>

</asp:Content>


