<%@ Page Title="" Language="C#" MasterPageFile="~/MP_PrincipalConSesion.Master" AutoEventWireup="true" CodeBehind="AvisoSolicitudEnviada.aspx.cs" Inherits="SistemaPermisosUABC.AvisoSolicitudEnviada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header5" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class ="form">

         <center>
            <asp:Image ID="Image1" runat="server" Height="153px" ImageUrl="~/images/green.png" Width="152px" />
        
             <br />
             <h2>SOLICITUD ENVIADA</h2>
             <div class="field-wrap">
                 Ahora sólo queda esperar. La solicitud será revisada por los responsables involucrados. Los resultados serán notificados y publicados tanto en el portal como vía correo electrónico.<br />
        </div>
        <br />
        <asp:Button ID="btnEntrar" runat="server" Text="DE ACUERDO" OnClick="btnEntrar_Click"/>

             </center>

    </div>

</asp:Content>
