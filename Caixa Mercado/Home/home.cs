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
    public partial class home : Form
    {
        
        Form formaberto;

        private void abre(Form frm)
        {
            //fecha(frm);
            formaberto = frm;
            frm.TopLevel = false;
            Painel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();


        }

        private void fecha(Form frm) 
        {
            if (frm != null)
                frm.Close();
        }

        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_caixa_Click(object sender, EventArgs e)
        {
            abre( new Caixa());
          
        }

        private void Calc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btn_Produto_Click(object sender, EventArgs e)
        {

            abre(new lst_Produto());
                
        }

        private void Cadastra_Click(object sender, EventArgs e)
        {
            abre(new Cadastra());
        }

   

        private void home_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { MessageBox.Show("ok"); }
        }

        private void Painel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
