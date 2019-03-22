<%@ Page enableEventValidation="false" Title="" Language="C#" MasterPageFile="~/MP_PrincipalConSesion.Master" AutoEventWireup="true" CodeBehind="AvisoRespuestaNegadaRegistrada.aspx.cs" Inherits="SistemaPermisosUABC.AvisoRespuestaNegadaRegistrada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header5" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class ="form">

         <center>
            <asp:Image ID="Image1" runat="server" Height="165px" ImageUrl="~/images/hecho.png" Width="167px" />
        
             <br />
             <div class="field-wrap">
                Por favor indique las razones por la cual negó la solicitud, dé una respuesta detallada para que el solicitante pueda hacer las correcciones necesarias:<br />
        </div>
        <br />
             <asp:TextBox id="tbxAreaTexto" TextMode="multiline" Columns="50" Rows="5" runat="server" />
        <asp:Button ID="btnDeAcuerdo" runat="server" Text="ENVIAR" OnClick="btnDeAcuerdo_Click"/>

             </center>

    </div>

</asp:Content>
