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
        private string user;
        private string acessibility;
        public string Acessibility
        {
            get { return acessibility; }
            set { acessibility = value; }
        }
        public Login()
        {
            InitializeComponent();

        }
        private void BtnClick(object sender, EventArgs e)
        {
            try
            {


                using (SqlConnection conectionDataBase = new SqlConnection(DataBaseUserConection.stringConection))
                {
                    conectionDataBase.Open();
                    var sqlQuery = "SELECT * FROM Usuario  WHERE  usuario = '" + txtbUser.Text + "'" + "AND senha= '" + txtbPassword.Text + "'";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, conectionDataBase))
                    {
                        DataTable workTable = new DataTable();

                        dataAdapter.Fill(workTable);
                       
                        if (workTable.Rows.Count == 1)
                        {
                            using (SqlCommand comand = new SqlCommand(sqlQuery, conectionDataBase))
                            {
                                using (SqlDataReader readData = comand.ExecuteReader())
                                {
                                    if (readData.HasRows)
                                    {
                                        if (readData.Read())
                                        {
                                            user = readData["nome"].ToString();
                                            Acessibility = readData["tipo"].ToString();
                                            MessageBox.Show("BEM VINDO " + user.ToUpper());
                                            home home = new home(Acessibility);
                                            MessageBox.Show("BEM VINDO "+user);
                                            Login login = new Login();
                                            login.Close();
                                            home.Show();
                                            conectionDataBase.Close();
                                        }

                                    }
                                }
                            }
                        }

                        else if (workTable.Rows.Count != 1)
                        {
                            MessageBox.Show("Usuario ou senha incorreto, favor tentar novamente");
                            txtbUser.Clear();
                            txtbPassword.Clear();
                            txtbUser.Select();
                            conectionDataBase.Close();
                        }

                    }
                }

            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        }

    }
