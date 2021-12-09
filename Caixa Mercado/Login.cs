using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Caixa_Mercado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn_user.StrCon))
                {
                    cn.Open();
                    var sql = "SELECT * FROM Usuario  WHERE  usuario = '" + txtb_Usuario.Text + "'" + "AND senha= '" + txtb_Senha.Text + "'";

                    using (SqlDataAdapter dp = new SqlDataAdapter(sql, cn))
                    {
                        DataTable dt = new DataTable();

                        dp.Fill(dt);


                        if (dt.Rows.Count == 1)
                        {

                            MessageBox.Show("Okay");
                            home hm = new home();
                            Login lg = new Login();
                            lg.Close();
                            hm.Show();
                            cn.Close();
                        }

                        else if (dt.Rows.Count != 1) 
                        {
                            MessageBox.Show("Usuario ou senha incorreto, favor tentar novamente");
                            txtb_Usuario.Clear();
                            txtb_Senha.Clear();
                            txtb_Usuario.Select();
                            cn.Close();
                        }

                    }
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
