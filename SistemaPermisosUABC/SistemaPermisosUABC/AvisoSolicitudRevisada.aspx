<%@ Page Title="" Language="C#" MasterPageFile="~/MP_PrincipalSinSesion.Master" AutoEventWireup="true" CodeBehind="AvisoSolicitudRevisada.aspx.cs" Inherits="SistemaPermisosUABC.AvisoSolicitudRechazada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class ="form">

         <center>
            <asp:Image ID="Image1" runat="server" Height="153px" ImageUrl="images/hecho.png" Width="152px" />
        
             <br />
             <h2>EVALUACIÓN DE SOLICITUD TERMINADA</h2>
        <div class="field-wrap">
            El tiempo de evaluación para la solicitud que intenta entrar a terminado porque ya ha sido revisado por todos los responsables involucrados<br />
        </div>
        <br />
        <asp:Button ID="btnEntrar" runat="server" Text="DE ACUERDO"  />

             </center>

    </div>

</asp:Content>
