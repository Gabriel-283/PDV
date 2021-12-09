using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;



namespace Caixa_Mercado
{
    public partial class Caixa : Form
    {

        Form formaberto;
        public double[] conta = new double[76];
        public string[] produto = new string[76];
        public string[] pedido = new string[76];
        string Finaliza = "";
        NotaFiscal nf = new NotaFiscal();
        string forma_pagamento = "";
        double total_compra = 0;
        double recebido;//Dinheiro
        double troco;// dinheiro
        double total = 0;
        int parcela = 0;//crédito
        int x = 0;
        string rmv = "0";
        int remove = 0;
        string qtd = "0";
        int quantidade = 1;



        public Caixa()
        {
            InitializeComponent();
            txtb_CodBarras.Select();

        }
        private void txtb_CodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }
        public void txtb_CodBarras_KeyUp(object sender, KeyEventArgs e)
        {
            comandos(e);

            if (e.KeyCode == Keys.Enter)
            {

                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "SELECT * FROM tbl_produtos WHERE ID_Produto= '" + txtb_CodBarras.Text + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {

                                if (dr.Read())
                                {
                                    x += 1;
                                    conta[x] = Convert.ToDouble(dr["preco"]);
                                    produto[x] = Convert.ToString(dr["Nome_Produto"]);
                                    if (quantidade != 1)
                                    {
                                        conta[x] *= quantidade;

                                    }
                                    total = conta[x];
                                    double numSum = conta.Sum();
                                    double PrecoTotal = Convert.ToDouble(dr["preco"]);
                                    string SubTotal = numSum.ToString();
                                    this.total_compra = Convert.ToDouble(SubTotal);
                                    lbl_PrecoTotalProduto.Text = PrecoTotal.ToString("C");
                                    lb_NomeProduto.Text = Convert.ToString(produto[x]);
                                    lb_PrecoUni.Text = conta[x].ToString("C");
                                    string pretot = numSum.ToString("C");
                                    lb_PrecoTotal.Text = pretot;

                                    pedido[x] =  "       " + produto[x] + "         " + lb_PrecoUni.Text + "         " + quantidade + "               " + lbl_PrecoTotalProduto.Text + "            " + txtb_CodBarras.Text;
                                    
                                    lst_Produtos.Items.Add(x+ pedido[x].PadRight(20));
                                    Finaliza = numSum.ToString("F2");
                                }
                            }
                        }
                    }
                }

                txtb_CodBarras.Clear();
                quantidade = 1;
                qtd = "";
            }

        }
        private void fecha(Form frm)
        {
            if (frm != null)
                frm.Close();

        }
        private void opn(Form frm)
        {
            //fecha(frm);
            formaberto = frm;
            frm.TopLevel = false;
            pn_fnz.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }



        private void lst_Produtos_KeyUp(object sender, KeyEventArgs e)
        {
            comandos(e);
        }
        public void comandos(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                pn_fnz.Visible = false;
                txtb_CodBarras.Focus();
            }

            if (e.KeyCode == Keys.F2)
            {
                label2.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox1.Focus();
            }

            if (e.KeyCode == Keys.F3)
            {
                txtb_Quantidade.BringToFront();
                Quantidade.Visible = true;
                txtb_Quantidade.Visible = true;
                txtb_Quantidade.Focus();
            }
            if (e.KeyCode == Keys.F4)
            {
                lbl_Excluir.Visible = true;
                txtb_Excluir.Visible = true;
                txtb_Excluir.Focus();
            }

            if (e.KeyCode == Keys.F8)
            {
                nf.Pagamento = "Dineiro";
                pn_Troco.Visible = true;

                txtb_Recebido.Select();


            }

            if (e.KeyCode == Keys.F9)
            {
                if (pedido[1] == null)
                {
                    MessageBox.Show("Favor inserir itens ao carrinho");
                    txtb_CodBarras.Select();
                }
                else
                {
                    nf.Pagamento = "Débito";
                    lb_Recebido.Text = "Valor da Compra";
                    txtb_Recebido.Text = this.total_compra.ToString("C");
                    txtb_troco.Clear();
                    lb_Troco.Visible = false;
                    txtb_troco.Visible = false;
                    pn_Troco.Visible = true;
                    txtb_Suporte.Visible = true;
                    txtb_Suporte.Focus();

                }

            }
            if (e.KeyCode == Keys.F10)
            {

                if (pedido[1] == null)
                {
                    MessageBox.Show("Favor inserir itens ao carrinho");
                    txtb_CodBarras.Select();
                }
                else
                {
                    nf.Pagamento = "Crédito";
                    lb_Recebido.Text = "Valor da Compra";
                    txtb_Recebido.Text = this.total_compra.ToString("C");
                    txtb_troco.Clear();
                    lb_Troco.Visible = true;
                    lb_Troco.Text = "Parcelas";
                    txtb_troco.Visible = true;
                    pn_Troco.Visible = true;
                    txtb_Suporte.Visible = true;
                    txtb_troco.Focus();
                }
            }
                if (e.KeyCode == Keys.F11)
            {
                pn_Troco.Visible = false;
                total = 0;
                x = 0;
                rmv = "0";
                remove = 0;
                qtd = "0";
                quantidade = 1;

                for (int x = 0; x <= 76; x++)
                {
                    conta[x] = 0;
                    produto[x] = null;
                    pedido[x] = null;
                }
                lbl_PrecoTotalProduto.Text = null;
                lb_PrecoUni.Text = null;
                lb_PrecoTotal.Text = null;
                lst_Produtos.Items.Clear();
                txtb_CodBarras.Select();

            }
        }



        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.D0 && e.KeyCode != Keys.D1 && e.KeyCode != Keys.D2 && e.KeyCode != Keys.D3 && e.KeyCode != Keys.D4 && e.KeyCode != Keys.D5 && e.KeyCode != Keys.D6 && e.KeyCode != Keys.D7 && e.KeyCode != Keys.D8 && e.KeyCode != Keys.D9 && e.KeyCode != Keys.D9)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    nf.Cpf = Convert.ToString(maskedTextBox1.Text);
                    MessageBox.Show(nf.Cpf);
                    //maskedTextBox1.Clear();
                    maskedTextBox1.Visible = false;
                    label2.Visible = false;

                }
                else if (e.KeyCode == Keys.Escape)
                {
                    maskedTextBox1.Clear();
                    maskedTextBox1.Visible = false;
                    label2.Visible = false;
                    txtb_CodBarras.Focus();
                }
                else
                {
                    comandos(e);
                    maskedTextBox1.Clear();
                    maskedTextBox1.Visible = false;
                    label2.Visible = false;
                }
            }
        }

        private void txtb_Quantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                qtd = txtb_Quantidade.Text;
                quantidade = Convert.ToInt32(qtd);

                txtb_CodBarras.Focus();

                txtb_Quantidade.Visible = false;
                Quantidade.Visible = false;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtb_CodBarras.Focus();
                txtb_Quantidade.Visible = false;
                Quantidade.Visible = false;
            }
            if (e.KeyCode != Keys.D0 && e.KeyCode != Keys.D1 && e.KeyCode != Keys.D2 && e.KeyCode != Keys.D3 && e.KeyCode != Keys.D4 && e.KeyCode != Keys.D5 && e.KeyCode != Keys.D6 && e.KeyCode != Keys.D7 && e.KeyCode != Keys.D8 && e.KeyCode != Keys.D9)
            {
                comandos(e);
                qtd = txtb_Quantidade.Text;
                if (qtd == "") { qtd = "1"; }
                quantidade = Convert.ToInt32(qtd);
                txtb_Quantidade.Visible = false;
                label2.Visible = false;
                Quantidade.Visible = false;
                txtb_Quantidade.Clear();
                txtb_CodBarras.Focus();
            }

        }

        private void txtb_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtb_Excluir_KeyUp(object sender, KeyEventArgs e)
        {
            comandos(e);
            if (e.KeyCode == Keys.Enter)
            {
                rmv = txtb_Excluir.Text;
                remove = int.Parse(rmv);
                remove = remove - 1;
                lst_Produtos.Items.Remove(lst_Produtos.Items[remove]);
                pedido[remove]= null;
                double numSum = conta.Sum();
                txtb_Excluir.Clear();
                txtb_Excluir.Visible = false;
                txtb_CodBarras.Focus();
                lb_PrecoTotal.Text = numSum.ToString("C");
                this.total_compra = numSum;
               
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtb_Excluir.Clear();
                lbl_Excluir.Visible = false;
                txtb_Excluir.Visible = false;
                txtb_CodBarras.Focus();
            }
        }

        public void btn_CodBarras_Click(object sender, EventArgs e)
        {
            pn_fnz.Controls.Clear();
            txtb_CodBarras.Select();

            maskedTextBox1.Clear();
            maskedTextBox1.Visible = false;
            label2.Visible = false;


            txtb_Quantidade.Clear();
            txtb_Quantidade.Visible = false;
            Quantidade.Visible = false;

            txtb_Excluir.Clear();
            lbl_Excluir.Visible = false;
            txtb_Excluir.Visible = false;
        }

        private void btn_Cpf_Click(object sender, EventArgs e)
        {
            pn_fnz.Visible = false;
            label2.Visible = true;
            maskedTextBox1.Visible = true;
            maskedTextBox1.Focus();

            txtb_Quantidade.Clear();
            txtb_Quantidade.Visible = false;
            Quantidade.Visible = false;

            txtb_Excluir.Clear();
            lbl_Excluir.Visible = false;
            txtb_Excluir.Visible = false;
        }

        private void btn_Qtd_Click(object sender, EventArgs e)
        {
            pn_fnz.Visible = false;
            txtb_Quantidade.BringToFront();
            Quantidade.Visible = true;
            txtb_Quantidade.Visible = true;
            txtb_Quantidade.Focus();

            maskedTextBox1.Clear();
            maskedTextBox1.Visible = false;
            label2.Visible = false;

            txtb_Excluir.Clear();
            lbl_Excluir.Visible = false;
            txtb_Excluir.Visible = false;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            pn_fnz.Visible = false;
            lbl_Excluir.Visible = true;
            txtb_Excluir.Visible = true;
            txtb_Excluir.Focus();

            maskedTextBox1.Clear();
            maskedTextBox1.Visible = false;
            label2.Visible = false;


            txtb_Quantidade.Clear();
            txtb_Quantidade.Visible = false;
            Quantidade.Visible = false;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            pn_Troco.Visible = false;
            total = 0;
            x = 0;
            rmv = "0";
            remove = 0;
            qtd = "0";
            quantidade = 1;

            for (int x = 0; x < 75; x++)
            {
                conta[x] = 0;
                produto[x] = null;
                pedido[x] = null;
            }
            lbl_PrecoTotalProduto.Text = null;
            lb_PrecoUni.Text = null;
            lb_PrecoTotal.Text = null;
            lst_Produtos.Items.Clear();
            txtb_CodBarras.Select();
            lb_Enter.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pedido[1] == null)
            {
                MessageBox.Show("Favor inserir itens ao carrinho");
                txtb_CodBarras.Select();
            }
            else
            {
                nf.Pagamento=  "Dinheiro";
                lb_Recebido.Text = "Valor Recebido";
                txtb_Recebido.Clear();
                txtb_troco.Clear();
                pn_Troco.Visible = true;
                btn_NovaCompra.Visible = false;
                txtb_Recebido.Select();
                lb_Enter.Visible = false;
            }
        }

        private void txtb_Recebido_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                txtb_Recebido.Clear();
                pn_Troco.Visible = false;
                txtb_troco.Clear();
                txtb_troco.Visible = false;
                txtb_CodBarras.Select();
                this.recebido = 0;
                this.troco = 0;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (txtb_Recebido.Text == null)
                {
                    MessageBox.Show("favor inserir o valor recebido");
                    txtb_Recebido.Select();
                }
                else
                {
                    try
                    {
                        double recebido = Convert.ToDouble(txtb_Recebido.Text);
                        double total = this.total_compra;
                        double troco = recebido - total;
                        txtb_troco.Visible = true;
                        lb_Troco.Visible = true;
                        txtb_troco.Visible = true;

                        if (recebido < total)
                        {
                            double Valor_Restante = Math.Abs(troco);
                            MessageBox.Show("valor inserido, é menor que o necessário, favor complementar com minimo de R$" + Valor_Restante.ToString("F2"));
                            recebido = 0;
                            troco = 0;
                            txtb_Recebido.Clear();
                            txtb_Recebido.Select();
                            txtb_troco.Visible = true;
                        }
                        else
                        {
                            txtb_troco.Text = troco.ToString("C");
                            this.recebido = recebido;
                            this.troco = troco;
                            txtb_troco.Visible = true;
                            txtb_Suporte.Visible = true;
                            txtb_Suporte.Focus();
                            txtb_Suporte.Select();
                            lb_Enter.Visible = false;
                        }
                        lb_Enter.Visible = true;
                    }

                    catch (Exception t)
                    {
                        MessageBox.Show(t.Message);

                    }


                }
            }
        }

        private void txtb_suporte_KeyUp(object sender, KeyEventArgs e)
        {
            comandos(e);

            if (e.KeyCode == Keys.Enter)
            {
                nf.Total = this.total_compra;
                
               if (nf.Pagamento == "Crédito")
                {
                    
                    nf.Parcelamento = this.parcela;
                }

                else if (nf.Pagamento == "Dinheiro")
                {
                    
                    nf.Troco = this.troco;
                }

                nf.Emitir(pedido);
                pn_Troco.Visible = false;
                total = 0;
                x = 0;
                rmv = "0";
                remove = 0;
                qtd = "0";
                quantidade = 1;

                for (int x = 0; x < 75; x++)
                {
                    conta[x] = 0;
                    produto[x] = null;
                    pedido[x] = null;
                }
                lbl_PrecoTotalProduto.Text = null;
                lb_PrecoUni.Text = null;
                lb_PrecoTotal.Text = null;
                lst_Produtos.Items.Clear();
                txtb_CodBarras.Select();
                lb_Enter.Visible = false;
            }

        }

        private void btn_Debito_Click(object sender, EventArgs e)
        {
            if (pedido[1] == null)
            {
                MessageBox.Show("Favor inserir itens ao carrinho");
                txtb_CodBarras.Select();
            }
            else
            {
                nf.Pagamento = "Débito";
                lb_Recebido.Text = "Valor da Compra";
                txtb_Recebido.Text = this.total_compra.ToString("C");
                txtb_troco.Clear();
                lb_Troco.Visible = false;
                txtb_troco.Visible = false;
                pn_Troco.Visible = true;
                txtb_Suporte.Visible = true;
                txtb_Suporte.Focus();
                lb_Enter.Visible = true;

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (pedido[1] == null)
            {
                MessageBox.Show("Favor inserir itens ao carrinho");
                txtb_CodBarras.Select();
            }
            else
            {
                nf.Pagamento = "Crédito";
                lb_Recebido.Text = "Valor da Compra";
                txtb_Recebido.Text = this.total_compra.ToString("C");
                txtb_troco.Clear();
                lb_Troco.Visible = true;
                lb_Troco.Text = "Parcelas";
                txtb_troco.Visible = true;
                pn_Troco.Visible = true;
                txtb_Suporte.Visible = true;
                txtb_troco.Focus();
                lb_Enter.Visible = true;
            }
        }

        private void txtb_troco_KeyUp(object sender, KeyEventArgs e)
        {
            comandos(e);
            if (e.KeyCode == Keys.Escape)
            {
                txtb_Recebido.Clear();
                pn_Troco.Visible = false;
                txtb_troco.Clear();
                txtb_troco.Visible = false;
                txtb_CodBarras.Select();
                this.recebido = 0;
                this.troco = 0;
                lb_Enter.Visible = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.parcela = Convert.ToInt32(txtb_troco.Text);
                txtb_Suporte.Visible = true;
                txtb_Suporte.Focus();
                lb_Enter.Visible = false;
            }
        }
    }
}