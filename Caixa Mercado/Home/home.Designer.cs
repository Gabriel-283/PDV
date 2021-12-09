
namespace Caixa_Mercado
{
    partial class home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Cadastra = new System.Windows.Forms.Button();
            this.btn_Produto = new System.Windows.Forms.Button();
            this.btn_caixa = new System.Windows.Forms.Button();
            this.Painel = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SidePanel.Controls.Add(this.Cadastra);
            this.SidePanel.Controls.Add(this.btn_Produto);
            this.SidePanel.Controls.Add(this.btn_caixa);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(200, 781);
            this.SidePanel.TabIndex = 0;
            // 
            // Cadastra
            // 
            this.Cadastra.FlatAppearance.BorderSize = 0;
            this.Cadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastra.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastra.ForeColor = System.Drawing.SystemColors.Control;
            this.Cadastra.Location = new System.Drawing.Point(3, 351);
            this.Cadastra.Name = "Cadastra";
            this.Cadastra.Size = new System.Drawing.Size(194, 56);
            this.Cadastra.TabIndex = 3;
            this.Cadastra.Text = "CADASTRA";
            this.Cadastra.UseVisualStyleBackColor = true;
            this.Cadastra.Click += new System.EventHandler(this.Cadastra_Click);
            // 
            // btn_Produto
            // 
            this.btn_Produto.FlatAppearance.BorderSize = 0;
            this.btn_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Produto.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Produto.Location = new System.Drawing.Point(3, 266);
            this.btn_Produto.Name = "btn_Produto";
            this.btn_Produto.Size = new System.Drawing.Size(194, 56);
            this.btn_Produto.TabIndex = 2;
            this.btn_Produto.Text = "PRODUTO";
            this.btn_Produto.UseVisualStyleBackColor = true;
            this.btn_Produto.Click += new System.EventHandler(this.btn_Produto_Click);
            // 
            // btn_caixa
            // 
            this.btn_caixa.FlatAppearance.BorderSize = 0;
            this.btn_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_caixa.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_caixa.Location = new System.Drawing.Point(3, 167);
            this.btn_caixa.Name = "btn_caixa";
            this.btn_caixa.Size = new System.Drawing.Size(194, 56);
            this.btn_caixa.TabIndex = 1;
            this.btn_caixa.Text = "CAIXA";
            this.btn_caixa.UseVisualStyleBackColor = true;
            this.btn_caixa.Click += new System.EventHandler(this.btn_caixa_Click);
            // 
            // Painel
            // 
            this.Painel.Location = new System.Drawing.Point(200, 0);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(1240, 781);
            this.Painel.TabIndex = 4;
            this.Painel.Paint += new System.Windows.Forms.PaintEventHandler(this.Painel_Paint);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 781);
            this.Controls.Add(this.Painel);
            this.Controls.Add(this.SidePanel);
            this.Name = "home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.home_KeyUp);
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_caixa;
        private System.Windows.Forms.Button btn_Produto;
        public System.Windows.Forms.Panel SidePanel;
        public System.Windows.Forms.Panel Painel;
        private System.Windows.Forms.Button Cadastra;
    }
}

