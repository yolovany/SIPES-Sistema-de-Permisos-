<%@ Page Title="" Language="C#" EnableEventValidation="false"  MasterPageFile="~/MP_PrincipalSinSesion.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SistemaPermisosUABC.PrincipalSinSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="header1">
    <a href="LoginPage.aspx">INICIAR</a>
</asp:Content>
<asp:Content ID="Content4" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <!-- Banner -->
     <!-- Banner -->
					<section id="banner" class="major">
						<div class="inner">
							<header class="major">
								<h2>SISTEMA DE SOLICITUD DE PERMISOS DE SALIDA EN UABC</h2>
							</header>
							<div class="content">
								<p>
                        BIENVENIDO A SIPES, EL SISTEMA DE PERMISOS UABC<br />
                        DONDE PODRÁ SOLICITAR SUS PERMISOS DE SALIDA EN DIRECCIÓN.
                    </p>
                    <ul class="actions">
                        <br />
                    
                        <li><a href="#one" class="button next scrolly">VER CÓMO FUNCIONA</a></li> 
                         
                    </ul>
                                <br />
                                
							</div>
						</div>
					</section>


    <!-- Main -->
    <div id="main">
        <!-- One -->
        <section id="one">
            <div class="inner">
                <header class="major">
                    <h2>PRESENTACIÓN</h2>
                </header>
                <p>
                    SIPES es un sistema pensado para maestros, quienes deseen solicitar permisos de salida en la dirección de FIAD. Los maestros podrán solicitar los permisos siempre y cuándo llenen el formato y toda la información necesaria la cual será enviada a los responsables para la futura revisión via correo electrónico y telefónico.
                <ul class="actions">
                </ul>
                </p>
            </div>
        </section>


        <!-- Two -->
        <section id="two" class="tiles">
            <article>
                <span class="image">
                    <img src="images/pic01.jpg" alt="" />
                </span>
                <header class="major">
                    <h3><a href="#menu">Inicia sesión</a></h3>
                    <p>
                        Para entrar al sistema de solicitudes es necesario iniciar sesión ingresando el correo facultativo y contraseña del mismo.
                    </p>
                </header>
            </article>
            <article>
                <span class="image">
                    <img src="/images/pic02.jpg" alt="" />
                </span>
                <header class="major">
                    <h3><a href="#" class="major">Seguimiento de solicitudes</a></h3>
                    <p>
                        Al entrar al sistema podrás llevar un seguimiento de solicitudes, mostrándote las pendientes, aprobadas y rechazadas.
                    </p>
                </header>
            </article>
            <article>
                <span class="image">
                    <img src="images/pic03.jpg" alt="" />
                </span>
                <header class="major">
                    <h3><a href="#" class="major">Notificación por correo</a></h3>
                    <p>
                        Ya no tendrá que perseguir firmas, SIPES trabaja por usted enviando la solicitud por correo electrónico a los responsables en dirección
                    </p>
                </header>
            </article>
            <article>
                <span class="image">
                    <img src="images/pic04.jpg" alt="" />
                </span>
                <header class="major">
                    <h3><a href="#" class="major">Ver oficio comisión</a></h3>
                    <p>
                        Siempre podrá acceder al oficio comisión de cualquier solicitud aprobada e imprimirlo en el momento que lo requiera
                    </p>
                </header>
            </article>
            <article>
                <span class="image">
                    <img src="../MasterPages/images/pic05.jpg" alt="" />
                </span>
                <header class="major">
                    <h3><a href="#" class="major">Enviar reporte
                        <br />
                        de evidencias</a></h3>
                    <p>
                        Luego de aprobar la solicitud, tendrá 5 días hábiles para enviar reporte y evidencias de dicha salida. Podrá hacerlo en este mismo portal.
                    </p>
                </header>
            </article>
            <article>
                <span class="image">
                    <img src="images/pic06.jpg" alt="" />
                </span>
                <header class="major">
                    <h3><a href="#" class="major">Cancela en cualquier momento</a></h3>
                    <p>
                        Por el momento no es posible eliminar solicitudes hechas que se encuentren pendientes. Sin embargo puede solicitar un nuevo permiso sin problema.
                    </p>
                </header>
            </article>
        </section>
    </div>



    <!-- Contact -->
    <section id="contact">
        <div class="inner">
            <section>
                <form method="post" action="#">

                    <h2>¿DUDAS O SUGERENCIAS?<br/>Envíenos un correo</h2>
                 

                    <div class="field half first">
                        <label for="name">
                            NOMBRE</label>

                        <asp:TextBox ID="txbNombreRemitente" runat="server"></asp:TextBox>
                    </div>
                    <div class="field half">
                        <label for="email">
                            CORREO</label>
                        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                    </div>       
                    <div class="field">
                        <label for="message">
                            MENSAJE:</label>
                        <asp:TextBox id="tbxAreaTexto" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                    </div>
                    <ul class="actions">
                      
                            <asp:Button ID="btnEnviarDuda" runat="server" Text="Enviar" OnClick="btnEnviarDuda_Click" /> &nbsp
                        
                                <input type="reset" value="LIMPIAR" />
                    </ul>
                </form>
            </section>
            <section class="split">
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-envelope"></span>
                        <h3>Email</h3>
                        <a href="#">info@uabc.edu.mx</a>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-phone"></span>
                        <h3>Teléfono</h3>
                        <span>(646) 1750744</span>
                    </div>
                </section>
                <section>
                    <div class="contact-method">
                        <span class="icon alt fa-home"></span>
                        <h3>Dirección FIAD</h3>
                        <span>1234 CARRETERA TRANSPENINSULAR ENSENADA-TIJUANA NUMERO 3917<br />
                            COLONIA PLAYITAS.
                        <br />
                            Ensenada, B.C. México, C.P. 22860.</span>
                    </div>
                </section>
            </section>
        </div>
    </section>
    <section id="five">
        <center>
        <div class="inner">
            <header class="major">
                <br>
                <br>
                <h2>COMIENZA AHORA!</h2>
            </header>
            <p>
            <ul class="actions">
                <li><a  class="button next scrolly" href="LoginPage.aspx">SOLICITAR PERMISO</a></li>
            </ul>
            </p>
        </div>
    </section>

    </center>

</asp:Content>



