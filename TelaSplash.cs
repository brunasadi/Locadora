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
    public partial class TelaSplash : Form
    {
        public TelaSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                //se o valor da barra de progresso for menor que 100 pega o recebe a progress bar +2 e vai carregando
                 
                progressBar1.Value = progressBar1.Value + 2;
            }
            else {
                // nao deixa timer parar de contar
                timer1.Enabled = false;



                 //faz sumir
                this.Visible = false;
                //passa pro proximo form
                new FormPrincipal().Show();
            }
        }   } 
}
