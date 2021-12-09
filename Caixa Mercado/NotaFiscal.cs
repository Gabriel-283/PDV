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
    class NotaFiscal
    {
     
        private string pagamento;
        public string Pagamento 
        {
            
            get { return pagamento; }
            set { pagamento = value; }
        }

        private int parcelamento;

        public int Parcelamento
        {
            get { return parcelamento; }
            set { parcelamento = value; }
        }


        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        private double troco;

        public double Troco 
        {
            get { return troco; }
            set { troco = value; }
        }


        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string[] pedi = new string[76];

        private string tst;

        public string Tst
        {
            get { return tst; }
            set { tst = value; }
        }

        

        string dia = DateTime.Now.ToString(" dd_MM -H;mm");
        string hora = DateTime.Now.ToString("00;00;00");
        //string nome_arquivo = "NF_"+ dia;
        public void teste(string[] args) 
        {

            for (int i=0;i<=3;i++) {
                System.Windows.Forms.MessageBox.Show("1" + args[i]);
            }


        }
 
        public void Emitir(string[] args) 
        {
            System.Windows.Forms.MessageBox.Show(this.Pagamento);
            string nm = "NF_"+Convert.ToString(dia)+".pdf";
            string nome_arquivo = @"C:\Minhas NF\"+ nm;
            string na = args[1];
            FileStream arquivo_pdf = new FileStream(nome_arquivo,FileMode.Create, FileAccess.Write);
            Document doc = new Document(PageSize.A4);
            PdfWriter escreve = PdfWriter.GetInstance(doc,arquivo_pdf);

            doc.Open();
            string dados = "";

            Paragraph paragrafo_Cabeca = new Paragraph(dados,new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,14, (int)System.Drawing.FontStyle.Bold));
            Paragraph paragrafo_cliente = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Bold));
            Paragraph divisoria = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            Paragraph Final = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));


            paragrafo_Cabeca.Alignment = Element.ALIGN_CENTER;
            paragrafo_cliente.Alignment = Element.ALIGN_LEFT;
            paragrafo_cliente.Alignment = Element.ALIGN_RIGHT;

            paragrafo_Cabeca.Add("SUA LOJA AQUI\n" );
            paragrafo_Cabeca.Add("SEU ENDERECO: R.xxxxxx N:123 \n");
            paragrafo_Cabeca.Add("CNPJ: 12345678/0000");
            divisoria.Add("---------------------------------------\n");
            if (Cpf != null)
            {
                paragrafo_cliente.Add("CPF: " + Cpf);
            }

            Paragraph paragrafo_body = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, (int)System.Drawing.FontStyle.Bold));
            for (int i=0; i< 5; i++) 
            {
                paragrafo_body.Add(args[i]+ "\n");
            }
            if (this.Pagamento == "Crédito")
            {
                paragrafo_body.Add("pagamento: " + this.Pagamento + "\n");
                paragrafo_body.Add("parcela: " + this.parcelamento);
            }
            else if (this.Pagamento == "Dinheiro")
            {
                paragrafo_body.Add("pagamento: " + this.Pagamento + "\n");
                paragrafo_body.Add("troco: " + this.troco.ToString("C"));
            }
            else
            {
                paragrafo_body.Add("pagamento: " + this.Pagamento);
            }
            
            Final.Add("TOTAL: "+ this.Total.ToString("C"));

            
            

            paragrafo_body.Add("");
            doc.Add(paragrafo_Cabeca);
            doc.Add(paragrafo_cliente);
            doc.Add(divisoria);
            doc.Add(paragrafo_body);
            doc.Add(Final);
            doc.Close();

            System.Windows.Forms.MessageBox.Show("Compra concluida com Sucesso");
        }

       

    }
}
