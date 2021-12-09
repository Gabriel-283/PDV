
namespace Caixa_Mercado
{
    partial class lst_Produto
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
            this.btn_Novo = new System.Windows.Forms.Button();
            this.txtb_Nome = new System.Windows.Forms.TextBox();
            this.txtb_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_preco = new System.Windows.Forms.TextBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.txtb_busca = new System.Windows.Forms.TextBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(245, 60);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(117, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // txtb_Nome
            // 
            this.txtb_Nome.Location = new System.Drawing.Point(12, 101);
            this.txtb_Nome.Name = "txtb_Nome";
            this.txtb_Nome.Size = new System.Drawing.Size(149, 20);
            this.txtb_Nome.TabIndex = 1;
            this.txtb_Nome.TextChanged += new System.EventHandler(this.txtb_Nome_TextChanged);
            // 
            // txtb_Id
            // 
            this.txtb_Id.Location = new System.Drawing.Point(12, 61);
            this.txtb_Id.Name = "txtb_Id";
            this.txtb_Id.Size = new System.Drawing.Size(149, 20);
            this.txtb_Id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código de Barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preco";
            // 
            // txtb_preco
            // 
            this.txtb_preco.Location = new System.Drawing.Point(9, 142);
            this.txtb_preco.Name = "txtb_preco";
            this.txtb_preco.Size = new System.Drawing.Size(149, 20);
            this.txtb_preco.TabIndex = 5;
            this.txtb_preco.TextChanged += new System.EventHandler(this.txtb_preco_TextChanged);
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(1098, 365);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(117, 23);
            this.btn_consulta.TabIndex = 8;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(730, 394);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 281);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(247, 98);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(117, 23);
            this.btn_Alterar.TabIndex = 10;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // txtb_busca
            // 
            this.txtb_busca.Location = new System.Drawing.Point(834, 367);
            this.txtb_busca.Name = "txtb_busca";
            this.txtb_busca.Size = new System.Drawing.Size(237, 20);
            this.txtb_busca.TabIndex = 11;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(245, 142);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(117, 23);
            this.btn_Excluir.TabIndex = 12;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // lst_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1240, 781);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.txtb_busca);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_preco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_Id);
            this.Controls.Add(this.txtb_Nome);
            this.Controls.Add(this.btn_Novo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lst_Produto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.TextBox txtb_Nome;
        private System.Windows.Forms.TextBox txtb_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_preco;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.TextBox txtb_busca;
        private System.Windows.Forms.Button btn_Excluir;
    }
}