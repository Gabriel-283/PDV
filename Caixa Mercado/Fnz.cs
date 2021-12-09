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
    public partial class Fnz : Form
    {
        public Fnz()
        {
            InitializeComponent();
        }

        Caixa cmd = new Caixa();
        NotaFiscal nf = new NotaFiscal();
        double total = 0;
        double recebido;
        double troco;
        


       

        public Fnz(double total)
        {
            InitializeComponent();
            this.total = total;
            lb_Total.Text = total.ToString("C");
            nf.Total = total;
            
        }
        public void button1_Click(object sender, EventArgs e)
        {
            pn_Troco.Visible = true;
            txtb_recebido.Focus();
            txtb_recebido.Select();
            lb_recebido.Text = "Recebido";
            lb_Troco.Text = "Troco";
            nf.Pagamento = "dinheiro";
            txtb_recebido.Clear();
        }



        private void txtb_recebido_KeyUp(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Escape)
            {
                pn_Troco.Visible = false;
                btn_Dinheiro.Focus();
                this.recebido = 0;
                this.troco = 0;
               
            }

            if (e.KeyCode == Keys.Enter)
            {
                double recebido = Convert.ToDouble(txtb_recebido.Text);
                double total = Convert.ToDouble(lb_Total.Text);
                double troco = recebido - total;
                lb_trc.Text = Convert.ToString(troco);
                nf.Total = total;
                this.recebido = recebido;
                this.troco = troco;
            }



        }

        private void button2_Click(object sender, KeyEventArgs e)
        {
            nf.Pagamento = "Débito";
            pn_Troco.Visible = true;
            lb_recebido.Text = "Valor a ser Debitado";
            lb_Troco.Visible = true;
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nf.Pagamento = "Débito";
            pn_Troco.Visible = true;
            lb_recebido.Text = "Valor a ser Debitado";
            lb_Troco.Visible = false;
            lb_Total.Visible = true;
            txtb_recebido.Text = lb_Total.Text;

        }

        private void txtb_recebido_TextChanged(object sender, EventArgs e)
        {

        }

        private void pn_Finaliza_Load(object sender, EventArgs e)
        {

        }

        private void pn_Troco_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Dinheiro_Click(object sender, EventArgs e)
        {
            pn_Troco.Visible = true;
            txtb_recebido.Focus();
            txtb_recebido.Select();
            lb_recebido.Text = "Recebido";
            lb_Troco.Text = "Troco";
            nf.Pagamento = "dinheiro";
            txtb_recebido.Clear();
        }

        private void txtb_recebido_KeyUp_1(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Escape)
            {
                pn_Troco.Visible = false;
                btn_Dinheiro.Focus();
                this.recebido = 0;
                this.troco = 0;
                
            }

            if (e.KeyCode == Keys.Enter)
            {
                    double recebido = Convert.ToDouble(txtb_recebido.Text);
                    double total = this.total;
                    double troco = recebido - total;
                    

                if (recebido < total)
                {
                    double Valor_Restante = Math.Abs(troco);
                    MessageBox.Show("valor inserido, é menor que o necessário, favor complementar com minimo de R$" + Valor_Restante);
                    recebido = 0;
                    troco = 0;
                    txtb_recebido.Clear();
                    txtb_recebido.Select();

                }
                else
                {
                    lb_trc.Text = troco.ToString();
                    nf.Total = total;
                    this.recebido = recebido;
                    this.troco = troco;
                }
                

           
               
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            nf.Pagamento = "Débito";
            lb_recebido.Text = "Valor da compra";
            pn_Troco.Visible = true;
            lb_Troco.Visible = false;
            lb_Total.Visible = true;
            txtb_recebido.Text = lb_Total.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nf.Pagamento = "Crédito";
            lb_Troco.Text = "Parcelas";
            lb_recebido.Text = "Valor da compra";
            lb_Troco.Visible = true;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.troco != 0)
            {
                nf.Troco = this.troco;
                cmd.pn_fnz.Visible = false;
                
            }
            else 
            {
                nf.Troco = 0;
            }
            nf.Total = this.total;
            cmd.pn_fnz.Visible = false;
          
            cmd.txtb_CodBarras.Select(); 
        }

        private void Fnz_Load(object sender, EventArgs e)
        {

        }

        private void txtb_recebido_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
