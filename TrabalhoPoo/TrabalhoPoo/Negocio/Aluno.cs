using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPoo.Negocio
{
    class Aluno:Pessoa
    {
        private string cidade;
        private DateTime dataNacimento;
        private string numero;
        private string orgaoExpedidor;
        private string rg;
        private string rua;
        private string sexo;
        private string uf;
        private List<Emprestimo> emprestimo;
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public DateTime DataNacimento { get { return dataNacimento; } set { dataNacimento = value; } }
        public string Numero { get { return numero; } set { numero = value; } }
        public string OrgaoExpedidor { get { return orgaoExpedidor; } set { orgaoExpedidor = value; } }
        public string Rg { get { return rg; } set { rg = value; } }
        public string Rua { get { return rua; } set { rua = value; } }
        public string Sexo { get { return sexo; } set { sexo = value; } }
        public string Uf { get { return uf; } set { uf = value; } }
        public List<Emprestimo> Emprestimo { get { return emprestimo; } set { emprestimo = value; } }
    }
}
