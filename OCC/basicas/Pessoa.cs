using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC.basicas
{
    class Pessoa
    {
        private int idPessoa;
        private int codigo;
        private string nome;
        private int idEnderecoPessoa;
        private string tipoPessoa;
        private string sexo;
        private int rg;
        private int cpf;
        private string estadoCivil;
        private int idade;        
        private string situacao;
        private int telefone;
        private int celular;
        private int whatsapp;
        private string email;
        private string redeSocial;
        private string dataCadastro;
        private string dataNascimento;
        private string observacaoPessoa;

        public Pessoa(int codigo, string nome, int idEndereco, string tipoPessoa, string sexo, int rg, int cpf,
            string estadoCivil, int idade, int telefone, int celular, int whatsapp,
            string email, string redeSocial, string dataCadastro, string dataNascimento, string observacaoPessoa)
        {
            this.codigo = codigo; this.idEnderecoPessoa = idEndereco; this.tipoPessoa = tipoPessoa; this.sexo = sexo; this.nome = nome;
            this.rg = rg; this.cpf = cpf; this.estadoCivil = estadoCivil; this.idade = idade; 
            this.telefone = telefone; this.celular = celular; this.whatsapp = whatsapp;
            this.email = email; this.redeSocial = redeSocial; this.dataCadastro = dataCadastro; this.dataNascimento = dataNascimento;
            this.observacaoPessoa = observacaoPessoa;
        }
        public string ObservacaoPessoa
        {
            get { return this.observacaoPessoa; }
            set { this.observacaoPessoa = value; }
        }
        public Pessoa() { }

        public string TipoPessoa
        {
            get { return this.tipoPessoa; }
            set { this.tipoPessoa = value; }
        }

        public string TipoSexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }
        public string DataNascimento
        {
            get { return this.dataNascimento; }
            set { this.dataNascimento = value; }
        }
        public string DataCadastro
        {
            get { return this.dataCadastro; }
            set { this.dataCadastro = value; }
        }
        public string RedeSocial
        {
            get { return this.redeSocial; }
            set { this.redeSocial = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public int Whatsapp
        {
            get { return this.whatsapp; }
            set { this.whatsapp = value; }
        }
        public int Celular
        {
            get { return this.celular; }
            set { this.celular = value; }
        }
        public int Telefone
        {
            get { return this.telefone; }
            set { this.telefone = value; }
        }
        public string Situacao
        {
            get { return this.situacao; }
            set { this.situacao = value; }
        }
        
        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }
        public string EstadoCivil
        {
            get { return this.estadoCivil; }
            set { this.estadoCivil = value; }
        }
        public int Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }
        public int Rg
        {
            get { return this.rg; }
            set { this.rg = value; }
        }        
        public int IdPessoa
        {
            get { return this.idPessoa; }
            set { this.idPessoa = value; }
        }
        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public int IdEnderecoPessoa
        {
            get { return this.idEnderecoPessoa; }
            set { this.idEnderecoPessoa = value; }
        }
        
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
    
    }
}
