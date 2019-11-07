using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPoo.Negocio
{
    class ItensEmprestimo
    {
        private DateTime dtEmprestimo;
        private int id;
        private double valorTotal;
        private Emprestimo emprestimo;
        private Livro livro;


        public DateTime DtEmprestimo{ get { return dtEmprestimo; } set { dtEmprestimo = value; }

        }
        public int Id { get {return id; } set { id = value; } }
        public double ValorTotal { get { return valorTotal; } set { valorTotal = value; } }
        public Emprestimo Emprestimo { get { return emprestimo; } set { emprestimo = value; } }
        public Livro Livro { get { return livro; } set { livro = value; } }
    }
}
