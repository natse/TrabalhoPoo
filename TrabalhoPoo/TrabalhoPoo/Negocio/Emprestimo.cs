using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPoo.Negocio
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private int id;
        private double valorTotal;
        private Funcionario funcionario;
        private Aluno aluno;
        public Funcionario Funcionario { get { return funcionario; } set { funcionario = value; } }
        public DateTime DtEmprestimo { get { return dtEmprestimo; } set { dtEmprestimo = value; } }
        public int Id { get { return id; } set { id = value; } }
        public double ValorTotal{ get { return valorTotal; } set { valorTotal = value; } }
        public Aluno Aluno { get { return aluno; } set { aluno = value; } }
    }
}
