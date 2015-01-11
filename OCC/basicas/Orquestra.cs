using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC.basicas
{
    class Orquestra
    {
        private int idOrquestra;
        private int codigo;
        private string nome;
        private string dataCriacao;
        private string nomeMaestro;
        private int qtdMusicos;

        public Orquestra(int codigo, string nome, string dataCriacao, string nomeMaestro,int quantidadeMusicos)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.dataCriacao = dataCriacao;
            this.nomeMaestro = nomeMaestro;
            this.qtdMusicos = quantidadeMusicos;
        }

        public Orquestra(){}
        
        public int IdOrquestra
        {
            get { return this.idOrquestra; }
            set { this.idOrquestra = value; }
        }

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public string DataCriacao
        {
            get { return this.dataCriacao; }
            set { this.dataCriacao = value; }
        }
        public string NomeMaestro
        {
            get { return this.nomeMaestro; }
            set { this.nomeMaestro = value; }
        }
        public int QuantidadeMusicos
        {
            get { return this.qtdMusicos; }
            set { this.qtdMusicos = value; }
        }
    }
}
