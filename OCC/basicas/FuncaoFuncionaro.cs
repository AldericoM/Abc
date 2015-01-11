using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC.basicas
{
    class FuncaoFuncionaro
    {
        int idFuncao;
        private string nomeFuncao;

        public FuncaoFuncionaro(string nomeFuncao)
        {
            this.nomeFuncao = nomeFuncao;
        }

        public FuncaoFuncionaro() { }

        public int IdFuncionario
        {
            get { return this.idFuncao; }
            set { this.idFuncao = value; }
        }
        public string NomeFuncao
        {
            get { return this.nomeFuncao; }
            set { this.nomeFuncao = value; }
        }
    }
}
