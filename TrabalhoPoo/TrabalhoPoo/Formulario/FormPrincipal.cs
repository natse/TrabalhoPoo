using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPoo.Formulario;
using TrabalhoPoo.Negocio;

namespace TrabalhoPoo.Formulario
{
    public partial class MeniStripPrincipal : Form
    {
        public MeniStripPrincipal()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlunoRua form = new FormAlunoRua();
            form.MdiParent = this;
            form.Show();

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionario form = new FormFuncionario();
            form.MdiParent = this;
            form.Show();
        }
    }
}
