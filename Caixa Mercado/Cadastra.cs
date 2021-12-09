using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Mercado
{
    public partial class Cadastra : Form
    {
        public Cadastra()
        {
            InitializeComponent();
        }

        private void Cadastra_Load(object sender, EventArgs e)
        {

        }

        private void Cadastra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { MessageBox.Show("ok"); }
        }
    }
}
