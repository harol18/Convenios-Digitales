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
using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;
using SpreadsheetLight;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Usuarios_planta
{
    public partial class FormEnvio_Correos : Form
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
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

        private void btnDescargar_Excel_Click(object sender, EventArgs e)
        {
            string archivo = TxtNombre_Archivo.Text + ".xlsx";

            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            style.Font.Bold = true;
            style.Font.FontSize = 11;
            style.Font.FontName = "Calibri";
            style.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Lavender, System.Drawing.Color.LightGray);
            style.Alignment.Horizontal= HorizontalAlignmentValues.Center;
            SLStyle style2 = new SLStyle();
            style.Font.Bold = true;

            int i = 1;
            foreach (DataGridViewColumn columna in dgvDatos.Columns)
            {
                sl.SetCellValue(1,i, columna.HeaderText.ToString());
                sl.SetCellStyle(1, i, style);
                i++;
            }

            int j = 2;
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                sl.SetCellValue(j, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(j, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(j, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(j, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(j, 5, row.Cells[4].Value.ToString());
                sl.SetCellValue(j, 6, row.Cells[5].Value.ToString());
                sl.SetCellValue(j, 7, row.Cells[6].Value.ToString());
                sl.SetCellValue(j, 8, row.Cells[7].Value.ToString());
                sl.SetCellValue(j, 9, row.Cells[8].Value.ToString());
                sl.SetCellValue(j, 10, row.Cells[9].Value.ToString());
                sl.SetCellStyle(1, j, style2);
                j++;
            }

            sl.SaveAs(@"C:\Users\BBVA\Desktop\Archivos_Digitales\prueba.xlsx");
            MessageBox.Show("Ok archivo creado","Información",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void Txtcod_convenio_TextChanged(object sender, EventArgs e)
        {
            string cadena = Txtcod_convenio.Text;
            string codigo_convenio = cadena.Substring(0, 3);
            TxtNombre_Archivo.Text = "Envio VoBo " + codigo_convenio + " " + hoy.ToString("dd-MM-yyyy");
            TxtAsunto.Text = "Solicitud Planilla VoBo " + codigo_convenio + " " + hoy.ToString("dd-MM-yyyy");
        }
    }
}
