using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCC.basicas;
using OCC.e_num;

namespace OCC.telas
{
    public partial class ManterAluno : Form
    {
        public ManterAluno()
        {
            InitializeComponent();
            combo_sexo_aluno.DataSource = Enum.GetValues(typeof(TipoSexo));
            combo_turma.DataSource = Enum.GetValues(typeof(EnumTurma));
        }

        private void Manter_aluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Princinpal)this.MdiParent).formAluno = 0;            
        }

        private void btn_salvar_aluno_Click(object sender, EventArgs e)
        {
            dao.Dao_aluno al = new dao.Dao_aluno();            
            string nom2 = combo_tamanhoCamisa.Text;

            //MessageBox.Show(al.inserirAluno());
            
            txt_masck_celular_aluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string celular = txt_masck_celular_aluno.Text;
            MessageBox.Show(celular+"   "+nom2);
        }

    }
}
