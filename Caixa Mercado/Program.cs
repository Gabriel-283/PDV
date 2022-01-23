using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Mercado
{
    public class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public void JustNumber(KeyPressEventArgs e,TextBox selectBox)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8) 
            {e.Handled= true;
             MessageBox.Show("favor apenas digitar numeros");
              selectBox.Select();
            }
        }

        
    }
}
