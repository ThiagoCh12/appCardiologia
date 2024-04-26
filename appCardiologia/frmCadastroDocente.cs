using appCardiologia.Model;
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
    public partial class frmCadastroDocente : Form
    {
        public frmCadastroDocente()
        {
            InitializeComponent();
            Docente docente = new Docente();
            List<Docente> docentes = docente.listaDocente();
            dgvDocente.DataSource = docentes;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCrm.Text == "" || txtTitulacao.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Docente docente = new Docente();
                int crm = Convert.ToInt32(txtCrm.Text);
                if (docente.RegistroRepetido(crm) == true)
                {
                    MessageBox.Show("Docente já existe em nossa base de dados!", "Cadastro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    txtCrm.Text = "";
                    txtTitulacao.Text = "";
                    this.txtNome.Focus();
                    return;
                }
                else
                {
                    docente.Inserir(txtNome.Text, crm, txtTitulacao.Text);
                    MessageBox.Show("Docente cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Docente> docentes = docente.listaDocente();
                    dgvDocente.DataSource = docentes;
                    txtNome.Text = "";
                    txtCrm.Text = "";
                    txtTitulacao.Text = "";
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDocente.Rows[e.RowIndex];
                this.dgvDocente.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCrm.Text = row.Cells[2].Value.ToString();
                txtTitulacao.Text = row.Cells[3].Value.ToString();
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
