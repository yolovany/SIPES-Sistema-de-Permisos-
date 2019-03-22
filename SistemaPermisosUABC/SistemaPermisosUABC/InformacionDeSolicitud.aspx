<%@ Page Title="" Language="C#" MasterPageFile="~/MP_PrincipalConSesion.Master" AutoEventWireup="true" CodeBehind="VerSolicitudPendiente.aspx.cs" Inherits="SistemaPermisosUABC.VerSolicitudPendiente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header5" runat="server">
    <a href="PrincipalConSesion.aspx">VOLVER</a> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <section id="contact">
        <div class="inner">
            <section>
                <form method="post" action="#">

                    <h1>REQUERIMIENTOS DE SOLICITUD:</h1>
                    <br />
                    <br />
                    <div class="field ">
                        <label for="name">NOMBRE: </label>
                        <asp:TextBox ID="txtNombreEmpleado" runat="server"></asp:TextBox>
                    </div>

                    <div class="field half first">
                        <label for="name">NÚMERO DE EMPLEADO: </label>
                        <asp:TextBox ID="txtNumEmpleado" runat="server"></asp:TextBox>
                    </div>

                    <div class="field half">
                        <label for="name">CATEGORÍA: </label>
                        <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
                    </div>

                    <br />
                    <h3>Carreras en las que afecta la salida: </h3>

                    <div class="field half first">
                        <asp:CheckBox ID="chbCivil" runat="server" Text="Civil" />
                    </div>

                    <div class="field half">
                        <asp:CheckBox ID="chbElectronica" runat="server" Text="Electrónica" />
                    </div>

                        <div class="field half first">
                        <asp:CheckBox ID="chbComputacion" runat="server" Text="Computación" />
                    </div>

                    <div class="field half">
                        <asp:CheckBox ID="chbIndustrial" runat="server" Text="Industrial"></asp:CheckBox>
                    </div>

                    <div class="field half first">
                        <asp:CheckBox ID="chbArquitectura" runat="server" Text="Arquitectura" />
                    </div>

                    <div class="field half">
                        <asp:CheckBox ID="chbBioingeniería" runat="server" Text="Bioingeniería" />
                    </div>

                        <div class="field half first">
                        <asp:CheckBox ID="chbNanotecnologia" runat="server" Text="Nanotecnologia" />
                    </div>

                     <div class="field half">
                        <!-- CAMPO VACÍO -->
                    </div>

                    <!-- -->

                    <div class="field">
                        <asp:TextBox ID="txtNombreEvento" runat="server" placeholder="NOMBRE DEL EVENTO O ACTIVIDAD"></asp:TextBox>
                    </div>

                    <div class="field half first">
                        <label for="name">COSTO DEL EVENTO: </label>
                        <asp:TextBox ID="txtCostoEvento" runat="server"></asp:TextBox>
                    </div>

                    <div class="field half">
                        <label for="name">LUGAR: </label>
                        <asp:TextBox ID="txtLugar" runat="server"></asp:TextBox>
                    </div>

                    <div class="field half first">
                        <label for="name">FECHA DE SALIDA: </label>
                        <asp:TextBox ID="txtFechaSalida" runat="server"></asp:TextBox>
                    </div>

                    <div class="field half">
                        <label for="name">HORA DE SALIDA: </label>
                        <asp:TextBox ID="txtHoraSalida" runat="server"></asp:TextBox>
                    </div>

                    <div class="field half first">
                        <label for="name">FECHA DE REGRESO: </label>
                        <asp:TextBox ID="txtFechaRegreso" runat="server"></asp:TextBox>
                    </div>

                    <div class="field half">
                        <label for="name">HORA DE REGRESO: </label>
                        <asp:TextBox ID="txtHoraRegreso" runat="server"></asp:TextBox>
                    </div>

                    <h3>Recursos a utilizar: </h3>

                    <div class="field half first">
                        <asp:CheckBox ID="cbxHospedaje" runat="server" Text="Hospedaje" />
                    </div>

                    <div class="field half">
                        <asp:CheckBox ID="cbxTransporte" runat="server" Text="Transporte" />
                    </div>

                    <div class="field half first">
                        <asp:CheckBox ID="cbxCombustible" runat="server" Text="Combustible" />
                    </div>

                    <div class="field half ">
                        <asp:TextBox ID="txtCantCombustible" runat="server" placeholder="Cantidad de combustible (litros)"></asp:TextBox>
                    </div>

                    <div class="field half first">
                        <asp:CheckBox ID="cbxOficioComision" runat="server" Text="Oficio comision" />
                    </div>

                    <div class="field half">
                         <asp:TextBox ID="txtOtro" runat="server" Placeholder="Otro"></asp:TextBox>
                    
                    </div>

                        <h3>Actividad asociada a: </h3>

                        <div class="field half first">
                        <asp:CheckBox ID="cbxCasei" runat="server" Text="CACEI / CIEES" />
                    </div>

                    <div class="field half">
                        <asp:CheckBox ID="cbxIso" runat="server" Text="ISO 90001:2008" />
                    </div>

                    <div class="field half first">
                        <asp:CheckBox ID="cbxLicenciatura" runat="server" Text="Licenciatura" />
                    </div>

                    <div class="field half">
                        <asp:CheckBox ID="cbxPosgrado" runat="server" Text="Posgrado" />
                    </div>

                        <div class="field half first">
                        <asp:CheckBox ID="cbxPersonal" runat="server" Text="Personal" />
                    </div>

                        <div class="field half">
                        <asp:TextBox ID="txtOtraActividadAsociada" runat="server" placeholder="Otra actividad asociada"></asp:TextBox>
                    </div>

                    <ul class="actions">
                        <asp:Button  ID="btnAceptarSolicitud" runat="server" Text="APROBAR" CssClass="button special" /> 
                        <asp:Button  ID="btnRechazarSolicitud" runat="server" Text="RECHAZAR" CssClass="button special"  />
                    </ul>
                </form>
            </section>
            <section class="split">
                <h3>RESPONSABLES INVOLUCRADOS</h3>

                <asp:Panel ID="pnlDirector" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombreDirector" runat="server" Text="Nombre Director de la facultad"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolDirector" runat="server" Text="Director de la facultad"></asp:Label></h3>
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoDirector" runat="server" Text="correo@uabc.edu.mx"></asp:Label>                 
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionDirector" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                        
                    </section>
                </asp:Panel>

                <asp:Panel ID="pnlSubdirector" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombreSubdirector" runat="server" Text="Nombre subdirector de la facultad"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolSubdirector" runat="server" Text="Subdirector de la facultad"></asp:Label></h3>
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoSubdirector" runat="server" Text="correo@uabc.edu.mx"></asp:Label>                
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionSubdirector" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                        
                    </section>
                </asp:Panel>

                <asp:Panel ID="pnlAdministrador" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombreAdministrador" runat="server" Text="Nombre administrador(a) de la facultad"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolAdministrador" runat="server" Text="Administrador(a) de la facultad"></asp:Label></h3>
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoAdministrador" runat="server" Text="correo@uabc.edu.mx"></asp:Label>                 
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionAdministrador" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                        
                    </section>
                </asp:Panel>

                <asp:Panel ID="pnlPosgrado" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombrePosgrado" runat="server" Text="Nombre coordinador de posgrado"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolPosgrado" runat="server" Text="Coordinador de posgrado"></asp:Label></h3>
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoPosgrado" runat="server" Text="correo@uabc.edu.mx"></asp:Label>                
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionPosgrado" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                        
                    </section>
                </asp:Panel>

                <asp:Panel ID="pnlCarrAsociadaComputacion" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombreComputacion" runat="server" Text="Nombre coordinador de computación"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolComputacion" runat="server" Text="Coordinador de computación"></asp:Label></h3>
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoComputacion" runat="server" Text="correo@uabc.edu.mx"></asp:Label>               
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionComputacion" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                        
                    </section>
                </asp:Panel>

                <asp:Panel ID="pnlCarrAsociadaElectronica" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombreElectronica" runat="server" Text="Nombre coordinador de electronica"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolElectronica" runat="server" Text="Coordinador de electronica"></asp:Label></h3>
                        
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoElectronica" runat="server" Text="correo@uabc.edu.mx"></asp:Label>               
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionElectronica" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                    </section>
                </asp:Panel>

                <asp:Panel ID="pnlCarrAsociadaCivil" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombreCivil" runat="server" Text="Nombre coordinador de civil"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolCivil" runat="server" Text="Coordinador de civil"></asp:Label></h3>
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoCivil" runat="server" Text="correo@uabc.edu.mx"></asp:Label>               
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionCivil" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                        
                    </section>
                </asp:Panel>

                <asp:Panel ID="pnlCarrAsociadaIndustrial" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombreIndustrial" runat="server" Text="Nombre coordinador de industrial"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolIndustrial" runat="server" Text="Coordinador de industrial"></asp:Label></h3>
                        
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoIndustrial" runat="server" Text="correo@uabc.edu.mx"></asp:Label>               
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionIndustrial" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                    </section>
                </asp:Panel>

                <asp:Panel ID="pnlCarrAsociadaArquitectura" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombreArquitectura" runat="server" Text="Nombre coordinador de arquitectura"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolArquitectura" runat="server" Text="Coordinador de arquitectura"></asp:Label></h3>
                        
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoArquitectura" runat="server" Text="correo@uabc.edu.mx"></asp:Label>                
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionArquitectura" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                    </section>
                </asp:Panel>

                <asp:Panel ID="pnlCarrAsociadaBioingenieria" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombreBioingenieria" runat="server" Text="Nombre coordinador de bioingeniería"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolBioingenieria" runat="server" Text="Coordinador de bioingeniería"></asp:Label></h3>
                        
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoBioingenieria" runat="server" Text="correo@uabc.edu.mx"></asp:Label>                
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionBioingenieria" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                    </section>
                </asp:Panel>

                <asp:Panel ID="pnlCarrAsociadaNanotecnologia" runat="server" Visible="false">
                    <section>
                        <h3> <asp:Label ID="lblNombreNanotecnologia" runat="server" Text="Nombre coordinador de nanotecnología"></asp:Label></h3>
                        <h3> <asp:Label ID="lblRolNanotecnologia" runat="server" Text="Coordinador de nanotecnología"></asp:Label></h3>
                        
                        <div class="contact-method">
                            <span class="icon alt fa-envelope"></span>
                            <h3>
                            Email </h3>   
                            <asp:Label ID="lblCorreoNanotecnologia" runat="server" Text="correo@uabc.edu.mx"></asp:Label>
                        </div>
                        <h3> <asp:Label ID="lblEstadoRevisionNanotecnologia" runat="server" Text="Estado de revisión: "></asp:Label></h3>
                    </section>
                </asp:Panel>

            </section>
        </div>
    </section>

</asp:Content>
