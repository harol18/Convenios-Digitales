using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios_planta.Capa_presentacion
{
    public partial class Matriz_Convenios : Form
    {
        Comandos cmds = new Comandos();

        public Matriz_Convenios()
        {
            InitializeComponent();
        }

        private void Buscar_Matriz(object sender, EventArgs e)
        {
            cmds.Buscar_matriz(TxtCodigo_Convenio, TxtNombre_Convenio,TxtDirigido,TtxRestriccion,TxtDocumentos_Requeridos,
                               TxtGestion_Comer,TxtGestion_Red,TxtHorarios_Gestion,TxtCondiciones_Especiales,TxtPaz_Salvo,
                               TxtContacto_Convenio,TxtContacto_Gic,TxtFecha_Actualizacion_Matriz);
        }
    }
}
