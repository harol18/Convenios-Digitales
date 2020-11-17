using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios_planta
{
    public partial class FormEnvio_Correos : Form
    {
        Comandos cmds = new Comandos();

        public FormEnvio_Correos()
        {
            InitializeComponent();
        }

        DateTime hoy = DateTime.Now;
        private void FormEnvio_Correos_Load(object sender, EventArgs e)
        {
            lblhoy.Text = hoy.ToString("dd/MM/yyyy");
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            cmds.Buscar_matriz_correos(Txtcod_convenio,TxtDestinatario_Correo);
        }

        private void BtnCopiar_Monto_letras_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
