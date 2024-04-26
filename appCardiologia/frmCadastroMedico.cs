using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appCardiologia.Model;

namespace appCardiologia
{
    public partial class frmCadastroMedico : Form
    {
        public frmCadastroMedico()
        {
            InitializeComponent();
            Medico medico = new Medico();
            List<Medico> medicos = medico.listaMedicos();
            dgvMedico.DataSource = medicos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCrm.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Medico medico = new Medico();
                int crm = Convert.ToInt32(txtCrm.Text);
                if (medico.RegistroRepetido(crm) == true)
                {
                    MessageBox.Show("Medico já existe em nossa base de dados!", "Cadastro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    txtCrm.Text = "";             
                    this.txtNome.Focus();
                    return;
                }
                else
                {
                    medico.Inserir(txtNome.Text, crm);
                    MessageBox.Show("Medico cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Medico> medicos = medico.listaMedicos();
                    dgvMedico.DataSource = medicos;
                    txtNome.Text = "";
                    txtCrm.Text = "";
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMedico.Rows[e.RowIndex];
                this.dgvMedico.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCrm.Text = row.Cells[2].Value.ToString();
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
