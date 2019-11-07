using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabalhoPoo.Negocio
{
    class Pessoa
    {
        private string cpfj;
        private int id;
        private string nome;
        public string Cpfj { get { return cpfj; } set { cpfj = value; } }
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
    }
}
