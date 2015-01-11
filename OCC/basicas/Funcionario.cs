using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC.basicas
{
    class Funcionario : Pessoa
    {
        private string funcao;
        private int numeroMatricula;
        private string descricaoFuncao;
        private string dataAdmissao;
        private int numeroCarteiraTrabalho;
        private int serieCarteiraTrabalho;


        public Funcionario(string funcao, int numeroMatricula, string descricaoFuncao, string dataAdmissao, int numeroCarteiraTrabalho, int serieCarteiraTrabalho)
        {
            this.funcao = funcao;
            this.numeroMatricula = numeroMatricula;
            this.descricaoFuncao = descricaoFuncao;
            this.dataAdmissao = dataAdmissao;
            this.serieCarteiraTrabalho = serieCarteiraTrabalho;
        }
        public int SerieCarteiraTrabalho
        {
            get { return this.serieCarteiraTrabalho; }
            set { this.serieCarteiraTrabalho = value; }
        }

        public int NumeroMatricula
        {
            get { return this.numeroMatricula; }
            set { this.numeroMatricula = value; }
        }

        public int NumeroCarteiraTrabalho
        {
            get { return this.numeroCarteiraTrabalho; }
            set { this.numeroCarteiraTrabalho = value; }
        }
        
        public string Funcao
        {
            get { return this.funcao; }
            set { this.funcao = value; }
        }
        public string DescricaoFuncao
        {
            get { return this.descricaoFuncao; }
            set { this.descricaoFuncao = value; }
        }
        public string DataAdmissoa
        {
            get { return this.dataAdmissao; }
            set { this.dataAdmissao = value; }
        }
    }
}
