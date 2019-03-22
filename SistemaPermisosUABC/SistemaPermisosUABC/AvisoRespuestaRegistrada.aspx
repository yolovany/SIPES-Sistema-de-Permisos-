<%@ Page Title="" Language="C#" MasterPageFile="~/MP_PrincipalConSesion.Master" AutoEventWireup="true" CodeBehind="AvisoRespuestaRegistrada.aspx.cs" Inherits="SistemaPermisosUABC.AvisoRespuestaRegistrada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header5" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class ="form">

         <center>
            <asp:Image ID="Image1" runat="server" Height="165px" ImageUrl="~/images/green.png" Width="167px" />
        
             <br />
             <h2>GRACIAS POR SU REVISIÓN</h2>
             <div class="field-wrap">
                 La solicitud continuará abierta mientras los demás responsables no terminen e revisarla. En caso de que cambie de parecer puede modificar su respuesta entrando nuevamente al enlace adjunto en el correo enviado por SIPES para esta solicitud.<br />
        </div>
        <br />
        <asp:Button ID="btnDeAcuerdo" runat="server" Text="DE ACUERDO" OnClick="btnDeAcuerdo_Click"  />

             </center>

    </div>

</asp:Content>
