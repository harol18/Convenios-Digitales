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
    public partial class FormEnvio_Correos : Form
    {

        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;password=Indr42020$;database=dblibranza;port=3306;persistsecurityinfo=True;");

        Comandos cmds = new Comandos();

        public FormEnvio_Correos()
        {
            InitializeComponent();
        }

        DateTime hoy = DateTime.Now;

        private void FormEnvio_Correos_Load(object sender, EventArgs e)
        {
            lblfecha.Text = hoy.ToString("dd/MM/yyyy");
            lblfecha.Visible = false;
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            string cadena = Txtcod_convenio.Text;
            string codigo_convenio = cadena.Substring(0, 3);

            MySqlCommand comando = new MySqlCommand("SELECT Correo_Convenio, Correo_GicVb FROM matriz_convenios WHERE Codigo_Convenio = @Codigo_Convenio ", con);
            comando.Parameters.AddWithValue("@Codigo_Convenio", codigo_convenio);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                usuario.Correo_Convenio = registro["Correo_Convenio"].ToString();
                usuario.Correo_Gic = registro["Correo_GicVb"].ToString();
                TxtDestinatario_Correo.Text = registro["Correo_Convenio"].ToString();
                TxtCorreo_Gic.Text = registro["Correo_GicVb"].ToString();
                con.Close();
            }
            else
            {
                con.Close();
                TxtDestinatario_Correo.Text = null;
                TxtCorreo_Gic.Text = null;                
                MessageBox.Show("Consecutivo no se encuentra en la matriz, por favor reportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cmds.Enviar_correos(lblfecha, Txtcod_convenio, dtpHora_Envio, dgvDatos);
            dgvDatos.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
        }

        private void dgvCorreos_Pendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txtcod_convenio.Text = dgvCorreos_Pendientes.CurrentRow.Cells[1].Value.ToString();
            dtpHora_Envio.Text= dgvCorreos_Pendientes.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnActualizar_BD_Click(object sender, EventArgs e)
        {
            MessageBox.Show(usuario.Correo_Convenio);
            MessageBox.Show(usuario.Correo_Gic);
        }

        private void btnVer_pte_Correos_Click(object sender, EventArgs e)
        {
            cmds.Pendiente_correo(dgvCorreos_Pendientes, lblfecha);
        }
    }
}
