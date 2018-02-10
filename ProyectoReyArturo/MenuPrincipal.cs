using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoReyArturo
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void datosMaestrosDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatMaeUsuario mostrarDatMaeUsuarui = new DatMaeUsuario();
            mostrarDatMaeUsuarui.MdiParent = this.MdiParent;
            mostrarDatMaeUsuarui.Show();

        }
    }
}
