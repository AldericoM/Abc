using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC.basicas
{
    class Endereco
    {
        private int idEndereco;
        private string rua;
        private int numero;
        private string bairro;
        private int cep;
        private string cidade;
        private string estado;

        public Endereco(string rua, int numero, string bairro, int cep, string cidade, string estado)
        {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
        }

        public Endereco() { }

        public int IdEndereco
        {
            get { return this.idEndereco; }
            set { this.idEndereco = value; }
        }
        public string Rua
        {
            get { return this.rua; }
            set { this.rua = value; }
        }
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public string Bairro
        {
            get { return this.bairro; }
            set { this.bairro = value; }
        }
        public int Cep
        {
            get { return this.cep; }
            set { this.cep = value; }
        }
        public string Cidade
        {
            get { return this.cidade; }
            set { this.cidade = value; }
        }
        public string Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
    }
}
