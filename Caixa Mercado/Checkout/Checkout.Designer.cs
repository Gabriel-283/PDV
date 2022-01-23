
namespace Caixa_Mercado
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbTotalPrice2 = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lst_products = new System.Windows.Forms.ListBox();
            this.lb_PrecoUni = new System.Windows.Forms.Label();
            this.lb_PriceTotal = new System.Windows.Forms.Label();
            this.txtbBarcode = new System.Windows.Forms.TextBox();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txtb_Quantidade = new System.Windows.Forms.TextBox();
            this.lblPriceTotalproduct = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.txtbRemove = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Excluir = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnCpf = new System.Windows.Forms.Button();
            this.btnAmount = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_fnz = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btn_Money = new System.Windows.Forms.Button();
            this.btnDebitCard = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.txtbReceived = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtbMoneyReturn = new System.Windows.Forms.TextBox();
            this.pnBack = new System.Windows.Forms.Panel();
            this.lbBack = new System.Windows.Forms.Label();
            this.lbReceived = new System.Windows.Forms.Label();
            this.txtb_Suporte = new System.Windows.Forms.TextBox();
            this.lbEnter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_fnz.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(475, 39);
            this.lbProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(311, 52);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "NOME product";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(26, 0);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(119, 20);
            this.lbQuantity.TabIndex = 1;
            this.lbQuantity.Text = "QUANTIDADE";
            this.lbQuantity.Visible = false;
            // 
            // lbTotalPrice2
            // 
            this.lbTotalPrice2.AutoSize = true;
            this.lbTotalPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice2.Location = new System.Drawing.Point(20, 12);
            this.lbTotalPrice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalPrice2.Name = "lbTotalPrice2";
            this.lbTotalPrice2.Size = new System.Drawing.Size(165, 31);
            this.lbTotalPrice2.TabIndex = 3;
            this.lbTotalPrice2.Text = "SUB TOTAL";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lbUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitPrice.Location = new System.Drawing.Point(34, 128);
            this.lbUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(250, 31);
            this.lbUnitPrice.TabIndex = 4;
            this.lbUnitPrice.Text = "PRECO UNITARIO";
            // 
            // lst_products
            // 
            this.lst_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_products.FormattingEnabled = true;
            this.lst_products.ItemHeight = 25;
            this.lst_products.Location = new System.Drawing.Point(4, 48);
            this.lst_products.Margin = new System.Windows.Forms.Padding(4);
            this.lst_products.Name = "lst_products";
            this.lst_products.Size = new System.Drawing.Size(632, 679);
            this.lst_products.TabIndex = 5;
            this.lst_products.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LstproductsKeyUp);
            // 
            // lb_PrecoUni
            // 
            this.lb_PrecoUni.AutoSize = true;
            this.lb_PrecoUni.BackColor = System.Drawing.SystemColors.Control;
            this.lb_PrecoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrecoUni.Location = new System.Drawing.Point(311, 256);
            this.lb_PrecoUni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PrecoUni.Name = "lb_PrecoUni";
            this.lb_PrecoUni.Size = new System.Drawing.Size(0, 31);
            this.lb_PrecoUni.TabIndex = 8;
            // 
            // lb_PriceTotal
            // 
            this.lb_PriceTotal.AutoSize = true;
            this.lb_PriceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PriceTotal.Location = new System.Drawing.Point(422, 12);
            this.lb_PriceTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PriceTotal.Name = "lb_PriceTotal";
            this.lb_PriceTotal.Size = new System.Drawing.Size(0, 36);
            this.lb_PriceTotal.TabIndex = 7;
            // 
            // txtbBarcode
            // 
            this.txtbBarcode.Location = new System.Drawing.Point(179, 54);
            this.txtbBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtbBarcode.Name = "txtbBarcode";
            this.txtbBarcode.Size = new System.Drawing.Size(245, 22);
            this.txtbBarcode.TabIndex = 90;
            this.txtbBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbCodBarrasKeyPress);
            this.txtbBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbCodBarrasKeyUp);
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcode.Location = new System.Drawing.Point(32, 38);
            this.lbBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(111, 42);
            this.lbBarcode.TabIndex = 12;
            this.lbBarcode.Text = "COD.";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(28, 39);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(120, 22);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.Visible = false;
            this.maskedTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MaskedTextBox1KeyUp);
            // 
            // txtb_Quantidade
            // 
            this.txtb_Quantidade.Location = new System.Drawing.Point(28, 42);
            this.txtb_Quantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_Quantidade.Name = "txtb_Quantidade";
            this.txtb_Quantidade.Size = new System.Drawing.Size(120, 22);
            this.txtb_Quantidade.TabIndex = 20;
            this.txtb_Quantidade.Visible = false;
            this.txtb_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbQuantidadeKeyPress);
            this.txtb_Quantidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbQuantidadeKeyUp);
            // 
            // lblPriceTotalproduct
            // 
            this.lblPriceTotalproduct.AutoSize = true;
            this.lblPriceTotalproduct.BackColor = System.Drawing.SystemColors.Control;
            this.lblPriceTotalproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceTotalproduct.Location = new System.Drawing.Point(311, 128);
            this.lblPriceTotalproduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceTotalproduct.Name = "lblPriceTotalproduct";
            this.lblPriceTotalproduct.Size = new System.Drawing.Size(0, 31);
            this.lblPriceTotalproduct.TabIndex = 21;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(35, 256);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(202, 32);
            this.lbTotalPrice.TabIndex = 22;
            this.lbTotalPrice.Text = "PRECO TOTAL";
            // 
            // txtbRemove
            // 
            this.txtbRemove.Location = new System.Drawing.Point(28, 40);
            this.txtbRemove.Margin = new System.Windows.Forms.Padding(4);
            this.txtbRemove.Name = "txtbRemove";
            this.txtbRemove.Size = new System.Drawing.Size(120, 22);
            this.txtbRemove.TabIndex = 23;
            this.txtbRemove.Visible = false;
            this.txtbRemove.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbExcluirKeyUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "CPF";
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lbl_Excluir);
            this.panel1.Controls.Add(this.txtbRemove);
            this.panel1.Controls.Add(this.lbQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.txtb_Quantidade);
            this.panel1.Location = new System.Drawing.Point(698, 581);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 72);
            this.panel1.TabIndex = 24;
            // 
            // lbl_Excluir
            // 
            this.lbl_Excluir.AutoSize = true;
            this.lbl_Excluir.Location = new System.Drawing.Point(42, 0);
            this.lbl_Excluir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Excluir.Name = "lbl_Excluir";
            this.lbl_Excluir.Size = new System.Drawing.Size(63, 16);
            this.lbl_Excluir.TabIndex = 25;
            this.lbl_Excluir.Text = "EXCLUIR";
            this.lbl_Excluir.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.lst_products);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(886, 64);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 731);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 36);
            this.panel3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cod. Barras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Preco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Preco total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Indice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Nome";
            // 
            // btnBarcode
            // 
            this.btnBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBarcode.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBarcode.Location = new System.Drawing.Point(11, 815);
            this.btnBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(166, 59);
            this.btnBarcode.TabIndex = 26;
            this.btnBarcode.Text = "COD. BARRAS [F1]";
            this.btnBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Click += new System.EventHandler(this.BtnCodBarrasClick);
            // 
            // btnCpf
            // 
            this.btnCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCpf.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCpf.Location = new System.Drawing.Point(15, 881);
            this.btnCpf.Margin = new System.Windows.Forms.Padding(4);
            this.btnCpf.Name = "btnCpf";
            this.btnCpf.Size = new System.Drawing.Size(162, 59);
            this.btnCpf.TabIndex = 27;
            this.btnCpf.Text = "CPF[F2]";
            this.btnCpf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCpf.UseVisualStyleBackColor = true;
            this.btnCpf.Click += new System.EventHandler(this.BtnCpfClick);
            // 
            // btnAmount
            // 
            this.btnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAmount.Location = new System.Drawing.Point(188, 815);
            this.btnAmount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAmount.Name = "btnAmount";
            this.btnAmount.Size = new System.Drawing.Size(146, 59);
            this.btnAmount.TabIndex = 28;
            this.btnAmount.Text = "QUANTIDADE [F3]";
            this.btnAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmount.UseVisualStyleBackColor = true;
            this.btnAmount.Click += new System.EventHandler(this.BtnQuantityClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.Location = new System.Drawing.Point(188, 881);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 59);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "EXCLUIR [F4]";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnExcluirClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbBarcode);
            this.panel2.Controls.Add(this.lbUnitPrice);
            this.panel2.Controls.Add(this.lb_PrecoUni);
            this.panel2.Controls.Add(this.txtbBarcode);
            this.panel2.Controls.Add(this.lblPriceTotalproduct);
            this.panel2.Controls.Add(this.lbTotalPrice);
            this.panel2.Location = new System.Drawing.Point(444, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 375);
            this.panel2.TabIndex = 31;
            // 
            // pn_fnz
            // 
            this.pn_fnz.Controls.Add(this.label6);
            this.pn_fnz.Location = new System.Drawing.Point(15, 170);
            this.pn_fnz.Margin = new System.Windows.Forms.Padding(4);
            this.pn_fnz.Name = "pn_fnz";
            this.pn_fnz.Size = new System.Drawing.Size(421, 371);
            this.pn_fnz.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.lbTotalPrice2);
            this.panel4.Controls.Add(this.lb_PriceTotal);
            this.panel4.Location = new System.Drawing.Point(890, 803);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(634, 61);
            this.panel4.TabIndex = 33;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnNewOrder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewOrder.Location = new System.Drawing.Point(740, 815);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(142, 59);
            this.btnNewOrder.TabIndex = 34;
            this.btnNewOrder.Text = "NOVA COMPRA[11]";
            this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.Button1Click);
            // 
            // btn_Money
            // 
            this.btn_Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Money.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Money.Location = new System.Drawing.Point(341, 815);
            this.btn_Money.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Money.Name = "btn_Money";
            this.btn_Money.Size = new System.Drawing.Size(148, 59);
            this.btn_Money.TabIndex = 35;
            this.btn_Money.Text = "PAGAMENTO DINHEIRO [F8]";
            this.btn_Money.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Money.UseVisualStyleBackColor = true;
            this.btn_Money.Click += new System.EventHandler(this.Button1Click1);
            // 
            // btnDebitCard
            // 
            this.btnDebitCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDebitCard.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDebitCard.Location = new System.Drawing.Point(341, 881);
            this.btnDebitCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDebitCard.Name = "btnDebitCard";
            this.btnDebitCard.Size = new System.Drawing.Size(148, 59);
            this.btnDebitCard.TabIndex = 36;
            this.btnDebitCard.Text = "PAGAMENTO DÉBITO [F9]";
            this.btnDebitCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDebitCard.UseVisualStyleBackColor = true;
            this.btnDebitCard.Click += new System.EventHandler(this.BtnDebitoClick);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCreditCard.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreditCard.Location = new System.Drawing.Point(496, 815);
            this.btnCreditCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(142, 59);
            this.btnCreditCard.TabIndex = 37;
            this.btnCreditCard.Text = "PAGAMENTO CRÉDITO [10]";
            this.btnCreditCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.Button3Click);
            // 
            // txtbReceived
            // 
            this.txtbReceived.Location = new System.Drawing.Point(35, 59);
            this.txtbReceived.Margin = new System.Windows.Forms.Padding(4);
            this.txtbReceived.Name = "txtbReceived";
            this.txtbReceived.Size = new System.Drawing.Size(212, 22);
            this.txtbReceived.TabIndex = 38;
            this.txtbReceived.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbmoneyReceivedKeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtbMoneyReturn
            // 
            this.txtbMoneyReturn.Location = new System.Drawing.Point(360, 59);
            this.txtbMoneyReturn.Margin = new System.Windows.Forms.Padding(4);
            this.txtbMoneyReturn.Name = "txtbMoneyReturn";
            this.txtbMoneyReturn.Size = new System.Drawing.Size(212, 22);
            this.txtbMoneyReturn.TabIndex = 40;
            this.txtbMoneyReturn.Visible = false;
            this.txtbMoneyReturn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbmoneyReturnKeyUp);
            // 
            // pnBack
            // 
            this.pnBack.Controls.Add(this.lbBack);
            this.pnBack.Controls.Add(this.lbReceived);
            this.pnBack.Controls.Add(this.txtbMoneyReturn);
            this.pnBack.Controls.Add(this.txtbReceived);
            this.pnBack.Location = new System.Drawing.Point(894, 886);
            this.pnBack.Margin = new System.Windows.Forms.Padding(4);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(614, 88);
            this.pnBack.TabIndex = 41;
            this.pnBack.Visible = false;
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Location = new System.Drawing.Point(432, 16);
            this.lbBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(55, 16);
            this.lbBack.TabIndex = 44;
            this.lbBack.Text = "TROCO";
            this.lbBack.Visible = false;
            // 
            // lbReceived
            // 
            this.lbReceived.AutoSize = true;
            this.lbReceived.Location = new System.Drawing.Point(100, 16);
            this.lbReceived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReceived.Name = "lbReceived";
            this.lbReceived.Size = new System.Drawing.Size(76, 16);
            this.lbReceived.TabIndex = 43;
            this.lbReceived.Text = "RECEBIDO";
            // 
            // txtb_Suporte
            // 
            this.txtb_Suporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb_Suporte.Location = new System.Drawing.Point(1531, 949);
            this.txtb_Suporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_Suporte.Name = "txtb_Suporte";
            this.txtb_Suporte.Size = new System.Drawing.Size(20, 15);
            this.txtb_Suporte.TabIndex = 45;
            this.txtb_Suporte.Visible = false;
            // 
            // lbEnter
            // 
            this.lbEnter.AutoSize = true;
            this.lbEnter.Location = new System.Drawing.Point(736, 945);
            this.lbEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnter.Name = "lbEnter";
            this.lbEnter.Size = new System.Drawing.Size(159, 16);
            this.lbEnter.TabIndex = 46;
            this.lbEnter.Text = "Favor pressionar ENTER";
            this.lbEnter.Visible = false;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1550, 976);
            this.Controls.Add(this.lbEnter);
            this.Controls.Add(this.txtb_Suporte);
            this.Controls.Add(this.pnBack);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.btnDebitCard);
            this.Controls.Add(this.btn_Money);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pn_fnz);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAmount);
            this.Controls.Add(this.btnCpf);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAIXA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbCodBarrasKeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_fnz.ResumeLayout(false);
            this.pn_fnz.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnBack.ResumeLayout(false);
            this.pnBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbTotalPrice2;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.ListBox lst_products;
        private System.Windows.Forms.Label lb_PrecoUni;
        private System.Windows.Forms.Label lbBarcode;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public System.Windows.Forms.TextBox txtbBarcode;
        private System.Windows.Forms.TextBox txtb_Quantidade;
        private System.Windows.Forms.Label lblPriceTotalproduct;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox txtbRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Excluir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnCpf;
        private System.Windows.Forms.Button btnAmount;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lb_PriceTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel pn_fnz;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Money;
        private System.Windows.Forms.Button btnDebitCard;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.TextBox txtbReceived;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtbMoneyReturn;
        private System.Windows.Forms.Panel pnBack;
        private System.Windows.Forms.Label lbReceived;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.TextBox txtb_Suporte;
        private System.Windows.Forms.Label lbEnter;
    }
}
