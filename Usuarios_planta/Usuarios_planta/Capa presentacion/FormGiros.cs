using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Globalization;
using Color = System.Drawing.Color;
using System.ComponentModel.Design;

namespace Usuarios_planta.Formularios
{
    public partial class FormGiros : Form
    {
        MySqlConnection con = new MySqlConnection("server=;Uid=;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");

        Comandos cmds = new Comandos();
        Conversion c = new Conversion();
        private Button currentBtn;
        


        public FormGiros()
        {
            InitializeComponent();
        }

        bool move = false;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(251, 187, 33);
            public static Color color2 = Color.FromArgb(52, 179, 29);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(53, 41, 237);
            public static Color color5 = Color.FromArgb(53, 41, 237);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.FromArgb(215,219,222);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;                
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 66, 84);
                currentBtn.ForeColor = Color.Gainsboro;
            }
        }

        DateTime fecha = DateTime.Now;

        private void FormGiros_Load(object sender, EventArgs e)
        {
            TxtIDfuncionario.Text = usuario.Identificacion;
            TxtNomFuncionario.Text = usuario.Nombre;
            lblfecha_actual.Text = fecha.ToString("dd/MM/yyyy");
            dtpFecha_Envio.Text = "01/01/2020";
            dtpFecha_Cierre_Etapa.Text = "01/01/2020";
            dtpFecha_Posible_Rta.Text = "01/01/2020";
            dtpFecha_Restriccion.Text = "01/01/2020";
            TxtCod_Militar1.Enabled = false;
            TxtCod_militar2.Enabled = false;
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
        
        private void Txttotal_TextChanged(object sender, EventArgs e)
        {
            TxtTotal_Letras.Text = c.enletras(TxtTotal_Credito.Text).ToUpper() + " PESOS";
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {

            //cmds.buscar_colp(Txtradicado, Txtcedula, Txtnombre, TxtEstado_cliente,Txtafiliacion1, Txtafiliacion2, cmbtipo, Txtscoring, Txtconsecutivo,
            //                 cmbfuerza, cmbdestino, Txtmonto, Txtplazo, Txtcuota, Txttotal, Txtpagare, Txtnit, Txtentidad, Txtcuota_letras,
            //                 Txttotal_letras, cmbestado, cmbcargue, dtpcargue, dtpfecha_desembolso, cmbresultado, cmbrechazo, dtpfecha_rpta,
            //                 Txtplano_dia, Txtplano_pre, TxtN_Plano, Txtcomentarios, TxtIDfuncionario, TxtNomFuncionario);

            if (TxtCartera1.Text!="")
            {
                TxtCartera1.Visible = true;
            }

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btncopy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TxtComentarios.Text, true);
        }

        private void Txtmonto_Validated(object sender, EventArgs e)
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
            if (TxtIDfuncionario.Text == "")
            {
                ok = false;
                epError.SetError(TxtIDfuncionario, "Debes digitar N° Identificación");
            }
            return ok;
        }

        private void BorrarMensajeError()
        {
            epError.SetError(TxtScoring, "");
            epError.SetError(TxtMonto_Aprobado, "");
            epError.SetError(TxtPlazo_Aprobado, "");
            epError.SetError(TxtIDfuncionario, "");
        }


        private void Txtcuota_Validated(object sender, EventArgs e)
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
              
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            //BorrarMensajeError();
            //if (validar())
            //{
            //    cmds.Insertar_colp(Txtradicado,Txtcedula,Txtnombre, TxtEstado_cliente, Txtafiliacion1,Txtafiliacion2,cmbtipo,
            //                       Txtscoring,Txtconsecutivo,cmbfuerza,cmbdestino,Txtmonto,Txtplazo,Txtcuota,Txttotal,Txtpagare,Txtnit,Txtentidad,
            //                       Txtcuota_letras,Txttotal_letras,cmbestado,cmbcargue,dtpcargue,dtpfecha_desembolso,cmbresultado,
            //                       cmbrechazo,dtpfecha_rpta,Txtplano_dia,Txtplano_pre,TxtN_Plano,Txtcomentarios,TxtIDfuncionario,
            //                       TxtNomFuncionario);

            //    Btn_Actualizar.Enabled = true;
            //    Btn_Guardar.Enabled = true;
            //    this.Close();
            //    Form formulario = new FormGiros();
            //    formulario.Show();
            //}
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TxtValor_Cuota.Text, true);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TxtPlazo_Aprobado.Text, true);
        }

        private void Btn_Guardar_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void Btn_Actualizar_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void Btn_Nuevo_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Form formulario = new VoBo();
        //    formulario.Show();
        //}

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TxtTotal_Credito.Text, true);
        }

        private void cmbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtIDfuncionario.Text!="")
            {
                string extrae_codfuncionario;

                extrae_codfuncionario = TxtIDfuncionario.Text.Substring(TxtIDfuncionario.Text.Length - 3); // extrae los ultimos 5 digitos del textbox 

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
                else
                {
                    TxtComentarios.Text = "";
                }
            }
            else if(TxtIDfuncionario.Text =="")
            {
                MessageBox.Show("Antes de seleccionar estado de la operacion por favor digitar la cedula del funcionario")
;           }
           
        }

        //private void pictureBox10_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Form formulario = new VoBo();
        //    formulario.Show();
        //}

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
        }

        private void pictureBox12_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void Txtradicado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
             e.Handled = true;
             SendKeys.Send("{TAB}");
            }
        }

        private void Txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtafiliacion1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtafiliacion2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtscoring_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtconsecutivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtplazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtcuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtIDfuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtmonto_TextChanged(object sender, EventArgs e)
        {
            TxtMonto_Letras.Text = c.enletras(TxtMonto_Aprobado.Text).ToUpper() + "DE PESOS";
        }

        private void TxtCod_militar2_Validated(object sender, EventArgs e)
        {
            if (TxtCod_militar2.Text != TxtCod_Militar1.Text)
            {
                MessageBox.Show("Codigo militar no coincide, por favor revisar");
                TxtCod_Militar1.Focus();
            }
        }

        private void btnAñadir_cartera_Click(object sender, EventArgs e)
        {
            if (TxtCartera1.Visible==false)
            {
                TxtCartera1.Visible = true;
                lbcartera1.Visible = true;
            }
            else if (TxtCartera1.Visible == true && TxtCartera2.Visible == false)
            {
                TxtCartera2.Visible = true;
                lbcartera2.Visible = true;
            }
            else if (TxtCartera1.Visible == true && TxtCartera2.Visible == true && TxtCartera3.Visible == false)
            {
                TxtCartera3.Visible = true;
                lbcartera3.Visible = true;
            }
            else if (TxtCartera1.Visible == true && TxtCartera2.Visible == true && TxtCartera3.Visible == true && TxtCartera4.Visible == false)
            {
                TxtCartera4.Visible = true;
                lbcartera4.Visible = true;
            }
        }

        private void TxtIDfuncionario_Validated(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM tf_usuarios WHERE Identificacion = @Identificacion ", con);
            comando.Parameters.AddWithValue("@Identificacion", TxtIDfuncionario.Text);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNomFuncionario.Text = registro["Nombre"].ToString();
            }
            con.Close();
        }

        private void cmbTipologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbEstado_Operacion.Text == "Suspendido" && TxtIDfuncionario.Text!="")
            {
                string extrae_codfuncionario;

                extrae_codfuncionario = TxtIDfuncionario.Text.Substring(TxtIDfuncionario.Text.Length - 3); // extrae los ultimos 3 digitos del textbox 

                if (cmbTipologia.Text == "900")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " " + cmbDestino.Text + " " + " se envía a VoBo Pagador el " + dtpFecha_Envio.Text + " " + " Con posible fecha de respuesta el " + dtpFecha_Posible_Rta.Text + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "901")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Se envia a VoBo Gic planilla " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "902")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text +" Destino "+ cmbDestino.Text + " Se envia planilla para gestión centro de acopio el " + dtpFecha_Envio.Text + " " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "903")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Se envía para reporte fin de mes ante el convenio: posible respuesta "+ dtpFecha_Posible_Rta.Text + " "+ extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "904")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text + " Convenio en periodo de restricción hasta el "+dtpFecha_Restriccion.Text+" " + extrae_codfuncionario + " " + cmbTipologia.Text;
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
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio se encuentra en periodo de restriccion desde " + dtpFecha_Envio.Text + " Hasta "+ dtpFecha_Restriccion.Text + " " + extrae_codfuncionario + " " + cmbTipologia.Text;
                }
                else if (cmbTipologia.Text == "909")
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio " + TxtCodigo_Convenio.Text + " Destino " + cmbDestino.Text+ " se reporta demora convenio al GIC: en espera de respuesta nuevamente del convenio. " + extrae_codfuncionario + " " + cmbTipologia.Text;
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
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Convenio CGR Destino " +cmbDestino.Text +" caso en espera de correo de aprobacion de la contraloria informo datos del credito scoring " + TxtScoring.Text +" Monto " + TxtMonto_Aprobado.Text + " Plazo " + TxtPlazo_Aprobado.Text + " Meses Cuota " + TxtValor_Cuota.Text + " Recuerde enviar Correo de Visto bueno al buzón oscar.godoy@contraloria.gov.co y una vez tenga la respuesta remitirla al buzón de gestion.vobodigital@bbva.com.co " + extrae_codfuncionario + " " + cmbTipologia.Text;
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
                extrae_codfuncionario = TxtIDfuncionario.Text.Substring(TxtIDfuncionario.Text.Length - 3); // extrae los ultimos 3 digitos del textbox 
                {
                    TxtComentarios.Text = fecha.ToString("dd/MM/yyyy") + " Para la consecución del VoBo se informa Monto "+ TxtMonto_Aprobado.Text + " Plazo " + TxtPlazo_Aprobado.Text + " Meses por un valor de cuota de " + TxtValor_Cuota.Text + " Valor total crédito " + TxtTotal_Credito.Text +" Gracias "+ extrae_codfuncionario + " " + cmbTipologia.Text;
                }
            }
            else if (cmbEstado_Operacion.Text == "Suspendido" && TxtIDfuncionario.Text == "")
            {
                MessageBox.Show("Debe digitar cedula del funcionario que esta gestionando la operacion");
            }
            else
            {
                MessageBox.Show("Antes de seleccionar una tipologia debe indicar en el estado de la operacion Suspendido");   
                cmbTipologia.Text=null;
            }
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
            Clipboard.SetDataObject(TxtComentarios.Text,true);
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
                TxtLLave.Text = TxtCodigo_Convenio.Text + extrae;
            }
            else if (length == "2")
            {
                TxtConsecutivo.Text = "000" + TxtConsecutivo.Text;
                extrae = TxtConsecutivo.Text.Substring(TxtConsecutivo.Text.Length - 2); // extrae los ultimos 5 digitos del textbox 
                TxtLLave.Text = TxtCodigo_Convenio.Text + extrae;
            }          
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new FormGiros();
            formulario.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new VoBo();
            formulario.Show();
        }

        private void TxtCodigo_Convenio_Validated(object sender, EventArgs e)
        {
            if (TxtCodigo_Convenio.Text=="NEJ01")
            {
                cmbGrado.Enabled = true;
                TxtCod_Militar1.Enabled = true;
                TxtCod_militar2.Enabled = true;
            }
            else
            {
                cmbGrado.Enabled = false;
                TxtCod_Militar1.Enabled = false;
                TxtCod_militar2.Enabled = false;
            }
        }

        private void TxtCodigo_Convenio_TextChanged(object sender, EventArgs e)
        {
            TxtLLave.Text = TxtCodigo_Convenio.Text + TxtConsecutivo.Text;
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
    }
}
