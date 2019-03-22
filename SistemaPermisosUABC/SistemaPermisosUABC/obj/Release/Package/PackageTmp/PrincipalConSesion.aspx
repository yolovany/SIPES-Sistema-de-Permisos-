<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/MP_PrincipalConSesion.Master" AutoEventWireup="true" CodeBehind="PrincipalConSesion.aspx.cs" Inherits="SistemaPermisosUABC.PrincipalConSesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head3" runat="server">
    <title>SIPES - Inicio</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header5" runat="server">
    <a href="#menu">SALIR</a>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">


    <!-- DESEA SALIR? -->
    <nav id="menu">
        <ul class="links">
            <h2>
                <li>¿Seguro (a) que desea salir de SIPES? </li>
            </h2>
        </ul>
        <ul class="actions vertical">
            <li><a href="default.aspx" class="button special fit">ACEPTAR</a></li>
        </ul>
    </nav>


    <!-- Banner -->
    <section id="banner" class="style2">
        <div class="inner">
            <span class="image">
                <img src="images/pic07.jpg" alt="" />
            </span>
            <header class="major">
                <h1>
                    <asp:Label ID="Label1" runat="server" Text="Label">BIENVENIDO </asp:Label></h1>
            </header>
            <br />
            <div class="content">
                <p>
                    <asp:Panel ID="Panel1" runat="server">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass ="table-wrapper">
                            <Columns>
                                <asp:TemplateField HeaderText="No. Empleado">
                                    <ItemTemplate>
                                        <asp:Label ID="lblNumEmpleado" runat="server" Text='<%# Eval("NoEmpleado") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nombre">
                                    <ItemTemplate>
                                        <asp:Label ID="lblNombreEmpleado" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Apellidos">
                                    <ItemTemplate>
                                        <asp:Label ID="lblApellidos" runat="server" Text='<%# Eval("Apellidos") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                </p>

                <ul class="actions">

                    <li><a href="#contact" class="button next scrolly">NUEVO PERMISO</a></li>
                </ul>

            </div>
        </div>
    </section>

    <nav id="panelPrincipal">
        <asp:Panel ID="pnlPrincipal" runat="server">
            <!-- INICIA PANEL PRINCIPAL DEL SISTEMA -->
            <section id="two" class="spotlights">
                <section>
                    <a href="#" class="image">
                        <img src="images/pic08.jpg" alt="" data-position="center center" />
                    </a>
                    <div class="content">
                        <div class="inner">
                            <header class="major">
                                <h3>SOLICITUDES PENDIENTES</h3>
                            </header>
                            <p>Las solicitudes hechas que no hayan sido revisadas, se mostrarán aquí:</p>
                            <!-- TABLA SOLICITUDES PENDIENTES-->
                            <p>
                                <asp:Panel ID="pnlTablaSolicitudesPendientes" runat="server">
                                    <asp:GridView ID="grvPendientes" runat="server" AutoGenerateColumns="False" CssClass ="table-wrapper">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Folio">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblFolioSolicitud" runat="server" Text='<%# Eval("FolioSolicitud") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Fecha">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblFechaSolicitud" runat="server" Text='<%# Eval("FechaSolicitud") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Nombre del evento">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblNombreEvento" runat="server" Text='<%# Eval("NombreEvento") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>


                                        </Columns>
                                    </asp:GridView>
                                </asp:Panel>
                                <p>
                                </p>
                                <ul class="actions">

                                    <asp:TextBox ID="tbxFolioSolicitudGrv1" runat="server" CssClass="button" placeholder="Inserte folio "></asp:TextBox>
                                    <br />
                                    <asp:Button ID="Button1" runat="server" CssClass="button" Text="Ver informacion" OnClick="Button1_Click1"/>
                                    &nbsp;
                                    </ul>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                                <p>
                                </p>
                           
                            </p>
                        </div>
                    </div>
                </section>
                <section>
                    <a href="#" class="image">
                        <img src="images/pic09.jpg" alt="" data-position="top center" />
                    </a>
                    <div class="content">
                        <div class="inner">
                            <header class="major">
                                <h3>SOLICITUDES APROBADAS</h3>
                            </header>
                            <p>Las solicitudes hechas que hayan sido revisadas y aprobadas, se mostrarán aquí:</p>

                            <asp:Panel ID="pnlSolicitudesAprobadas" runat="server">
                                <!-- TABLA SOLICITUDES APROBADAS-->
                                <asp:Panel ID="pnlTablaSolicitudesAprobadas" runat="server">
                                    <asp:GridView ID="grvAprobadas" runat="server" AutoGenerateColumns="False" CssClass ="table-wrapper">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Folio">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblFolioSolicitud1" runat="server" Text='<%# Eval("FolioSolicitud") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Fecha">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblFechaSolicitud1" runat="server" Text='<%# Eval("FechaSolicitud") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Nombre del evento">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblNombreEvento1" runat="server" Text='<%# Eval("NombreEvento") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>


                                        </Columns>
                                    </asp:GridView>
                                </asp:Panel>

                                <ul class="actions">
                                    <asp:TextBox ID="tbcFolioSolicitudGrv2" runat="server" placeholder="Inserte folio de la solicitud a revisar"></asp:TextBox>
                                    <br />
                                    <asp:Button ID="Button4" runat="server" CssClass="button" Text="Ver oficio comisión" OnClick="Button4_Click" />
                                    &nbsp
                                <asp:Button ID="Button5" runat="server" CssClass="button" Text="Enviar reporte y evidencia" OnClick="Button5_Click" />
                                </ul>

                            </asp:Panel>

                        </div>
                    </div>
                </section>
                <section>
                    <a href="#" class="image">
                        <img src="images/pic10.jpg" alt="" data-position="25% 25%" />
                    </a>
                    <div class="content">
                        <div class="inner">
                            <header class="major">
                                <h3>SOLICITUDES RECHAZADAS</h3>
                            </header>
                            <p>Las solicitudes hechas que no hayan sido negadas, se mostrarán aquí. 
                                En caso de que su solicitud se encuentre en este apartado se le notificará por correo electrónico los motivos de su rechazo.</p>

                            <asp:Panel ID="pnlSolicitudesRechazadas" runat="server">
                                <!-- TABLA SOLICITUDES RECHAZADAS-->
                                <asp:Panel ID="pnlTablaSolicitudesRechazadas" runat="server">
                                    <asp:GridView ID="grvRechazadas" runat="server" AutoGenerateColumns="False" CssClass ="table-wrapper">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Folio">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblFolioSolicitud2" runat="server" Text='<%# Eval("FolioSolicitud") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Fecha">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblFechaSolicitud2" runat="server" Text='<%# Eval("FechaSolicitud") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Nombre del evento">
                                                <ItemTemplate>
                                                    <asp:Label ID="NombreEvento2" runat="server" Text='<%# Eval("NombreEvento") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>


                                        </Columns>
                                    </asp:GridView>
                                </asp:Panel>

                            </asp:Panel>
                        </div>
                    </div>
                </section>
            </section>
            <!-- FIN DE SECCIÓN PRINCIPAL-->
        </asp:Panel>
    </nav>


    <!-- INFORMACIÓN SOBRE LAS ETIQUETAS -->
    <!-- div class="field half first" Y class="field half" SE USAN PARA PONER DOS CAMPOS DE TEXTO EN UN RENGLÓN -->
    <!-- class="field half first" PARA PONER CAMPO DEL LADO IZQUIERO -->
    <!-- class="field half" PARA PONER CAMPO DEL LADO DERECHO -->
    <!-- class="field" SE UTILIZA PARA PONER UN CAMPO DE TEXTO EN UN SÓLO RENGLÓN LARGO-->


    <!-- Contact -->
    <section id="contact">
        <div class="inner">
            <section>
                <form method="post" action="#">

                    <h1>SOLICITAR NUEVO PERMISO</h1>
                        <asp:TextBox ID="txtNombreEmpleado" runat="server"></asp:TextBox>

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
                        <asp:TextBox ID="txtCostoEvento"  runat="server" TextMode="SingleLine"></asp:TextBox>
                    </div>

                    <div class="field half">
                        <label for="name">LUGAR: </label>
                        <asp:TextBox ID="txtLugar" runat="server"></asp:TextBox>
                    </div>

                    <div class="field half first">
                        <label for="name">FECHA DE SALIDA: </label>
                        <asp:TextBox ID="txtFechaSalida" CssClass="button" runat="server" TextMode="Date"></asp:TextBox>
                    </div>

                    <div class="field half">
                        <label for="name">HORA DE SALIDA (24 HORAS) : </label>
                        <asp:TextBox ID="txtHoraSalida" CssClass="button"  runat="server" TextMode="Time"></asp:TextBox>
                    </div>

                    <div class="field half first">
                        <label for="name">FECHA DE REGRESO: </label>
                        <asp:TextBox ID="txtFechaRegreso" CssClass="button"  runat="server" TextMode="Date"></asp:TextBox>
                    </div>

                    <div class="field half">
                        <label for="name">HORA DE REGRESO (24 HORAS) : </label>
                        <asp:TextBox ID="txtHoraRegreso" CssClass="button" runat="server" TextMode="Time"></asp:TextBox>
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
                        <asp:Button ID="btnEnviarSolicitud" runat="server" Text="ENVIAR" CssClass="button special" OnClick=" btnEnviarSolicitud_Click"  />

                    </ul>
                 </form>
           </section>
            <section class="split">
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email                  </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email                  </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email                  </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email                  </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email                  </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email                  </div>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Phone</h3>
                        <span>(000) 000-0000 x12387</span>
                    </div>
                </section>
            </section>
        </div>
    </section>


    <section id="five">

        <center>
            <p>
                <ul class="actions">
                    <li><a class="button next scrolly" href="#panelPrincipal">ARRIBA</a></li>
                </ul>
            </p>

        </center>

    </section>

</asp:Content>

