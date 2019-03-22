<%@ Page Title="" Language="C#" MasterPageFile="~/MP_PrincipalConSesion.Master" AutoEventWireup="true" CodeBehind="ServicioNoSoportado.aspx.cs" Inherits="SistemaPermisosUABC.ServicioNoSoportado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header5" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class ="form">

         <<center>
            <asp:Image ID="Image20" runat="server" Height="165px" ImageUrl="~/images/usuario.png" Width="167px" />
        
             <br />
             <h2>UPS!</h2>
             <div class="field-wrap">
                 Lo lamentamos, este servicio no se encuentra disponible aún en servidor en linea de ASP.NET
                 <br />
        </div>
        <br />
        <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click"  />

             </center>

    </div>

</asp:Content>
