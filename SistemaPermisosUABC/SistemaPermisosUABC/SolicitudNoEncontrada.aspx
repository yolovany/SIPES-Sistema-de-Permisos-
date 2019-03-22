<%@ Page Title="" Language="C#" MasterPageFile="~/MP_PrincipalConSesion.Master" AutoEventWireup="true" CodeBehind="SolicitudNoEncontrada.aspx.cs" Inherits="SistemaPermisosUABC.SolicitudNoEncontrada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header5" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class ="form">

         <center>
            <asp:Image ID="Image1" runat="server" Height="153px" ImageUrl="images/hecho.png" Width="152px" />
        
             <br />
             <h2>SOLICITUD NO ENCONTRADA</h2>
        <div class="field-wrap">
            La solicitud con el número de folio indicado no se encontró en nuestra base de datos. Por favor inserte algún número de folio de la sección de solicitudes pendientes.<br />
        </div>
        <br />
        <asp:Button ID="btnVale" runat="server" Text="DE ACUERDO" OnClick="btnVale_Click"  />

             </center>

    </div>

</asp:Content>
