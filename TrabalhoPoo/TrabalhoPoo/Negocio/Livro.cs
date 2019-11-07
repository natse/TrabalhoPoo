using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPoo.Formulario;
using TrabalhoPoo.Negocio;

namespace TrabalhoPoo.Negocio
{
    class Livro
    {
        private string autor;
        private DateTime dtPublicacao;
        private string editora;
        private int id;
        private string titulo;
        private List<ItensEmprestimo> itensEmprestimo;

        public string Autor { get { return autor; } set { autor = value; } }
        public DateTime DtPublicacao {get { return dtPublicacao; } set {dtPublicacao = value; } }
        public string Editora { get { return editora; } set { editora = value; } }
        public int Id{ get { return id; } set { id = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public List<ItensEmprestimo> ItensEmprestimo { get { return itensEmprestimo; } set { itensEmprestimo = value; } }
    }
}
