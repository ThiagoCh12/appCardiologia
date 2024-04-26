namespace appCardiologia
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.residenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxEquipamentos = new System.Windows.Forms.PictureBox();
            this.pbxPacientes = new System.Windows.Forms.PictureBox();
            this.pbxExame = new System.Windows.Forms.PictureBox();
            this.pbxMedico = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEquipamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMedicosToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.examesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarMedicosToolStripMenuItem
            // 
            this.cadastrarMedicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicoToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.residenteToolStripMenuItem});
            this.cadastrarMedicosToolStripMenuItem.Name = "cadastrarMedicosToolStripMenuItem";
            this.cadastrarMedicosToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.cadastrarMedicosToolStripMenuItem.Text = "Cadastrar medicos";
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medicoToolStripMenuItem.Text = "Medico";
            this.medicoToolStripMenuItem.Click += new System.EventHandler(this.medicoToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.docenteToolStripMenuItem.Text = "Docente";
            this.docenteToolStripMenuItem.Click += new System.EventHandler(this.docenteToolStripMenuItem_Click);
            // 
            // residenteToolStripMenuItem
            // 
            this.residenteToolStripMenuItem.Name = "residenteToolStripMenuItem";
            this.residenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.residenteToolStripMenuItem.Text = "Residente";
            this.residenteToolStripMenuItem.Click += new System.EventHandler(this.residenteToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // examesToolStripMenuItem
            // 
            this.examesToolStripMenuItem.Name = "examesToolStripMenuItem";
            this.examesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.examesToolStripMenuItem.Text = "Exames";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 85);
            this.label1.TabIndex = 5;
            this.label1.Text = "CARDIOLOGIA MGA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Medico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Exame";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pacientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Equipamentos";
            // 
            // pbxEquipamentos
            // 
            this.pbxEquipamentos.Image = global::appCardiologia.Properties.Resources.equipamento;
            this.pbxEquipamentos.Location = new System.Drawing.Point(612, 211);
            this.pbxEquipamentos.Name = "pbxEquipamentos";
            this.pbxEquipamentos.Size = new System.Drawing.Size(147, 133);
            this.pbxEquipamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEquipamentos.TabIndex = 4;
            this.pbxEquipamentos.TabStop = false;
            // 
            // pbxPacientes
            // 
            this.pbxPacientes.Image = global::appCardiologia.Properties.Resources.paciente;
            this.pbxPacientes.Location = new System.Drawing.Point(421, 211);
            this.pbxPacientes.Name = "pbxPacientes";
            this.pbxPacientes.Size = new System.Drawing.Size(150, 133);
            this.pbxPacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPacientes.TabIndex = 3;
            this.pbxPacientes.TabStop = false;
            // 
            // pbxExame
            // 
            this.pbxExame.Image = global::appCardiologia.Properties.Resources.exame;
            this.pbxExame.Location = new System.Drawing.Point(227, 211);
            this.pbxExame.Name = "pbxExame";
            this.pbxExame.Size = new System.Drawing.Size(149, 133);
            this.pbxExame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxExame.TabIndex = 2;
            this.pbxExame.TabStop = false;
            // 
            // pbxMedico
            // 
            this.pbxMedico.Image = global::appCardiologia.Properties.Resources.medico;
            this.pbxMedico.Location = new System.Drawing.Point(30, 211);
            this.pbxMedico.Name = "pbxMedico";
            this.pbxMedico.Size = new System.Drawing.Size(149, 133);
            this.pbxMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxMedico.TabIndex = 0;
            this.pbxMedico.TabStop = false;
            this.pbxMedico.Click += new System.EventHandler(this.pbxMedico_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxEquipamentos);
            this.Controls.Add(this.pbxPacientes);
            this.Controls.Add(this.pbxExame);
            this.Controls.Add(this.pbxMedico);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEquipamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMedico;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem residenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxExame;
        private System.Windows.Forms.PictureBox pbxPacientes;
        private System.Windows.Forms.PictureBox pbxEquipamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}