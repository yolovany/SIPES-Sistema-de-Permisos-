<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/MP_PrincipalSinSesion.Master" AutoEventWireup="true" CodeBehind="LoginPageResponsable.aspx.cs" Inherits="SistemaPermisosUABC.LoginPageResponsable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
