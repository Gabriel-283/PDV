using System;
using System.Security;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Caixa_Mercado
{
    class ComercialInvoice
    {

        private string paymentForm;
        public string PaymentForm
        {
            get { return paymentForm; }
            set { paymentForm = value; }
        }

        private int installments;

        public int Installments
        {
            get { return installments; }
            set { installments = value; }
        }


        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        private double moneyReturn;

        public double MoneyReturn
        {
            get { return moneyReturn; }
            set { moneyReturn = value; }
        }


        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string[] Order = new string[76];



        string Day = DateTime.Now.ToString(" dd_MM -H;mm");
        string Hour = DateTime.Now.ToString("00;00;00");
        public void AddOrderToList(string[] args)
        {

            for (int i = 0; i <= 3; i++)
            {
                System.Windows.Forms.MessageBox.Show("1" + args[i]);
            }


        }

        public void CreateReceipt(string[] args)
        {
            System.Windows.Forms.MessageBox.Show(this.PaymentForm);
            string Name = "NF_" + Convert.ToString(Day) + ".pdf";
            string DocumentName = @"C:\Minhas NF\" + Name;
            string Na = args[1];
            FileStream ArchivePdf = new FileStream(DocumentName, FileMode.Create, FileAccess.Write);
            Document DocumentReceipt = new Document(PageSize.A4);
            PdfWriter write = PdfWriter.GetInstance(DocumentReceipt, ArchivePdf);

            DocumentReceipt.Open();
            string Date = "";

            Paragraph header = new Paragraph(Date, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            Paragraph clientParagraph = new Paragraph(Date, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Bold));
            Paragraph divider = new Paragraph(Date, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            Paragraph Final = new Paragraph(Date, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));


            header.Alignment = Element.ALIGN_CENTER;
            clientParagraph.Alignment = Element.ALIGN_LEFT;
            clientParagraph.Alignment = Element.ALIGN_RIGHT;

            header.Add("SUA LOJA AQUI\n");
            header.Add("SEU ENDERECO: R.xxxxxx N:123 \n");
            header.Add("CNPJ: 12345678/0000");
            divider.Add("---------------------------------------\n");
            if (Cpf != null)
            {
                clientParagraph.Add("CPF: " + Cpf);
            }

            Paragraph body = new Paragraph(Date, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, (int)System.Drawing.FontStyle.Bold));
            for (int i = 0; i < 5; i++)
            {
                body.Add(args[i] + "\n");
            }
            if (this.PaymentForm == "Crédito")
            {
                body.Add("pagamento: " + this.PaymentForm + "\n");
                body.Add("parcela: " + this.installments);
            }
            else if (this.PaymentForm == "Dinheiro")
            {
                body.Add("pagamento: " + this.PaymentForm + "\n");
                body.Add("troco: " + this.MoneyReturn.ToString("C"));
            }
            else
            {
                body.Add("pagamento: " + this.PaymentForm);
            }

            Final.Add("TOTAL: " + this.Total.ToString("C"));




            body.Add("");
            DocumentReceipt.Add(header);
            DocumentReceipt.Add(clientParagraph);
            DocumentReceipt.Add(divider);
            DocumentReceipt.Add(body);
            DocumentReceipt.Add(Final);
            DocumentReceipt.Close();

            System.Windows.Forms.MessageBox.Show("Compra concluida com Sucesso");
        }



    }
}
