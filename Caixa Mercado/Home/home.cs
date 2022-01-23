using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Mercado
{
    public partial class home : Form
    {
        Form formOpen;
        string acessibility;
        
        private void OpenForm(Form formToOpen)
        {
            formOpen = formToOpen;
            formToOpen.TopLevel = false;
            pnPrincipal.Controls.Add(formToOpen);
            formToOpen.BringToFront();
            formToOpen.Show();
        }

        private void Close(Form formToOpen) 
        {
            if (formToOpen != null)
                formToOpen.Close();
        }

        public home(string access)
        {
            InitializeComponent();
            acessibility = access;
        }

        private void BtnCheckoutClick(object sender, EventArgs e)
        {
            OpenForm(new Checkout());
        }

        private void BtnProductClick(object sender, EventArgs e)
        {
            OpenForm(new lst_product());           
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            try
            {
                if (acessibility == "Admin")
                {
                    OpenForm(new Login());
                }
                else
                {
                    MessageBox.Show("OPCAO DISPONIVEL APENAS PARA ADMINISTRADORES/ OPTION FOR ADMINISTRATORS ONLY");
                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void HomeKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { MessageBox.Show("ok"); }
        }

    }
}
