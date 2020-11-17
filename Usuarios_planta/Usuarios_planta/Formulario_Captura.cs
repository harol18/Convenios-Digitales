using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Usuarios_planta
{
    public partial class Formulario_Captura : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;password=Indr42020$;database=dblibranza;port=3306;persistsecurityinfo=True;");

        Comandos cmds = new Comandos();
        Conversion c = new Conversion();

        public Formulario_Captura()
        {
            InitializeComponent();
        }

        DateTime fecha = DateTime.Now;

        private void Cerrar(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new VoBo();
            formulario.Show();
        }

        private void Minimizar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Enviar_Correos(object sender, EventArgs e)
        {
            Form formulario = new FormEnvio_Correos();
            formulario.Show();
        }

        private void Buscar_Registro(object sender, EventArgs e)
        {
            cmds.Buscar_vobo(TxtRadicado, TxtCedula_Cliente, TxtNombre_Cliente, TxtScoring, cmbFuerza_Venta, TxtCodigo_Convenio, TxtConsecutivo,
                             TxtCod_Consecutivo, cmbGrado, TxtCod_Militar1, TxtCod_Militar2, cmbDestino, TxtSubproducto, TxtTasa_E_A, TxtTasa_N_M,
                             TxtMonto_Aprobado, TxtPlazo_Aprobado, TxtValor_Cuota, TxtTotal_Credito, TxtMonto_Letras, TxtTotal_Letras, TxtCartera1,
                             TxtCartera2, TxtCartera3, TxtCartera4, dtpFecha_Envio, cmbCorte_Envio, dtpHora_Envio, dtpFecha_Posible_Rta,
                             dtpFecha_Restriccion, cmbEstado_Operacion, cmbTipologia, TxtEstado_Correo, TtxRespuesta_Correo, dtpFecha_Cierre_Etapa,
                             TxtComentarios);
            if (TxtCartera1.Text != "" && TxtCartera2.Text != "" && TxtCartera3.Text != "" && TxtCartera4.Text != "")
            {
                TxtCartera1.Visible = true;
                TxtCartera2.Visible = true;
                TxtCartera3.Visible = true;
                TxtCartera4.Visible = true;
                lbcartera1.Visible = true;
                lbcartera2.Visible = true;
                lbcartera3.Visible = true;
                lbcartera4.Visible = true;
            }
            else if (TxtCartera1.Text != "" && TxtCartera2.Text != "" && TxtCartera3.Text != "" && TxtCartera4.Text == "")
            {
                TxtCartera1.Visible = true;
                TxtCartera2.Visible = true;
                TxtCartera3.Visible = true;
                TxtCartera4.Visible = false;
                lbcartera1.Visible = true;
                lbcartera2.Visible = true;
                lbcartera3.Visible = true;
                lbcartera4.Visible = false;
            }
            else if (TxtCartera1.Text != "" && TxtCartera2.Text != "" && TxtCartera3.Text == "" && TxtCartera4.Text == "")
            {
                TxtCartera1.Visible = true;
                TxtCartera2.Visible = true;
                TxtCartera3.Visible = false;
                TxtCartera4.Visible = false;
                lbcartera1.Visible = true;
                lbcartera2.Visible = true;
                lbcartera3.Visible = false;
                lbcartera4.Visible = false;
            }
            else if (TxtCartera1.Text != "" && TxtCartera2.Text == "" && TxtCartera3.Text == "" && TxtCartera4.Text == "")
            {
                TxtCartera1.Visible = true;
                TxtCartera2.Visible = false;
                TxtCartera3.Visible = false;
                TxtCartera4.Visible = false;
                lbcartera1.Visible = true;
                lbcartera2.Visible = false;
                lbcartera3.Visible = false;
                lbcartera4.Visible = false;
            }
            else
            {
                TxtCartera1.Visible = false;
                TxtCartera2.Visible = false;
                TxtCartera3.Visible = false;
                TxtCartera4.Visible = false;
                lbcartera1.Visible = false;
                lbcartera2.Visible = false;
                lbcartera3.Visible = false;
                lbcartera4.Visible = false;
            }
        }

        private void Formulario_Captura_Load(object sender, EventArgs e)
        {
            dtpFecha_Envio.Text = "01/01/2020";
            dtpFecha_Posible_Rta.Text = "01/01/2020";
            dtpFecha_Restriccion.Text = "01/01/2020";
            dtpFecha_Cierre_Etapa.Text = "01/01/2020";
            TxtCod_Militar1.Enabled = false;
            TxtCod_Militar2.Enabled = false;
            cmbGrado.Enabled = false;
            TxtCartera1.Visible = false;
            TxtCartera2.Visible = false;
            TxtCartera3.Visible = false;
            TxtCartera4.Visible = false;
            lbcartera1.Visible = false;
            lbcartera2.Visible = false;
            lbcartera3.Visible = false;
            lbcartera4.Visible = false;
        }

        private void TxtTotal_Credito_TextChanged(object sender, EventArgs e)
        {
            TxtTotal_Letras.Text = c.enletras(TxtTotal_Credito.Text).ToUpper() + " PESOS";
        }

        private void BtnCopiar_Monto_letras_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TxtMonto_Letras.Text, true);
        }

        private void BtnCopiar_Total_Letras_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TxtTotal_Letras.Text, true);
        }

        private void BtnCopiar_Comentarios_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TxtComentarios.Text, true);
        }

        private void TxtMonto_Aprobado_Validated(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TxtMonto_Aprobado.Text) > 0)
            {
                TxtMonto_Aprobado.Text = string.Format("{0:#,##0}", double.Parse(TxtMonto_Aprobado.Text));

            }
            else if (TxtMonto_Aprobado.Text == "")
            {
                TxtMonto_Aprobado.Text = Convert.ToString(0);
            }
        }

        private void TeclaEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void BorrarMensajeError()
        {
            epError.SetError(TxtScoring, "");
            epError.SetError(TxtMonto_Aprobado, "");
            epError.SetError(TxtPlazo_Aprobado, "");
        }

        private bool validar()
        {
            bool ok = true;

            if (TxtScoring.Text == "")
            {
                ok = false;
                epError.SetError(TxtScoring, "Debes digitar N° Scoring");
            }
            if (TxtMonto_Aprobado.Text == "")
            {
                ok = false;
                epError.SetError(TxtMonto_Aprobado, "Debes digitar Monto");
            }
            if (TxtPlazo_Aprobado.Text == "")
            {
                ok = false;
                epError.SetError(TxtPlazo_Aprobado, "Debes digitar Plazo");
            }
            return ok;
        }

        private void Guardar(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (validar())
            {
                cmds.Guardar_vobo(TxtRadicado, TxtCedula_Cliente, TxtNombre_Cliente, TxtScoring, cmbFuerza_Venta, TxtCodigo_Convenio, TxtConsecutivo,
                                  TxtCod_Consecutivo, cmbGrado, TxtCod_Militar1, TxtCod_Militar2, cmbDestino, TxtSubproducto, TxtTasa_E_A, TxtTasa_N_M,
                                  TxtMonto_Aprobado, TxtPlazo_Aprobado, TxtValor_Cuota, TxtTotal_Credito, TxtMonto_Letras, TxtTotal_Letras, TxtCartera1,
                                  TxtCartera2, TxtCartera3, TxtCartera4, dtpFecha_Envio, cmbCorte_Envio, dtpHora_Envio, dtpFecha_Posible_Rta,
                                  dtpFecha_Restriccion, cmbEstado_Operacion, cmbTipologia, TxtEstado_Correo, TtxRespuesta_Correo, dtpFecha_Cierre_Etapa,
                                  TxtComentarios);
            }
        }

        private void TxtScoring_Validated(object sender, EventArgs e)
        {
            string largo = TxtScoring.Text;
            string length = Convert.ToString(largo.Length);

            if (Convert.ToInt32(length) < 20)
            {
                MessageBox.Show("Numero de scoring no cuenta con los 20 digitos correspondientes !! por favor revisar");
                TxtScoring.Focus();
            }
        }

        private void TxtCodigo_Convenio_TextChanged(object sender, EventArgs e)
        {
            TxtCod_Consecutivo.Text = TxtCodigo_Convenio.Text + TxtConsecutivo.Text;
        }

        private void TxtCodigo_Convenio_Validated(object sender, EventArgs e)
        {
            string cadena = TxtCodigo_Convenio.Text;
            string codigo_convenio = cadena.Substring(0, 3);

            MySqlCommand comando = new MySqlCommand("SELECT Nombre_Convenio,Restriccion,Horarios_Gestion FROM matriz_convenios WHERE Codigo_Convenio = @Codigo_Convenio ", con);
            comando.Parameters.AddWithValue("@Codigo_Convenio", codigo_convenio);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNombre_Conveniomt.Text = registro["Nombre_Convenio"].ToString();
                TxtRestriccionmt.Text = registro["Restriccion"].ToString();
                Txt_Horarios_gestionmt.Text = registro["Horarios_Gestion"].ToString();
                con.Close();
            }
            else
            {
                con.Close();
                TxtNombre_Conveniomt.Text = null;
                TxtRestriccionmt.Text = null;
                Txt_Horarios_gestionmt.Text = null;
                MessageBox.Show("Consecutivo no se encuentra en la matriz, por favor reportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (TxtCodigo_Convenio.Text == "NEJ01")
            {
                cmbGrado.Enabled = true;
                TxtCod_Militar1.Enabled = true;
                TxtCod_Militar2.Enabled = true;
            }
            else
            {
                cmbGrado.Enabled = false;
                TxtCod_Militar1.Enabled = false;
                TxtCod_Militar2.Enabled = false;
            }
        }

        private void TxtConsecutivo_Validated(object sender, EventArgs e)
        {
            string largo = TxtConsecutivo.Text;
            string extrae;
            string length = Convert.ToString(largo.Length);

            if (length == "1")
            {
                TxtConsecutivo.Text = "0000" + TxtConsecutivo.Text;
                extrae = TxtConsecutivo.Text.Substring(TxtConsecutivo.Text.Length - 1); // extrae los ultimos 5 digitos del textbox 
                TxtCod_Consecutivo.Text = TxtCodigo_Convenio.Text + extrae;
            }
            else if (length == "2")
            {
                TxtConsecutivo.Text = "000" + TxtConsecutivo.Text;
                extrae = TxtConsecutivo.Text.Substring(TxtConsecutivo.Text.Length - 2); // extrae los ultimos 5 digitos del textbox 
                TxtCod_Consecutivo.Text = TxtCodigo_Convenio.Text + extrae;
            }
        }

        private void TxtMonto_Aprobado_TextChanged(object sender, EventArgs e)
        {
            TxtMonto_Letras.Text = c.enletras(TxtMonto_Aprobado.Text).ToUpper() + "DE PESOS";
        }

        private void TxtValor_Cuota_Validated(object sender, EventArgs e)
        {
            TxtValor_Cuota.Text = string.Format("{0:#,##0}", double.Parse(TxtValor_Cuota.Text));
            TxtTotal_Credito.Text = (double.Parse(TxtValor_Cuota.Text) * double.Parse(TxtPlazo_Aprobado.Text)).ToString();

            if (Convert.ToDouble(TxtTotal_Credito.Text) > 0)
            {
                TxtTotal_Credito.Text = string.Format("{0:#,##0}", double.Parse(TxtTotal_Credito.Text));

            }
            else if (TxtTotal_Credito.Text == "")
            {
                TxtTotal_Credito.Text = Convert.ToString(0);
            }
        }

        private void Nuevo(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new Formulario_Captura();
            formulario.Show();
        }

        private void cmbEstado_Operacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            string extrae_codfuncionario;

            extrae_codfuncionario = usuario.Identificacion.Substring(usuario.Identificacion.Length - 3); // extrae los ultimos 5 digitos del textbox 

            if (cmbEstado_Operacion.Text == "Aprobado")
            {
                TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Crédito aprobado scoring " + TxtScoring.Text + " Monto " + TxtMonto_Aprobado.Text + " Plazo " + TxtPlazo_Aprobado.Text + " Meses Destino " + cmbDestino.Text + " " + extrae_codfuncionario;
            }
            else if (cmbEstado_Operacion.Text == "Negado")
            {
                TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Crédito negado por el pagador " + extrae_codfuncionario;
            }
            else if (cmbEstado_Operacion.Text == "Devuelto 1")
            {
                TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Gestionar con el pensionado la autorización para la consulta de cupo y reactivar el caso adjuntando el pantallazo de autorizacion en pdf que arroja la herramienta. " + extrae_codfuncionario;
            }
            else if (cmbEstado_Operacion.Text == "Devuelto 2")
            {
                TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Gestionar con el cliente la confirmación de la libranza a través de www.sygnus.co el Plazo máximo para la confirmación es de 48 Horas y reactivar el caso para continuar el proceso de lo contrario se tendrá que reprocesar nuevamente en plataforma. " + extrae_codfuncionario;
            }
            else if (cmbEstado_Operacion.Text == "Devuelto 3")
            {
                TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Se realiza devolución ya que al ingresar a la plataforma Sygnus esta indica que el afiliado debe actualizar sus datos personales. Realizar proceso de actualización con el cliente y reactivar operación. " + extrae_codfuncionario;
            }
        }

        private void cmbTipologia_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbEstado_Operacion.Text == "Suspendido")
            {
                string extrae_codfuncionario;

                extrae_codfuncionario = usuario.Identificacion.Substring(usuario.Identificacion.Length - 3); // extrae los ultimos 3 digitos del textbox 

                if (cmbTipologia.Text == "900")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " " + cmbDestino.Text + " " + " se envía a VoBo Pagador el " + dtpFecha_Envio.Text + " " + " Con posible fecha de respuesta el " + dtpFecha_Posible_Rta.Text + " " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "901")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Se envia a VoBo Gic planilla " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "902")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " Se envia planilla para gestión centro de acopio el " + dtpFecha_Envio.Text + " " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "903")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Se envía para reporte fin de mes ante el convenio: posible respuesta " + dtpFecha_Posible_Rta.Text + " " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "904")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " Convenio en periodo de restricción hasta el " + dtpFecha_Restriccion.Text + " " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "905")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " Se radicará en plataforma el día lunes puesto que de acuerdo al circuito no se puede radicar los días viernes. " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "906")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Centro de acopio informa: " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "907")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio se encuentra en periodo de restriccion desde " + dtpFecha_Envio.Text + " Hasta " + dtpFecha_Restriccion.Text + " " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "909")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " se reporta demora convenio al GIC: en espera de respuesta nuevamente del convenio. " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "910")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " se solicitan documentos al archivo para tramite con el convenio. " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "911")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " área archivo informa que no se han recibido documentos, se solicitaran nuevamente el dia (fecha solicitud documentos archivo). " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "912")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " en espera de llegada de documentación física por parte de la oficina para proceder con el tramite VoBo (3 días hábiles). " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "913")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " en espera de llegada de copias de cedula al 150% a color  física por parte de la oficina para proceder con el tramite VoBo (3 días hábiles) " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "914")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Operación reportada al area de retoques por novedad evaluacion y sancion " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "915")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Operación con novedad en validacion con el centro de acopio " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "917")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " se solicita bajar monto del credito al area encargada a solicitud del gic del convenio " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "918")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Operación validada con medios - Operación con recuperación de descuento se gestionará próxima apertura de plataforma " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "919")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " se reporta al area de scoring / cierre operativo para ratificacion de condiciones del credito " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "920")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " se reporta novedad a área encargada. " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "921")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " información de libranza visada en validación. " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "922")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " solicitud de VoBo enviada a la nómina el día " + dtpFecha_Envio.Text + " tiempo máximo de respuesta superado. " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "924")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio CGR Destino " + cmbDestino.Text + " caso en espera de correo de aprobacion de la contraloria informo datos del credito scoring " + TxtScoring.Text + " Monto " + TxtMonto_Aprobado.Text + " Plazo " + TxtPlazo_Aprobado.Text + " Meses Cuota " + TxtValor_Cuota.Text + " Recuerde enviar Correo de Visto bueno al buzón oscar.godoy@contraloria.gov.co y una vez tenga la respuesta remitirla al buzón de gestion.vobodigital@bbva.com.co " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "925")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " se reporta novedad en herramienta " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "927")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " pendiente notificacion por cambio de circuito de vobo " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "928")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Se reporta al área de seguros BBVA en espera de respuesta para continuar tramite de visto bueno pagador convenio. " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "930")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Novedad en el convenio, dirección que indica matriz no se ajusta (esto lo indica el funcionario de domesa). " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "931")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " se remite informacion del credito al comercial para tramite de vobo ante el convenio " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
            }
            else if (cmbEstado_Operacion.Text == "Gestion Comercial VoBo" && cmbTipologia.Text == "729")
            {
                string extrae_codfuncionario;
                extrae_codfuncionario = usuario.Identificacion.Substring(usuario.Identificacion.Length - 3); // extrae los ultimos 3 digitos del textbox 
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Para la consecución del VoBo se informa Monto " + TxtMonto_Aprobado.Text + " Plazo " + TxtPlazo_Aprobado.Text + " Meses por un valor de cuota de " + TxtValor_Cuota.Text + " Valor total crédito " + TxtTotal_Credito.Text + " Gracias " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
            }
            else
            {
                MessageBox.Show("Antes de seleccionar una tipologia debe indicar en el estado de la operacion Suspendido");
                cmbTipologia.Text = null;
            }
        }
    }
}
