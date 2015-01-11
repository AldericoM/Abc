using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC.basicas
{
    class Aluno : Pessoa
    {
        private int idAluno;
        private int idPessoa;
        private int idOrquestra;
        private int  idResponsavel;
        private int idTurma;
        private string instrumento;
        private string maestro;
        private string maestro_assistente;
        private string turno;        
        private double peso;
        private int tamanhoSapato;
        private string tamanhoCamisa;
        private int tamanhoCalsa;
        private string observacoaAluno;
        

        public Aluno(int idPessoa, int idOrquestra, int idResponsavel, int idTurma, 
                     string instrumento, string maestro, string maestro_assistente,
                     string turno, double peso, int tamanhoSapato, string tamanhoCamisa,
                     int tamanhoCalsa, string observacoaAluno)
        {
            this.idPessoa = idPessoa;
            this.idOrquestra = idOrquestra; this.idResponsavel = idResponsavel; this.idTurma = idTurma;
            this.instrumento = instrumento; this.maestro = maestro; this.maestro_assistente = maestro_assistente;
            this.turno = turno; this.peso = peso; this.tamanhoSapato = tamanhoSapato;
            this.tamanhoCamisa = tamanhoCamisa; this.tamanhoCalsa = tamanhoCalsa; this.observacoaAluno = observacoaAluno;            
        }

        public Aluno() { }

        public int IdPessoa
        {
            get { return this.idPessoa; }
            set { this.idPessoa = value; }
        }

        public int IdTurma
        {
            get { return this.idTurma; }
            set { this.idTurma = value; }
        }

        public int IdResponsavel
        {
            get { return this.idResponsavel; }
            set { this.idResponsavel = value; }
        }

        public int IdOrquestra
        {
            get { return this.idOrquestra; }
            set { this.idOrquestra = value; }
        }

        public int IdAluno
        {
            get { return this.idAluno; }
            set { this.idAluno = value; }
        }

        public string Instrumento
        {
            get { return this.instrumento; }
            set { this.instrumento = value; }
        }
        public string Maestro
        {
            get { return this.maestro; }
            set { this.maestro = value; }
        }
        public string MaestroAssistente
        {
            get { return this.maestro_assistente; }
            set { this.maestro_assistente = value; }
        }
        public string Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }
        public double Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }
        public int TamanhoSapato
        {
            get { return this.tamanhoSapato; }
            set { this.tamanhoSapato = value; }
        }
        public string TamanhoCamisa
        {
            get { return this.tamanhoCamisa; }
            set { this.tamanhoCamisa = value; }
        }
        public int TamanhoCalsa
        {
            get { return this.tamanhoCalsa; }
            set { this.tamanhoCalsa = value; }
        }
        public string ObservacaoAluno
        {
            get { return this.observacoaAluno; }
            set { this.observacoaAluno = value; }
        }
    }
    
}

    


