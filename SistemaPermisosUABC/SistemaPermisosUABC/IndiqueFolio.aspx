<%@ Page Title="" Language="C#" MasterPageFile="~/MP_PrincipalConSesion.Master" AutoEventWireup="true" CodeBehind="IndiqueFolio.aspx.cs" Inherits="SistemaPermisosUABC.IndiqueFolio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header5" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class ="form">

         <center>
            <asp:Image ID="Image20" runat="server" Height="165px" ImageUrl="~/images/green.png" Width="167px" />
        
             <br />
             <h2>INDIQUE FOLIO</h2>
             <div class="field-wrap">
                 es necesario saber el folio de la solicitud para ejecutar dicha acción
                 <br />
        </div>
        <br />
        <asp:Button ID="btnOk" runat="server" Text="DE ACUERDO" OnClick="btnOk_Click"  />

             </center>

    </div>

</asp:Content>
