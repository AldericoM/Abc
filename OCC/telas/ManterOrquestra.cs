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


namespace OCC.telas
{
    public partial class ManterOrquestra : Form
    {
        public ManterOrquestra()
        {
            InitializeComponent();
            combo_turma_orquestra.DataSource = Enum.GetValues(typeof(e_num.EnumTurma));
        }

        private void ManterOrquestra_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Princinpal)this.MdiParent).formOrquestra = 0;
        }
    }
}
