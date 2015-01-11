namespace OCC.telas
{
    partial class Princinpal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_manterOrquestra = new System.Windows.Forms.Button();
            this.btn_manter_funcionario = new System.Windows.Forms.Button();
            this.btn_chamar_manter_aluno = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConcultas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConcultas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_manterOrquestra);
            this.panel1.Controls.Add(this.btn_manter_funcionario);
            this.panel1.Controls.Add(this.btn_chamar_manter_aluno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 376);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_manterOrquestra
            // 
            this.btn_manterOrquestra.Image = global::OCC.Properties.Resources.img_funcionario;
            this.btn_manterOrquestra.Location = new System.Drawing.Point(12, 210);
            this.btn_manterOrquestra.Name = "btn_manterOrquestra";
            this.btn_manterOrquestra.Size = new System.Drawing.Size(78, 78);
            this.btn_manterOrquestra.TabIndex = 2;
            this.btn_manterOrquestra.Text = "btn_manterOrquestra";
            this.btn_manterOrquestra.UseVisualStyleBackColor = true;
            this.btn_manterOrquestra.Click += new System.EventHandler(this.btn_manterOrquestra_Click);
            // 
            // btn_manter_funcionario
            // 
            this.btn_manter_funcionario.Image = global::OCC.Properties.Resources.img_professor;
            this.btn_manter_funcionario.Location = new System.Drawing.Point(12, 111);
            this.btn_manter_funcionario.Name = "btn_manter_funcionario";
            this.btn_manter_funcionario.Size = new System.Drawing.Size(78, 78);
            this.btn_manter_funcionario.TabIndex = 1;
            this.btn_manter_funcionario.Text = "button1";
            this.btn_manter_funcionario.UseVisualStyleBackColor = true;
            this.btn_manter_funcionario.Click += new System.EventHandler(this.btn_manter_funcionario_Click);
            // 
            // btn_chamar_manter_aluno
            // 
            this.btn_chamar_manter_aluno.Image = global::OCC.Properties.Resources.img_aluno;
            this.btn_chamar_manter_aluno.Location = new System.Drawing.Point(12, 12);
            this.btn_chamar_manter_aluno.Name = "btn_chamar_manter_aluno";
            this.btn_chamar_manter_aluno.Size = new System.Drawing.Size(78, 78);
            this.btn_chamar_manter_aluno.TabIndex = 0;
            this.btn_chamar_manter_aluno.Text = "Button";
            this.btn_chamar_manter_aluno.Click += new System.EventHandler(this.btn_chamar_manter_aluno_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.consultarAlunoToolStripMenuItem,
            this.consultarFuncionarioToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // consultarAlunoToolStripMenuItem
            // 
            this.consultarAlunoToolStripMenuItem.Name = "consultarAlunoToolStripMenuItem";
            this.consultarAlunoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarAlunoToolStripMenuItem.Text = "Consultar Aluno";
            // 
            // consultarFuncionarioToolStripMenuItem
            // 
            this.consultarFuncionarioToolStripMenuItem.Name = "consultarFuncionarioToolStripMenuItem";
            this.consultarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarFuncionarioToolStripMenuItem.Text = "Consultar Funcionario";
            // 
            // btnConcultas
            // 
            this.btnConcultas.Location = new System.Drawing.Point(13, 306);
            this.btnConcultas.Name = "btnConcultas";
            this.btnConcultas.Size = new System.Drawing.Size(75, 23);
            this.btnConcultas.TabIndex = 4;
            this.btnConcultas.Text = "Consultas";
            this.btnConcultas.UseVisualStyleBackColor = true;
            this.btnConcultas.Click += new System.EventHandler(this.btnConcultas_Click);
            // 
            // Princinpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Princinpal";
            this.Text = "Princinpal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_chamar_manter_aluno;
        private System.Windows.Forms.Button btn_manter_funcionario;
        private System.Windows.Forms.Button btn_manterOrquestra;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConcultas;
    }
}