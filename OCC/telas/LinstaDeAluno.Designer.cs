namespace OCC.telas
{
    partial class LinstaDeAluno
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
            this.dataGrid_lista_aluno = new System.Windows.Forms.DataGridView();
            this.group_lista_aluno = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_lista_aluno)).BeginInit();
            this.group_lista_aluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_lista_aluno
            // 
            this.dataGrid_lista_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_lista_aluno.Location = new System.Drawing.Point(6, 19);
            this.dataGrid_lista_aluno.Name = "dataGrid_lista_aluno";
            this.dataGrid_lista_aluno.Size = new System.Drawing.Size(706, 107);
            this.dataGrid_lista_aluno.TabIndex = 0;
            // 
            // group_lista_aluno
            // 
            this.group_lista_aluno.Controls.Add(this.dataGrid_lista_aluno);
            this.group_lista_aluno.Location = new System.Drawing.Point(40, 196);
            this.group_lista_aluno.Name = "group_lista_aluno";
            this.group_lista_aluno.Size = new System.Drawing.Size(718, 132);
            this.group_lista_aluno.TabIndex = 1;
            this.group_lista_aluno.TabStop = false;
            this.group_lista_aluno.Text = "Lista de Aluno:";
            // 
            // LinstaDeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 340);
            this.Controls.Add(this.group_lista_aluno);
            this.Name = "LinstaDeAluno";
            this.Text = "Lista de Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_lista_aluno)).EndInit();
            this.group_lista_aluno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_lista_aluno;
        private System.Windows.Forms.GroupBox group_lista_aluno;
    }
}