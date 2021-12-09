
namespace Caixa_Mercado
{
    partial class Fnz
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
            this.pn_Troco = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_trc = new System.Windows.Forms.Label();
            this.lb_Troco = new System.Windows.Forms.Label();
            this.txtb_recebido = new System.Windows.Forms.TextBox();
            this.lb_recebido = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Dinheiro = new System.Windows.Forms.Button();
            this.lb_Total = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_Troco.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Troco
            // 
            this.pn_Troco.Controls.Add(this.panel1);
            this.pn_Troco.Controls.Add(this.lb_Troco);
            this.pn_Troco.Controls.Add(this.txtb_recebido);
            this.pn_Troco.Controls.Add(this.lb_recebido);
            this.pn_Troco.Location = new System.Drawing.Point(12, 89);
            this.pn_Troco.Name = "pn_Troco";
            this.pn_Troco.Size = new System.Drawing.Size(304, 73);
            this.pn_Troco.TabIndex = 37;
            this.pn_Troco.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_trc);
            this.panel1.Location = new System.Drawing.Point(183, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 26);
            this.panel1.TabIndex = 4;
            // 
            // lb_trc
            // 
            this.lb_trc.AutoSize = true;
            this.lb_trc.Location = new System.Drawing.Point(37, 9);
            this.lb_trc.Name = "lb_trc";
            this.lb_trc.Size = new System.Drawing.Size(0, 13);
            this.lb_trc.TabIndex = 3;
            // 
            // lb_Troco
            // 
            this.lb_Troco.AutoSize = true;
            this.lb_Troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Troco.Location = new System.Drawing.Point(187, 0);
            this.lb_Troco.Name = "lb_Troco";
            this.lb_Troco.Size = new System.Drawing.Size(56, 16);
            this.lb_Troco.TabIndex = 2;
            this.lb_Troco.Text = "TROCO";
            // 
            // txtb_recebido
            // 
            this.txtb_recebido.Location = new System.Drawing.Point(18, 27);
            this.txtb_recebido.Name = "txtb_recebido";
            this.txtb_recebido.Size = new System.Drawing.Size(111, 20);
            this.txtb_recebido.TabIndex = 1;
            this.txtb_recebido.TextChanged += new System.EventHandler(this.txtb_recebido_TextChanged_1);
            this.txtb_recebido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_recebido_KeyUp_1);
            // 
            // lb_recebido
            // 
            this.lb_recebido.AutoSize = true;
            this.lb_recebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_recebido.Location = new System.Drawing.Point(31, 0);
            this.lb_recebido.Name = "lb_recebido";
            this.lb_recebido.Size = new System.Drawing.Size(77, 16);
            this.lb_recebido.TabIndex = 0;
            this.lb_recebido.Text = "RECEBIDO";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 47);
            this.button3.TabIndex = 36;
            this.button3.Text = "CREDITO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 47);
            this.button2.TabIndex = 35;
            this.button2.Text = "DEBITO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_Dinheiro
            // 
            this.btn_Dinheiro.Location = new System.Drawing.Point(12, 12);
            this.btn_Dinheiro.Name = "btn_Dinheiro";
            this.btn_Dinheiro.Size = new System.Drawing.Size(82, 47);
            this.btn_Dinheiro.TabIndex = 34;
            this.btn_Dinheiro.Text = "DINHEIRO";
            this.btn_Dinheiro.UseVisualStyleBackColor = true;
            this.btn_Dinheiro.Click += new System.EventHandler(this.btn_Dinheiro_Click);
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.Location = new System.Drawing.Point(249, 225);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(0, 24);
            this.lb_Total.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Fnz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 258);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.pn_Troco);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Dinheiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fnz";
            this.Text = "Fnz";
            this.Load += new System.EventHandler(this.Fnz_Load);
            this.pn_Troco.ResumeLayout(false);
            this.pn_Troco.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Troco;
        private System.Windows.Forms.Label lb_trc;
        private System.Windows.Forms.Label lb_Troco;
        private System.Windows.Forms.TextBox txtb_recebido;
        private System.Windows.Forms.Label lb_recebido;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Dinheiro;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}