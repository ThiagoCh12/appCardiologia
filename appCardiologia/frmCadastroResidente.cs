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
    public partial class frmCadastroResidente : Form
    {
        public frmCadastroResidente()
        {
            InitializeComponent();
        }

        private void dgvResidente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvResidente.Rows[e.RowIndex];
                this.dgvResidente.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCrm.Text = row.Cells[2].Value.ToString();
                mktDataResidencia.Text = row.Cells[3].Value.ToString();
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCrm.Text == "" || mktDataResidencia.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Residente residente = new Residente();
                int crm = Convert.ToInt32(txtCrm.Text);
                DateTime data_residencia = Convert.ToDateTime(mktDataResidencia);
                if (residente.RegistroRepetido(crm) == true)
                {
                    MessageBox.Show("Docente já existe em nossa base de dados!", "Cadastro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    txtCrm.Text = "";
                    mktDataResidencia.Text = "";
                    this.txtNome.Focus();
                    return;
                }
                else
                {
                    
                    residente.Inserir(txtNome.Text, crm, data_residencia);
                    MessageBox.Show("Residente cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Residente> residentes = residente.listaResidente();
                    dgvResidente.DataSource = residentes;
                    txtNome.Text = "";
                    txtCrm.Text = "";
                    mktDataResidencia.Text = "";
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
