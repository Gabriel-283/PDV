using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Mercado
{
    public partial class Cadastra : Form
    {
        public Cadastra()
        {
            InitializeComponent();
        }


        private void btnRegisterClick(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conectionDataBase = new SqlConnection(DataBaseUserConection.stringConection))
                {
                    conectionDataBase.Open();
                    var sqlQuery = "INSERT INTO Usuario(usuario, nome,senha, tipo ) VALUES (@Usuario, @Nome, @Senha, @Tipo)";

                    using (SqlCommand comand = new SqlCommand(sqlQuery, conectionDataBase))
                    {
                        comand.Parameters.AddWithValue("@Usuario", this.txtbUser.Text);
                        comand.Parameters.AddWithValue("@Nome", this.txtbName.Text);
                        comand.Parameters.AddWithValue("@Senha", this.txtbPassword.Text);
                        comand.Parameters.AddWithValue("@Tipo", this.cmbTypeAccess.Text);
                        comand.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            finally
            {
                using (SqlConnection conectionDataBase = new SqlConnection(DataBaseUserConection.stringConection))
                {
                    conectionDataBase.Close();
                }
            }

        }

        private void btnExcludeClick(object sender, EventArgs e)
        {

            try
            {

                using (SqlConnection conectionDataBase = new SqlConnection(DataBaseUserConection.stringConection))
                {
                    conectionDataBase.Open();

                    var sqlQuery = "DELETE from Usuario Where usuario=" + txtbName.Text;
                    using (SqlCommand comand = new SqlCommand(sqlQuery, conectionDataBase))
                    {
                        MessageBox.Show("Usuario Excluido");
                        txtbName.Clear();
                        txtbUser.Clear();
                        txtbPassword.Clear();

                        comand.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            finally
            {
                using (SqlConnection conectionDataBase = new SqlConnection(DataBaseUserConection.stringConection))
                {
                    conectionDataBase.Close();
                }
            }
        }
    }
}