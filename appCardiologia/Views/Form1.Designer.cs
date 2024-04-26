namespace appCardiologia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.residenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.pbxEquipamento = new System.Windows.Forms.PictureBox();
            this.pbxExame = new System.Windows.Forms.PictureBox();
            this.pbxMedico = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEquipamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMedicoToolStripMenuItem,
            this.cadastrarPacienteToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarMedicoToolStripMenuItem
            // 
            this.cadastrarMedicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docenteToolStripMenuItem,
            this.residenteToolStripMenuItem,
            this.medicoToolStripMenuItem});
            this.cadastrarMedicoToolStripMenuItem.Name = "cadastrarMedicoToolStripMenuItem";
            this.cadastrarMedicoToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.cadastrarMedicoToolStripMenuItem.Text = "Cadastrar medico";
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // residenteToolStripMenuItem
            // 
            this.residenteToolStripMenuItem.Name = "residenteToolStripMenuItem";
            this.residenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.residenteToolStripMenuItem.Text = "Residente";
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medicoToolStripMenuItem.Text = "Medico";
            // 
            // cadastrarPacienteToolStripMenuItem
            // 
            this.cadastrarPacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.cadastrarPacienteToolStripMenuItem.Name = "cadastrarPacienteToolStripMenuItem";
            this.cadastrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cadastrarPacienteToolStripMenuItem.Text = "Paciente";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Medico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Exame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Equipamentos";
            // 
            // pbxSair
            // 
            this.pbxSair.Image = global::appCardiologia.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(593, 184);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(137, 134);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSair.TabIndex = 21;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // pbxEquipamento
            // 
            this.pbxEquipamento.Image = global::appCardiologia.Properties.Resources.equipamento;
            this.pbxEquipamento.Location = new System.Drawing.Point(409, 184);
            this.pbxEquipamento.Name = "pbxEquipamento";
            this.pbxEquipamento.Size = new System.Drawing.Size(137, 134);
            this.pbxEquipamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEquipamento.TabIndex = 17;
            this.pbxEquipamento.TabStop = false;
            // 
            // pbxExame
            // 
            this.pbxExame.Image = global::appCardiologia.Properties.Resources.exame;
            this.pbxExame.Location = new System.Drawing.Point(229, 184);
            this.pbxExame.Name = "pbxExame";
            this.pbxExame.Size = new System.Drawing.Size(137, 134);
            this.pbxExame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxExame.TabIndex = 16;
            this.pbxExame.TabStop = false;
            // 
            // pbxMedico
            // 
            this.pbxMedico.Image = global::appCardiologia.Properties.Resources.medico;
            this.pbxMedico.Location = new System.Drawing.Point(47, 184);
            this.pbxMedico.Name = "pbxMedico";
            this.pbxMedico.Size = new System.Drawing.Size(137, 134);
            this.pbxMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxMedico.TabIndex = 14;
            this.pbxMedico.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(644, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sair";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(44, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(686, 85);
            this.label5.TabIndex = 23;
            this.label5.Text = "CARDIOLOGIA MGA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxEquipamento);
            this.Controls.Add(this.pbxExame);
            this.Controls.Add(this.pbxMedico);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEquipamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMedico;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbxExame;
        private System.Windows.Forms.PictureBox pbxEquipamento;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem residenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

