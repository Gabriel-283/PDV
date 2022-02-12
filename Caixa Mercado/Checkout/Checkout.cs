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
    public partial class Checkout : Form
    {
        Form openForm;
        public double[] priceStorage = new double[76];
        public string[] product = new string[76];
        public string[] orderStorage = new string[76];
        string finaliza = ""; //ver nome
        int enterCount = 0;
        string paymentMethod = "";
        double orderValue = 0;
        double moneyReceived;//Money
        double moneyReturn;// Money
        double total = 0;
        int instalment = 0;//credit
        int refernce = 0;
        string removeString = "0";
        int remove = 0;
        string quantityString = "0";
        int quantity = 1;
        ComercialInvoice creditMemo = new ComercialInvoice();
      

        public Checkout()
        {
            InitializeComponent();
            txtbBarcode.Select();

        }
        private void TxtbCodBarrasKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }
        public void TxtbCodBarrasKeyUp(object sender, KeyEventArgs e)
        {
            Comands(e);

            if (e.KeyCode == Keys.Enter)
            {

                using (SqlConnection conectionDataBase = new SqlConnection(DataBaseProductsConection.stringConection))
                {
                    conectionDataBase.Open();

                    var sql = "SELECT * FROM tbl_products WHERE ID_product= '" + txtbBarcode.Text + "'";

                    using (SqlCommand comand = new SqlCommand(sql, conectionDataBase))
                    {
                        using (SqlDataReader readerData = comand.ExecuteReader())
                        {
                            if (readerData.HasRows)
                            {

                                if (readerData.Read())
                                {
                                    refernce += 1;
                                    priceStorage[refernce] = Convert.ToDouble(readerData["preco"]);
                                    product[refernce] = Convert.ToString(readerData["Nome_product"]);
                                    if (quantity != 1)
                                    {
                                        priceStorage[refernce] *= quantity;

                                    }
                                    total = priceStorage[refernce];
                                    double totalSum = priceStorage.Sum();
                                    double totalPrice = Convert.ToDouble(readerData["preco"]);
                                    string SubTotal = totalSum.ToString();
                                    this.orderValue = Convert.ToDouble(SubTotal);
                                    lblPriceTotalproduct.Text = totalPrice.ToString("C");
                                    lbProductName.Text = Convert.ToString(product[refernce]);
                                    lb_PrecoUni.Text = priceStorage[refernce].ToString("C");
                                    string totalOrder = totalSum.ToString("C");
                                    lb_PriceTotal.Text = totalOrder;

                                    orderStorage[refernce] = "       " + product[refernce] + "         " + lb_PrecoUni.Text + "         " + quantity + "               " + lblPriceTotalproduct.Text + "            " + txtbBarcode.Text;

                                    lst_products.Items.Add(refernce + orderStorage[refernce].PadRight(20));
                                   finaly = totalSum.ToString("F2");
                                }
                            }
                        }
                    }
                }

                txtbBarcode.Clear();
                quantity = 1;
                quantityString = "";
            }

        }

        private void LstproductsKeyUp(object sender, KeyEventArgs e)
        {
            Comands(e);
        }
        public void Comands(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                pn_fnz.Visible = false;
                txtbBarcode.Focus();
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
                lbQuantity.Visible = true;
                txtb_Quantidade.Visible = true;
                txtb_Quantidade.Focus();
            }
            if (e.KeyCode == Keys.F4)
            {
                lbl_Excluir.Visible = true;
                txtbRemove.Visible = true;
                txtbRemove.Focus();
            }

            if (e.KeyCode == Keys.F8)
            {
                creditMemo.PaymentForm = "Dineiro";
                pnBack.Visible = true;

                txtbReceived.Select();


            }

            if (e.KeyCode == Keys.F9)
            {
                if (orderStorage[1] == null)
                {
                    MessageBox.Show("Favor inserir itens ao carrinho");
                    txtbBarcode.Select();
                }
                else
                {
                    creditMemo.PaymentForm = "Débito";
                    lbReceived.Text = "Valor da Compra";
                    txtbReceived.Text = this.orderValue.ToString("C");
                    txtbMoneyReturn.Clear();
                    lbBack.Visible = false;
                    txtbMoneyReturn.Visible = false;
                    pnBack.Visible = true;
                    txtbMoneyReturn.Focus();

                }

            }
            if (e.KeyCode == Keys.F10)
            {

                if (orderStorage[1] == null)
                {
                    MessageBox.Show("Favor inserir itens ao carrinho");
                    txtbBarcode.Select();
                }
                else
                {
                    creditMemo.PaymentForm = "Crédito";
                    lbReceived.Text = "Valor da Compra";
                    txtbReceived.Text = this.orderValue.ToString("C");
                    txtbMoneyReturn.Clear();
                    lbBack.Visible = true;
                    lbBack.Text = "instalments";
                    txtbMoneyReturn.Visible = true;
                    pnBack.Visible = true;
                    txtb_Suporte.Visible = true;
                    txtbMoneyReturn.Focus();
                }
            }
            if (e.KeyCode == Keys.F11)
            {
                pnBack.Visible = false;
                total = 0;
                refernce = 0;
                removeString = "0";
                remove = 0;
                quantityString = "0";
                quantity = 1;

                for (int reference = 0; reference <= 76; reference++)
                {
                    priceStorage[reference] = 0;
                    product[reference] = null;
                    orderStorage[reference] = null;
                }
                lblPriceTotalproduct.Text = null;
                lb_PrecoUni.Text = null;
                lb_PriceTotal.Text = null;
                lst_products.Items.Clear();
                txtbBarcode.Select();

            }
        }



        private void MaskedTextBox1KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.D0 && e.KeyCode != Keys.D1 && e.KeyCode != Keys.D2 && e.KeyCode != Keys.D3 && e.KeyCode != Keys.D4 && e.KeyCode != Keys.D5 && e.KeyCode != Keys.D6 && e.KeyCode != Keys.D7 && e.KeyCode != Keys.D8 && e.KeyCode != Keys.D9 && e.KeyCode != Keys.D9)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    creditMemo.Cpf = Convert.ToString(maskedTextBox1.Text);
                    MessageBox.Show(creditMemo.Cpf);
                    maskedTextBox1.Visible = false;
                    label2.Visible = false;

                }
                else if (e.KeyCode == Keys.Escape)
                {
                    maskedTextBox1.Clear();
                    maskedTextBox1.Visible = false;
                    label2.Visible = false;
                    txtbBarcode.Focus();
                }
                else
                {
                    Comands(e);
                    maskedTextBox1.Clear();
                    maskedTextBox1.Visible = false;
                    label2.Visible = false;
                }
            }
        }

        private void TxtbQuantidadeKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                quantityString = txtb_Quantidade.Text;
                quantity = Convert.ToInt32(quantityString);

                txtbBarcode.Focus();

                txtb_Quantidade.Visible = false;
                lbQuantity.Visible = false;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtbBarcode.Focus();
                txtb_Quantidade.Visible = false;
                lbQuantity.Visible = false;
            }
            if (e.KeyCode != Keys.D0 && e.KeyCode != Keys.D1 && e.KeyCode != Keys.D2 && e.KeyCode != Keys.D3 && e.KeyCode != Keys.D4 && e.KeyCode != Keys.D5 && e.KeyCode != Keys.D6 && e.KeyCode != Keys.D7 && e.KeyCode != Keys.D8 && e.KeyCode != Keys.D9)
            {
                Comands(e);
                quantityString = txtb_Quantidade.Text;
                if (quantityString == "") { quantityString = "1"; }
                quantity = Convert.ToInt32(quantityString);
                txtb_Quantidade.Visible = false;
                label2.Visible = false;
                lbQuantity.Visible = false;
                txtb_Quantidade.Clear();
                txtbBarcode.Focus();
            }

        }

        private void TxtbQuantidadeKeyPress(object sender, KeyPressEventArgs e)
        {
            Program controlerKey = new Program();
            controlerKey.JustNumber(e,txtb_Quantidade);
            
        }

        private void TxtbExcluirKeyUp(object sender, KeyEventArgs e)
        {
            Comands(e);
            if (e.KeyCode == Keys.Enter)
            {
                removeString = txtbRemove.Text;
                remove = int.Parse(removeString);
                remove = remove - 1;
                lst_products.Items.Remove(lst_products.Items[remove]);
                orderStorage[remove] = null;
                double numSum = priceStorage.Sum();
                txtbRemove.Clear();
                txtbRemove.Visible = false;
                txtbBarcode.Focus();
                lb_PriceTotal.Text = numSum.ToString("C");
                this.orderValue = numSum;

            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtbRemove.Clear();
                lbl_Excluir.Visible = false;
                txtbRemove.Visible = false;
                txtbBarcode.Focus();
            }
        }

        public void BtnCodBarrasClick(object sender, EventArgs e)
        {
            pn_fnz.Controls.Clear();
            txtbBarcode.Select();

            maskedTextBox1.Clear();
            maskedTextBox1.Visible = false;
            label2.Visible = false;


            txtb_Quantidade.Clear();
            txtb_Quantidade.Visible = false;
            lbQuantity.Visible = false;

            txtbRemove.Clear();
            lbl_Excluir.Visible = false;
            txtbRemove.Visible = false;
        }

        private void BtnCpfClick(object sender, EventArgs e)
        {
            pn_fnz.Visible = false;
            label2.Visible = true;
            maskedTextBox1.Visible = true;
            maskedTextBox1.Focus();

            txtb_Quantidade.Clear();
            txtb_Quantidade.Visible = false;
            lbQuantity.Visible = false;

            txtbRemove.Clear();
            lbl_Excluir.Visible = false;
            txtbRemove.Visible = false;
        }

        private void BtnQuantityClick(object sender, EventArgs e)
        {
            pn_fnz.Visible = false;
            txtb_Quantidade.BringToFront();
            lbQuantity.Visible = true;
            txtb_Quantidade.Visible = true;
            txtb_Quantidade.Focus();

            maskedTextBox1.Clear();
            maskedTextBox1.Visible = false;
            label2.Visible = false;

            txtbRemove.Clear();
            lbl_Excluir.Visible = false;
            txtbRemove.Visible = false;
        }

        private void BtnExcluirClick(object sender, EventArgs e)
        {
            pn_fnz.Visible = false;
            lbl_Excluir.Visible = true;
            txtbRemove.Visible = true;
            txtbRemove.Focus();

            maskedTextBox1.Clear();
            maskedTextBox1.Visible = false;
            label2.Visible = false;


            txtb_Quantidade.Clear();
            txtb_Quantidade.Visible = false;
            lbQuantity.Visible = false;
        }




        private void Button1Click(object sender, EventArgs e)
        {
            pnBack.Visible = false;
            total = 0;
            refernce = 0;
            removeString = "0";
            remove = 0;
            quantityString = "0";
            quantity = 1;

            for (int reference = 0; reference < 75; reference++)
            {
                priceStorage[reference] = 0;
                product[reference] = null;
                orderStorage[reference] = null;
            }
            lblPriceTotalproduct.Text = null;
            lb_PrecoUni.Text = null;
            lb_PriceTotal.Text = null;
            lst_products.Items.Clear();
            txtbBarcode.Select();
            lbEnter.Visible = false;
        }
        private void Button1Click1(object sender, EventArgs e)
        {
            if (orderStorage[1] == null)
            {
                MessageBox.Show("Favor inserir itens ao carrinho");
                txtbBarcode.Select();
            }
            else
            {
                creditMemo.PaymentForm = "Dinheiro";
                lbReceived.Text = "Valor moneyReceived";
                txtbReceived.Clear();
                txtbMoneyReturn.Clear();
                pnBack.Visible = true;
                btnNewOrder.Visible = false;
                txtbReceived.Select();
                lbEnter.Visible = false;
            }
        }

        private void TxtbmoneyReceivedKeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                txtbReceived.Clear();
                pnBack.Visible = false;
                txtbMoneyReturn.Clear();
                txtbMoneyReturn.Visible = false;
                txtbBarcode.Select();
                this.moneyReceived = 0;
                this.moneyReturn = 0;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (txtbReceived.Text == null)
                {
                    MessageBox.Show("favor inserir o valor moneyReceived");
                    txtbReceived.Select();
                }
                else
                {
                    try
                    {
                        double moneyReceived = Convert.ToDouble(txtbReceived.Text);
                        double total = this.orderValue;
                        double moneyReturn = moneyReceived - total;
                        txtbMoneyReturn.Visible = true;
                        lbBack.Visible = true;
                        txtbMoneyReturn.Visible = true;

                        if (moneyReceived < total)
                        {
                            double missingValue = Math.Abs(moneyReturn);
                            MessageBox.Show("valor inserido, é menor que o necessário, favor complementar com minimo de R$" + missingValue.ToString("F2"));
                            moneyReceived = 0;
                            moneyReturn = 0;
                            txtbReceived.Clear();
                            txtbReceived.Select();
                            txtbMoneyReturn.Visible = true;
                        }
                        else
                        {
                            txtbMoneyReturn.Text = moneyReturn.ToString("C");
                            this.moneyReceived = moneyReceived;
                            this.moneyReturn = moneyReturn;
                            txtbMoneyReturn.Visible = true;
                            txtb_Suporte.Visible = true;
                            txtbMoneyReturn.Focus();
                            enterCount += 1;
                            lbEnter.Visible = true;
                        }
                        lbEnter.Visible = true;
                    }

                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);

                    }


                }
            }
        }
        private void Clean()
        {
            creditMemo.CreateReceipt(orderStorage);
            pnBack.Visible = false;
            total = 0;
            refernce = 0;
            removeString = "0";
            remove = 0;
            quantityString = "0";
            quantity = 1;

            for (int x = 0; x < orderStorage.Length; x++)
            {
                priceStorage[x] = 0;
                product[x] = null;
                orderStorage[x] = null;
            }
            lblPriceTotalproduct.Text = null;
            lb_PrecoUni.Text = null;
            lb_PriceTotal.Text = null;
            lst_products.Items.Clear();
            txtbBarcode.Select();
            lbEnter.Visible = false;
            enterCount = 0;

        }


        

        private void Suporte()
        {

            creditMemo.Total = this.orderValue;

            if (creditMemo.PaymentForm == "Crédito")
            {

                creditMemo.Installments = this.instalment;
            }

            else if (creditMemo.PaymentForm == "Dinheiro")
            {
                creditMemo.MoneyReturn = this.moneyReturn;
            }

            Clean();



        }

        private void BtnDebitoClick(object sender, EventArgs e)
        {
            if (orderStorage[1] == null)
            {
                MessageBox.Show("Favor inserir itens ao carrinho");
                txtbBarcode.Select();
            }
            else
            {
                enterCount += 1;
                creditMemo.PaymentForm = "Débito";
                lbReceived.Text = "Valor da Compra";
                txtbReceived.Text = this.orderValue.ToString("C");
                txtbMoneyReturn.Clear();
                lbBack.Visible = false;
                txtbMoneyReturn.Visible = false;
                pnBack.Visible = true;
                txtbMoneyReturn.Visible = true;
                txtbMoneyReturn.Focus();
                lbEnter.Visible = true;

            }
        }


        private void Button3Click(object sender, EventArgs e)
        {
            if (orderStorage[1] == null)
            {
                MessageBox.Show("Favor inserir itens ao carrinho");
                txtbBarcode.Select();
            }
            else
            {
                creditMemo.PaymentForm = "Crédito";
                lbReceived.Text = "Valor da Compra";
                txtbReceived.Text = this.orderValue.ToString("C");
                txtbMoneyReturn.Clear();
                lbBack.Visible = true;
                lbBack.Text = "instalments";
                txtbMoneyReturn.Visible = true;
                pnBack.Visible = true;
                txtb_Suporte.Visible = true;
                txtbMoneyReturn.Focus();
                lbEnter.Visible = true;
            }
        }

        private void TxtbmoneyReturnKeyUp(object sender, KeyEventArgs e)
        {

            Comands(e);
            if (e.KeyCode == Keys.Escape)
            {
                txtbReceived.Clear();
                pnBack.Visible = false;
                txtbMoneyReturn.Clear();
                txtbMoneyReturn.Visible = false;
                txtbBarcode.Select();
                this.moneyReceived = 0;
                this.moneyReturn = 0;
                lbEnter.Visible = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (enterCount == 0)
                {
                    this.instalment = Convert.ToInt32(txtbMoneyReturn.Text);
                    lbEnter.Visible = true;
                    enterCount += 1;
                }

                if (enterCount == 1)
                {

                    Suporte();
                }
            }
        }
    }
}
