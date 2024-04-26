using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCardiologia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxMedico_Click(object sender, EventArgs e)
        {
            frmCadastroMedico frmCadastroMedico = new frmCadastroMedico();
            frmCadastroMedico.Show();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMedico frmCadastroMedico = new frmCadastroMedico();
            frmCadastroMedico.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDocente frmCadastroDocente = new frmCadastroDocente();
            frmCadastroDocente.Show();
        }

        private void residenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroResidente frmCadastroResidente = new frmCadastroResidente();
            frmCadastroResidente.Show();
        }
    }
}
