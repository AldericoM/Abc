using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC.basicas
{
    class Responsavel : Pessoa
    {        
        private int idResponsavel;
        private string descricao;
        private string observacaoResponsavel;

        public Responsavel(string descricao, string observacaoResponsavel)
        {        
            this.descricao = descricao;
            this.observacaoResponsavel = observacaoResponsavel;
        }

        public Responsavel() { }

        public int IdResponsavel
        {
            get { return this.idResponsavel; }
            set { this.idResponsavel = value; }
        }

        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        public string ObservacaoResponsavel
        {
            get { return this.observacaoResponsavel; }
            set { this.observacaoResponsavel = value; }
        }
    }
}
