<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/MP_PrincipalConSesion.Master" AutoEventWireup="true" CodeBehind="RevisionSolicitud.aspx.cs" Inherits="SistemaPermisosUABC.RevisionSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header5" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- GRACIAS POR REVISAR -->
    

         <section id="contact">
        <div class="inner">
            <section>
                <form method="post" action="#">

                    <h2>REQUERIMIENTOS DE SOLICITUD:</h2>
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
                        <asp:Button  ID="btnAceptarSolicitud" runat="server" Text="APROBAR" CssClass="button special" OnClick="btnAceptarSolicitud_Click"/> 
                        <asp:Button  ID="btnRechazarSolicitud" runat="server" Text="RECHAZAR" CssClass="button special" OnClick="btnRechazarSolicitud_Click" />
                    </ul>
                </form>
            </section>
            <section class="split">
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email </h3>                 </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email</h3>                  <
                        </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email </h3>                 </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email </h3>                </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email </h3>                 </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email  </h3>                </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
            </section>
        </div>
    </section>

</asp:Content>
