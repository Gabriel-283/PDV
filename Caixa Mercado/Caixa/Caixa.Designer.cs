
namespace Caixa_Mercado
{
    partial class Caixa
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
            this.lb_NomeProduto = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.Label();
            this.PrecoTotal = new System.Windows.Forms.Label();
            this.PrecoUni = new System.Windows.Forms.Label();
            this.lst_Produtos = new System.Windows.Forms.ListBox();
            this.lb_PrecoUni = new System.Windows.Forms.Label();
            this.lb_PrecoTotal = new System.Windows.Forms.Label();
            this.txtb_CodBarras = new System.Windows.Forms.TextBox();
            this.Cod_Barras = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txtb_Quantidade = new System.Windows.Forms.TextBox();
            this.lbl_PrecoTotalProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_Excluir = new System.Windows.Forms.TextBox();
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
            this.btn_CodBarras = new System.Windows.Forms.Button();
            this.btn_Cpf = new System.Windows.Forms.Button();
            this.btn_Qtd = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_fnz = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_NovaCompra = new System.Windows.Forms.Button();
            this.btn_Dinheiro = new System.Windows.Forms.Button();
            this.btn_Debito = new System.Windows.Forms.Button();
            this.btn_Credito = new System.Windows.Forms.Button();
            this.txtb_Recebido = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtb_troco = new System.Windows.Forms.TextBox();
            this.pn_Troco = new System.Windows.Forms.Panel();
            this.lb_Troco = new System.Windows.Forms.Label();
            this.lb_Recebido = new System.Windows.Forms.Label();
            this.txtb_Suporte = new System.Windows.Forms.TextBox();
            this.lb_Enter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_fnz.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pn_Troco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_NomeProduto
            // 
            this.lb_NomeProduto.AutoSize = true;
            this.lb_NomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeProduto.Location = new System.Drawing.Point(380, 31);
            this.lb_NomeProduto.Name = "lb_NomeProduto";
            this.lb_NomeProduto.Size = new System.Drawing.Size(303, 39);
            this.lb_NomeProduto.TabIndex = 0;
            this.lb_NomeProduto.Text = "NOME PRODUTO";
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantidade.Location = new System.Drawing.Point(21, 0);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(97, 16);
            this.Quantidade.TabIndex = 1;
            this.Quantidade.Text = "QUANTIDADE";
            this.Quantidade.Visible = false;
            // 
            // PrecoTotal
            // 
            this.PrecoTotal.AutoSize = true;
            this.PrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoTotal.Location = new System.Drawing.Point(16, 10);
            this.PrecoTotal.Name = "PrecoTotal";
            this.PrecoTotal.Size = new System.Drawing.Size(129, 25);
            this.PrecoTotal.TabIndex = 3;
            this.PrecoTotal.Text = "SUB TOTAL";
            // 
            // PrecoUni
            // 
            this.PrecoUni.AutoSize = true;
            this.PrecoUni.BackColor = System.Drawing.SystemColors.Control;
            this.PrecoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoUni.Location = new System.Drawing.Point(27, 102);
            this.PrecoUni.Name = "PrecoUni";
            this.PrecoUni.Size = new System.Drawing.Size(190, 25);
            this.PrecoUni.TabIndex = 4;
            this.PrecoUni.Text = "PRECO UNITARIO";
            // 
            // lst_Produtos
            // 
            this.lst_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Produtos.FormattingEnabled = true;
            this.lst_Produtos.ItemHeight = 20;
            this.lst_Produtos.Location = new System.Drawing.Point(3, 38);
            this.lst_Produtos.Name = "lst_Produtos";
            this.lst_Produtos.Size = new System.Drawing.Size(506, 544);
            this.lst_Produtos.TabIndex = 5;
            this.lst_Produtos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lst_Produtos_KeyUp);
            // 
            // lb_PrecoUni
            // 
            this.lb_PrecoUni.AutoSize = true;
            this.lb_PrecoUni.BackColor = System.Drawing.SystemColors.Control;
            this.lb_PrecoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrecoUni.Location = new System.Drawing.Point(249, 205);
            this.lb_PrecoUni.Name = "lb_PrecoUni";
            this.lb_PrecoUni.Size = new System.Drawing.Size(0, 25);
            this.lb_PrecoUni.TabIndex = 8;
            // 
            // lb_PrecoTotal
            // 
            this.lb_PrecoTotal.AutoSize = true;
            this.lb_PrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrecoTotal.Location = new System.Drawing.Point(338, 10);
            this.lb_PrecoTotal.Name = "lb_PrecoTotal";
            this.lb_PrecoTotal.Size = new System.Drawing.Size(0, 29);
            this.lb_PrecoTotal.TabIndex = 7;
            // 
            // txtb_CodBarras
            // 
            this.txtb_CodBarras.Location = new System.Drawing.Point(143, 43);
            this.txtb_CodBarras.Name = "txtb_CodBarras";
            this.txtb_CodBarras.Size = new System.Drawing.Size(197, 20);
            this.txtb_CodBarras.TabIndex = 90;
            this.txtb_CodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_CodBarras_KeyPress);
            this.txtb_CodBarras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_CodBarras_KeyUp);
            // 
            // Cod_Barras
            // 
            this.Cod_Barras.AutoSize = true;
            this.Cod_Barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cod_Barras.Location = new System.Drawing.Point(26, 30);
            this.Cod_Barras.Name = "Cod_Barras";
            this.Cod_Barras.Size = new System.Drawing.Size(88, 33);
            this.Cod_Barras.TabIndex = 12;
            this.Cod_Barras.Text = "COD.";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(22, 31);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(97, 20);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.Visible = false;
            this.maskedTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyUp);
            // 
            // txtb_Quantidade
            // 
            this.txtb_Quantidade.Location = new System.Drawing.Point(22, 34);
            this.txtb_Quantidade.Name = "txtb_Quantidade";
            this.txtb_Quantidade.Size = new System.Drawing.Size(97, 20);
            this.txtb_Quantidade.TabIndex = 20;
            this.txtb_Quantidade.Visible = false;
            this.txtb_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_Quantidade_KeyPress);
            this.txtb_Quantidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_Quantidade_KeyUp);
            // 
            // lbl_PrecoTotalProduto
            // 
            this.lbl_PrecoTotalProduto.AutoSize = true;
            this.lbl_PrecoTotalProduto.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_PrecoTotalProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecoTotalProduto.Location = new System.Drawing.Point(249, 102);
            this.lbl_PrecoTotalProduto.Name = "lbl_PrecoTotalProduto";
            this.lbl_PrecoTotalProduto.Size = new System.Drawing.Size(0, 25);
            this.lbl_PrecoTotalProduto.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "PRECO TOTAL";
            // 
            // txtb_Excluir
            // 
            this.txtb_Excluir.Location = new System.Drawing.Point(22, 32);
            this.txtb_Excluir.Name = "txtb_Excluir";
            this.txtb_Excluir.Size = new System.Drawing.Size(97, 20);
            this.txtb_Excluir.TabIndex = 23;
            this.txtb_Excluir.Visible = false;
            this.txtb_Excluir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_Excluir_KeyUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "CPF";
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lbl_Excluir);
            this.panel1.Controls.Add(this.txtb_Excluir);
            this.panel1.Controls.Add(this.Quantidade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.txtb_Quantidade);
            this.panel1.Location = new System.Drawing.Point(558, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 58);
            this.panel1.TabIndex = 24;
            // 
            // lbl_Excluir
            // 
            this.lbl_Excluir.AutoSize = true;
            this.lbl_Excluir.Location = new System.Drawing.Point(34, 0);
            this.lbl_Excluir.Name = "lbl_Excluir";
            this.lbl_Excluir.Size = new System.Drawing.Size(53, 13);
            this.lbl_Excluir.TabIndex = 25;
            this.lbl_Excluir.Text = "EXCLUIR";
            this.lbl_Excluir.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.lst_Produtos);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(709, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(509, 585);
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
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 29);
            this.panel3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cod. Barras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Preco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Preco total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Indice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Nome";
            // 
            // btn_CodBarras
            // 
            this.btn_CodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_CodBarras.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CodBarras.Location = new System.Drawing.Point(9, 652);
            this.btn_CodBarras.Name = "btn_CodBarras";
            this.btn_CodBarras.Size = new System.Drawing.Size(133, 47);
            this.btn_CodBarras.TabIndex = 26;
            this.btn_CodBarras.Text = "COD. BARRAS [F1]";
            this.btn_CodBarras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CodBarras.UseVisualStyleBackColor = true;
            this.btn_CodBarras.Click += new System.EventHandler(this.btn_CodBarras_Click);
            // 
            // btn_Cpf
            // 
            this.btn_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Cpf.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cpf.Location = new System.Drawing.Point(12, 705);
            this.btn_Cpf.Name = "btn_Cpf";
            this.btn_Cpf.Size = new System.Drawing.Size(130, 47);
            this.btn_Cpf.TabIndex = 27;
            this.btn_Cpf.Text = "CPF[F2]";
            this.btn_Cpf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cpf.UseVisualStyleBackColor = true;
            this.btn_Cpf.Click += new System.EventHandler(this.btn_Cpf_Click);
            // 
            // btn_Qtd
            // 
            this.btn_Qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Qtd.Location = new System.Drawing.Point(150, 652);
            this.btn_Qtd.Name = "btn_Qtd";
            this.btn_Qtd.Size = new System.Drawing.Size(117, 47);
            this.btn_Qtd.TabIndex = 28;
            this.btn_Qtd.Text = "QUANTIDADE [F3]";
            this.btn_Qtd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Qtd.UseVisualStyleBackColor = true;
            this.btn_Qtd.Click += new System.EventHandler(this.btn_Qtd_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Excluir.Location = new System.Drawing.Point(150, 705);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(117, 47);
            this.btn_Excluir.TabIndex = 29;
            this.btn_Excluir.Text = "EXCLUIR [F4]";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Cod_Barras);
            this.panel2.Controls.Add(this.PrecoUni);
            this.panel2.Controls.Add(this.lb_PrecoUni);
            this.panel2.Controls.Add(this.txtb_CodBarras);
            this.panel2.Controls.Add(this.lbl_PrecoTotalProduto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(355, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 300);
            this.panel2.TabIndex = 31;
            // 
            // pn_fnz
            // 
            this.pn_fnz.Controls.Add(this.label6);
            this.pn_fnz.Location = new System.Drawing.Point(12, 136);
            this.pn_fnz.Name = "pn_fnz";
            this.pn_fnz.Size = new System.Drawing.Size(337, 297);
            this.pn_fnz.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.PrecoTotal);
            this.panel4.Controls.Add(this.lb_PrecoTotal);
            this.panel4.Location = new System.Drawing.Point(712, 642);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(506, 49);
            this.panel4.TabIndex = 33;
            // 
            // btn_NovaCompra
            // 
            this.btn_NovaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_NovaCompra.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_NovaCompra.Location = new System.Drawing.Point(592, 652);
            this.btn_NovaCompra.Name = "btn_NovaCompra";
            this.btn_NovaCompra.Size = new System.Drawing.Size(114, 47);
            this.btn_NovaCompra.TabIndex = 34;
            this.btn_NovaCompra.Text = "NOVA COMPRA[11]";
            this.btn_NovaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NovaCompra.UseVisualStyleBackColor = true;
            this.btn_NovaCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Dinheiro
            // 
            this.btn_Dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dinheiro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Dinheiro.Location = new System.Drawing.Point(273, 652);
            this.btn_Dinheiro.Name = "btn_Dinheiro";
            this.btn_Dinheiro.Size = new System.Drawing.Size(118, 47);
            this.btn_Dinheiro.TabIndex = 35;
            this.btn_Dinheiro.Text = "PAGAMENTO DINHEIRO [F8]";
            this.btn_Dinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dinheiro.UseVisualStyleBackColor = true;
            this.btn_Dinheiro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Debito
            // 
            this.btn_Debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Debito.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Debito.Location = new System.Drawing.Point(273, 705);
            this.btn_Debito.Name = "btn_Debito";
            this.btn_Debito.Size = new System.Drawing.Size(118, 47);
            this.btn_Debito.TabIndex = 36;
            this.btn_Debito.Text = "PAGAMENTO DÉBITO [F9]";
            this.btn_Debito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Debito.UseVisualStyleBackColor = true;
            this.btn_Debito.Click += new System.EventHandler(this.btn_Debito_Click);
            // 
            // btn_Credito
            // 
            this.btn_Credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Credito.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Credito.Location = new System.Drawing.Point(397, 652);
            this.btn_Credito.Name = "btn_Credito";
            this.btn_Credito.Size = new System.Drawing.Size(114, 47);
            this.btn_Credito.TabIndex = 37;
            this.btn_Credito.Text = "PAGAMENTO CRÉDITO [10]";
            this.btn_Credito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Credito.UseVisualStyleBackColor = true;
            this.btn_Credito.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtb_Recebido
            // 
            this.txtb_Recebido.Location = new System.Drawing.Point(28, 47);
            this.txtb_Recebido.Name = "txtb_Recebido";
            this.txtb_Recebido.Size = new System.Drawing.Size(170, 20);
            this.txtb_Recebido.TabIndex = 38;
            this.txtb_Recebido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_Recebido_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtb_troco
            // 
            this.txtb_troco.Location = new System.Drawing.Point(288, 47);
            this.txtb_troco.Name = "txtb_troco";
            this.txtb_troco.Size = new System.Drawing.Size(170, 20);
            this.txtb_troco.TabIndex = 40;
            this.txtb_troco.Visible = false;
            this.txtb_troco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_troco_KeyUp);
            // 
            // pn_Troco
            // 
            this.pn_Troco.Controls.Add(this.lb_Troco);
            this.pn_Troco.Controls.Add(this.lb_Recebido);
            this.pn_Troco.Controls.Add(this.txtb_troco);
            this.pn_Troco.Controls.Add(this.txtb_Recebido);
            this.pn_Troco.Location = new System.Drawing.Point(715, 709);
            this.pn_Troco.Name = "pn_Troco";
            this.pn_Troco.Size = new System.Drawing.Size(491, 70);
            this.pn_Troco.TabIndex = 41;
            this.pn_Troco.Visible = false;
            // 
            // lb_Troco
            // 
            this.lb_Troco.AutoSize = true;
            this.lb_Troco.Location = new System.Drawing.Point(346, 13);
            this.lb_Troco.Name = "lb_Troco";
            this.lb_Troco.Size = new System.Drawing.Size(45, 13);
            this.lb_Troco.TabIndex = 44;
            this.lb_Troco.Text = "TROCO";
            this.lb_Troco.Visible = false;
            // 
            // lb_Recebido
            // 
            this.lb_Recebido.AutoSize = true;
            this.lb_Recebido.Location = new System.Drawing.Point(80, 13);
            this.lb_Recebido.Name = "lb_Recebido";
            this.lb_Recebido.Size = new System.Drawing.Size(62, 13);
            this.lb_Recebido.TabIndex = 43;
            this.lb_Recebido.Text = "RECEBIDO";
            // 
            // txtb_Suporte
            // 
            this.txtb_Suporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb_Suporte.Location = new System.Drawing.Point(1225, 759);
            this.txtb_Suporte.Name = "txtb_Suporte";
            this.txtb_Suporte.Size = new System.Drawing.Size(16, 13);
            this.txtb_Suporte.TabIndex = 45;
            this.txtb_Suporte.Visible = false;
            this.txtb_Suporte.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_suporte_KeyUp);
            // 
            // lb_Enter
            // 
            this.lb_Enter.AutoSize = true;
            this.lb_Enter.Location = new System.Drawing.Point(589, 756);
            this.lb_Enter.Name = "lb_Enter";
            this.lb_Enter.Size = new System.Drawing.Size(125, 13);
            this.lb_Enter.TabIndex = 46;
            this.lb_Enter.Text = "Favor pressionar ENTER";
            this.lb_Enter.Visible = false;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1240, 781);
            this.Controls.Add(this.lb_Enter);
            this.Controls.Add(this.txtb_Suporte);
            this.Controls.Add(this.pn_Troco);
            this.Controls.Add(this.btn_Credito);
            this.Controls.Add(this.btn_Debito);
            this.Controls.Add(this.btn_Dinheiro);
            this.Controls.Add(this.btn_NovaCompra);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pn_fnz);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Qtd);
            this.Controls.Add(this.btn_Cpf);
            this.Controls.Add(this.btn_CodBarras);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_NomeProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAIXA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_CodBarras_KeyUp);
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
            this.pn_Troco.ResumeLayout(false);
            this.pn_Troco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_NomeProduto;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.Label PrecoTotal;
        private System.Windows.Forms.Label PrecoUni;
        private System.Windows.Forms.ListBox lst_Produtos;
        private System.Windows.Forms.Label lb_PrecoUni;
        private System.Windows.Forms.Label Cod_Barras;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public System.Windows.Forms.TextBox txtb_CodBarras;
        private System.Windows.Forms.TextBox txtb_Quantidade;
        private System.Windows.Forms.Label lbl_PrecoTotalProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_Excluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Excluir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_CodBarras;
        private System.Windows.Forms.Button btn_Cpf;
        private System.Windows.Forms.Button btn_Qtd;
        private System.Windows.Forms.Button btn_Excluir;
        public System.Windows.Forms.Label lb_PrecoTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel pn_fnz;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_NovaCompra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Dinheiro;
        private System.Windows.Forms.Button btn_Debito;
        private System.Windows.Forms.Button btn_Credito;
        private System.Windows.Forms.TextBox txtb_Recebido;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtb_troco;
        private System.Windows.Forms.Panel pn_Troco;
        private System.Windows.Forms.Label lb_Recebido;
        private System.Windows.Forms.Label lb_Troco;
        private System.Windows.Forms.TextBox txtb_Suporte;
        private System.Windows.Forms.Label lb_Enter;
    }
}