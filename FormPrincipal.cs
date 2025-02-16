using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btncli_Click(object sender, EventArgs e)
        {
            new Formcliente().Show();
        }

        private void btnmarca_Click(object sender, EventArgs e)
        {
            new Formmarca().Show();
        }

        private void btnfunc_Click(object sender, EventArgs e)
        {
          new Formfuncionario().Show();
        }

        private void btnmodelo_Click(object sender, EventArgs e)
        {
            new Formmodelo().Show();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            new Formcargo().Show();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
          new FormLocacao().Show();
        }

        private void btnauto_Click(object sender, EventArgs e)
        {
            new Formautomovel().Show();
        }

        private void btnviz_Click(object sender, EventArgs e)
        {
            new Formgerenciamentogeral().Show();
        }
    }
}
