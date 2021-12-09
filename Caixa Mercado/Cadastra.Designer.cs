
namespace Caixa_Mercado
{
    partial class Cadastra
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
            this.Prod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Prod
            // 
            this.Prod.AutoSize = true;
            this.Prod.Location = new System.Drawing.Point(133, 247);
            this.Prod.Name = "Prod";
            this.Prod.Size = new System.Drawing.Size(49, 13);
            this.Prod.TabIndex = 2;
            this.Prod.Text = "Cadastra";
            // 
            // Cadastra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(568, 672);
            this.Controls.Add(this.Prod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastra";
            this.Text = "Cadastra";
            this.Load += new System.EventHandler(this.Cadastra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cadastra_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prod;
    }
}