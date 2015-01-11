namespace OCC.telas
{
    partial class ManterOrquestra
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
            this.lbl_nome_orquestra = new System.Windows.Forms.Label();
            this.txt_nome_orquestra = new System.Windows.Forms.TextBox();
            this.lbl_codigo_orquestra = new System.Windows.Forms.Label();
            this.txt_codigo_orquestra = new System.Windows.Forms.TextBox();
            this.lbl_nome_maestro = new System.Windows.Forms.Label();
            this.combo_nome_maestro = new System.Windows.Forms.ComboBox();
            this.masked_data_criacao = new System.Windows.Forms.MaskedTextBox();
            this.lbl_data_criacao = new System.Windows.Forms.Label();
            this.lbl_quantidade_musicos = new System.Windows.Forms.Label();
            this.txt_quantidade_musicos = new System.Windows.Forms.TextBox();
            this.group_manter_orquestra = new System.Windows.Forms.GroupBox();
            this.group_lista_orquestra = new System.Windows.Forms.GroupBox();
            this.dataGrid_lista_orquestra = new System.Windows.Forms.DataGridView();
            this.combo_turma_orquestra = new System.Windows.Forms.ComboBox();
            this.lbl_turma_orquestra = new System.Windows.Forms.Label();
            this.group_manter_orquestra.SuspendLayout();
            this.group_lista_orquestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_lista_orquestra)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome_orquestra
            // 
            this.lbl_nome_orquestra.AutoSize = true;
            this.lbl_nome_orquestra.Location = new System.Drawing.Point(73, 22);
            this.lbl_nome_orquestra.Name = "lbl_nome_orquestra";
            this.lbl_nome_orquestra.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome_orquestra.TabIndex = 0;
            this.lbl_nome_orquestra.Text = "Nome:";
            // 
            // txt_nome_orquestra
            // 
            this.txt_nome_orquestra.Location = new System.Drawing.Point(113, 19);
            this.txt_nome_orquestra.Name = "txt_nome_orquestra";
            this.txt_nome_orquestra.Size = new System.Drawing.Size(355, 20);
            this.txt_nome_orquestra.TabIndex = 1;
            // 
            // lbl_codigo_orquestra
            // 
            this.lbl_codigo_orquestra.AutoSize = true;
            this.lbl_codigo_orquestra.Location = new System.Drawing.Point(300, 50);
            this.lbl_codigo_orquestra.Name = "lbl_codigo_orquestra";
            this.lbl_codigo_orquestra.Size = new System.Drawing.Size(43, 13);
            this.lbl_codigo_orquestra.TabIndex = 2;
            this.lbl_codigo_orquestra.Text = "Código:";
            // 
            // txt_codigo_orquestra
            // 
            this.txt_codigo_orquestra.Location = new System.Drawing.Point(345, 47);
            this.txt_codigo_orquestra.Name = "txt_codigo_orquestra";
            this.txt_codigo_orquestra.Size = new System.Drawing.Size(123, 20);
            this.txt_codigo_orquestra.TabIndex = 3;
            // 
            // lbl_nome_maestro
            // 
            this.lbl_nome_maestro.AutoSize = true;
            this.lbl_nome_maestro.Location = new System.Drawing.Point(32, 51);
            this.lbl_nome_maestro.Name = "lbl_nome_maestro";
            this.lbl_nome_maestro.Size = new System.Drawing.Size(79, 13);
            this.lbl_nome_maestro.TabIndex = 4;
            this.lbl_nome_maestro.Text = "Nome Maestro:";
            // 
            // combo_nome_maestro
            // 
            this.combo_nome_maestro.FormattingEnabled = true;
            this.combo_nome_maestro.Location = new System.Drawing.Point(113, 47);
            this.combo_nome_maestro.Name = "combo_nome_maestro";
            this.combo_nome_maestro.Size = new System.Drawing.Size(121, 21);
            this.combo_nome_maestro.TabIndex = 5;
            // 
            // masked_data_criacao
            // 
            this.masked_data_criacao.Location = new System.Drawing.Point(113, 76);
            this.masked_data_criacao.Mask = "00/00/0000";
            this.masked_data_criacao.Name = "masked_data_criacao";
            this.masked_data_criacao.Size = new System.Drawing.Size(80, 20);
            this.masked_data_criacao.TabIndex = 6;
            // 
            // lbl_data_criacao
            // 
            this.lbl_data_criacao.AutoSize = true;
            this.lbl_data_criacao.Location = new System.Drawing.Point(24, 81);
            this.lbl_data_criacao.Name = "lbl_data_criacao";
            this.lbl_data_criacao.Size = new System.Drawing.Size(87, 13);
            this.lbl_data_criacao.TabIndex = 7;
            this.lbl_data_criacao.Text = "Data de Criação:";
            // 
            // lbl_quantidade_musicos
            // 
            this.lbl_quantidade_musicos.AutoSize = true;
            this.lbl_quantidade_musicos.Location = new System.Drawing.Point(221, 81);
            this.lbl_quantidade_musicos.Name = "lbl_quantidade_musicos";
            this.lbl_quantidade_musicos.Size = new System.Drawing.Size(122, 13);
            this.lbl_quantidade_musicos.TabIndex = 8;
            this.lbl_quantidade_musicos.Text = "Quantidade de Músicos:";
            // 
            // txt_quantidade_musicos
            // 
            this.txt_quantidade_musicos.Location = new System.Drawing.Point(345, 78);
            this.txt_quantidade_musicos.Name = "txt_quantidade_musicos";
            this.txt_quantidade_musicos.Size = new System.Drawing.Size(123, 20);
            this.txt_quantidade_musicos.TabIndex = 9;
            // 
            // group_manter_orquestra
            // 
            this.group_manter_orquestra.Controls.Add(this.group_lista_orquestra);
            this.group_manter_orquestra.Controls.Add(this.combo_turma_orquestra);
            this.group_manter_orquestra.Controls.Add(this.lbl_turma_orquestra);
            this.group_manter_orquestra.Controls.Add(this.txt_nome_orquestra);
            this.group_manter_orquestra.Controls.Add(this.txt_quantidade_musicos);
            this.group_manter_orquestra.Controls.Add(this.lbl_nome_orquestra);
            this.group_manter_orquestra.Controls.Add(this.lbl_quantidade_musicos);
            this.group_manter_orquestra.Controls.Add(this.lbl_codigo_orquestra);
            this.group_manter_orquestra.Controls.Add(this.lbl_data_criacao);
            this.group_manter_orquestra.Controls.Add(this.txt_codigo_orquestra);
            this.group_manter_orquestra.Controls.Add(this.masked_data_criacao);
            this.group_manter_orquestra.Controls.Add(this.lbl_nome_maestro);
            this.group_manter_orquestra.Controls.Add(this.combo_nome_maestro);
            this.group_manter_orquestra.Location = new System.Drawing.Point(12, 12);
            this.group_manter_orquestra.Name = "group_manter_orquestra";
            this.group_manter_orquestra.Size = new System.Drawing.Size(651, 367);
            this.group_manter_orquestra.TabIndex = 10;
            this.group_manter_orquestra.TabStop = false;
            this.group_manter_orquestra.Text = "Orquestra:";
            // 
            // group_lista_orquestra
            // 
            this.group_lista_orquestra.Controls.Add(this.dataGrid_lista_orquestra);
            this.group_lista_orquestra.Location = new System.Drawing.Point(6, 169);
            this.group_lista_orquestra.Name = "group_lista_orquestra";
            this.group_lista_orquestra.Size = new System.Drawing.Size(639, 192);
            this.group_lista_orquestra.TabIndex = 13;
            this.group_lista_orquestra.TabStop = false;
            this.group_lista_orquestra.Text = "Lista de Orquestras:";
            // 
            // dataGrid_lista_orquestra
            // 
            this.dataGrid_lista_orquestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_lista_orquestra.Location = new System.Drawing.Point(6, 19);
            this.dataGrid_lista_orquestra.Name = "dataGrid_lista_orquestra";
            this.dataGrid_lista_orquestra.Size = new System.Drawing.Size(627, 167);
            this.dataGrid_lista_orquestra.TabIndex = 12;
            // 
            // combo_turma_orquestra
            // 
            this.combo_turma_orquestra.FormattingEnabled = true;
            this.combo_turma_orquestra.Location = new System.Drawing.Point(113, 104);
            this.combo_turma_orquestra.Name = "combo_turma_orquestra";
            this.combo_turma_orquestra.Size = new System.Drawing.Size(80, 21);
            this.combo_turma_orquestra.TabIndex = 11;
            // 
            // lbl_turma_orquestra
            // 
            this.lbl_turma_orquestra.AutoSize = true;
            this.lbl_turma_orquestra.Location = new System.Drawing.Point(2, 108);
            this.lbl_turma_orquestra.Name = "lbl_turma_orquestra";
            this.lbl_turma_orquestra.Size = new System.Drawing.Size(109, 13);
            this.lbl_turma_orquestra.TabIndex = 10;
            this.lbl_turma_orquestra.Text = "Turmas da Orquestra:";
            // 
            // ManterOrquestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 391);
            this.Controls.Add(this.group_manter_orquestra);
            this.Name = "ManterOrquestra";
            this.Text = "Manter Orquestra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManterOrquestra_FormClosed);
            this.group_manter_orquestra.ResumeLayout(false);
            this.group_manter_orquestra.PerformLayout();
            this.group_lista_orquestra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_lista_orquestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome_orquestra;
        private System.Windows.Forms.TextBox txt_nome_orquestra;
        private System.Windows.Forms.Label lbl_codigo_orquestra;
        private System.Windows.Forms.TextBox txt_codigo_orquestra;
        private System.Windows.Forms.Label lbl_nome_maestro;
        private System.Windows.Forms.ComboBox combo_nome_maestro;
        private System.Windows.Forms.MaskedTextBox masked_data_criacao;
        private System.Windows.Forms.Label lbl_data_criacao;
        private System.Windows.Forms.Label lbl_quantidade_musicos;
        private System.Windows.Forms.TextBox txt_quantidade_musicos;
        private System.Windows.Forms.GroupBox group_manter_orquestra;
        private System.Windows.Forms.Label lbl_turma_orquestra;
        private System.Windows.Forms.ComboBox combo_turma_orquestra;
        private System.Windows.Forms.GroupBox group_lista_orquestra;
        private System.Windows.Forms.DataGridView dataGrid_lista_orquestra;
    }
}