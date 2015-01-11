using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC.basicas
{
    class Turma
    {
        private int idTurma;
        private int codigo;
        private string nome;

        public int IdTurma
        {
            get { return this.idTurma; }
            set { this.idTurma = value; }
        }
        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public string NomeTurma
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
    }
}
