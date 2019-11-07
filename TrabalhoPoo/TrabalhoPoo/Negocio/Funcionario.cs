using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPoo.Formulario;
using TrabalhoPoo.Negocio;

namespace TrabalhoPoo.Negocio
{
    class Funcionario:Pessoa
    {
        private string cargo;
        private DateTime dataAdmissao;
        private string matricula;
        private string pis;
        private double salario;
        private List<Emprestimo> emprestimo;
       
        public string Cargo { get { return cargo; } set { cargo = value; } }
        public DateTime DataAdmissao { get { return dataAdmissao; } set { dataAdmissao = value; } }
        public string Mtricula { get { return matricula; } set { matricula = value; } }
        public string Pis { get { return pis; } set { pis = value; } }
        public double Salario { get { return salario; } set { salario = value; } }
        public List<Emprestimo> Emprestimo { get { return emprestimo; } set { emprestimo = value; } }
    }
}
