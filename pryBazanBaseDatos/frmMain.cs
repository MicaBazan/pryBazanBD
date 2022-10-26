using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazanBaseDatos
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void deportistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmConsultarDeportista().ShowDialog();
        }

        private void entrenadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmConsultarEntrenador().ShowDialog();
        }

        private void deportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRegistrarDeportista().ShowDialog();
        }

        private void entrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRegistrarEntrenador().ShowDialog();
        }

        private void deportistaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new frmEliminarDeportista().ShowDialog();
        }
    }
}
