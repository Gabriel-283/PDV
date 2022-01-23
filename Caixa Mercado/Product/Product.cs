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
    public partial class lst_product : Form
    {

        public lst_product()
        {
            InitializeComponent();
        }

        private void productLoad(object sender, EventArgs e)
        {
            txtbSearch.Select();
        }

        private void BtnNewClick(object sender, EventArgs e)
        {
            
                try
                {

                    using (SqlConnection conectionDataBase = new SqlConnection(DataBaseProductsConection.stringConection))
                    {
                    conectionDataBase.Open();
                        var sqlQuery = "INSERT INTO tbl_products(ID_product, Nome_product, Preco) VALUES (@Id, @nome, @preco)";



                        using (SqlCommand comand = new SqlCommand(sqlQuery, conectionDataBase))
                        {

                            comand.Parameters.AddWithValue("@nome", this.txtbName.Text);
                            comand.Parameters.AddWithValue("@Id", this.txtbID.Text);
                            comand.Parameters.AddWithValue("@preco", this.txtbPrice.Text);
                            comand.ExecuteNonQuery();




                        }

                    }

                    MessageBox.Show("It`s Okay");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                finally
                {

                    using (SqlConnection conectionDataBase = new SqlConnection(DataBaseProductsConection.stringConection))
                    {

                     conectionDataBase.Close();

                    }
                }

        }

        private void BtnQueryClick(object sender, EventArgs e)
        {
            

            if (txtbSearch.Text == "")
            {
                try
                {
                    using (SqlConnection conectionDataBase = new SqlConnection(DataBaseProductsConection.stringConection))
                    {
                        conectionDataBase.Open();

                        String sqlQuery = "SELECT * FROM tbl_products ";

                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, conectionDataBase))
                        {
                            using (DataTable sqlDataTable = new DataTable())
                            {
                                dataAdapter.Fill(sqlDataTable);
                                dataGridView1.DataSource = sqlDataTable;
                            }

                        }
                    }

                    txtbSearch.Clear();
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection conectionDataBase = new SqlConnection(DataBaseProductsConection.stringConection))
                    {
                        conectionDataBase.Open();
                        var sqlQuery = "SELECT * FROM tbl_products WHERE ID_product= '" + txtbSearch.Text + "'";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conectionDataBase))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }


                        }

                        var convertIdtoInt = Convert.ToInt64 ( txtbSearch.Text);

                        var sqlQuery2 = "SELECT * FROM tbl_products WHERE ID_product= '" + convertIdtoInt + "'";


                        using (SqlCommand comand = new SqlCommand(sqlQuery, conectionDataBase))
                        {
                            using (SqlDataReader readData = comand.ExecuteReader())
                            {
                                if (readData.HasRows)
                                {
                                    if (readData.Read())
                                    {
                                        txtbID.Text = readData["ID_product"].ToString();
                                        txtbName.Text = readData["Nome_product"].ToString();
                                        txtbPrice.Text = readData["preco"].ToString();

                                    }
                                }
                            }
                        }
                    }

                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }

                finally
                {

                    using (SqlConnection conectionDataBase = new SqlConnection(DataBaseProductsConection.stringConection))
                    {

                        conectionDataBase.Close();

                    }

                }
            }
        }

        public void BtnAlterClick(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conectionDataBase = new SqlConnection(DataBaseProductsConection.stringConection))
                {
                    conectionDataBase.Open();
                    var sqlQuery = "UPDATE tbl_products SET Nome_product= @nome, ID_product= @Id, Preco= @preco WHERE Id_product=" + txtbSearch.Text;
                    using (SqlCommand comand = new SqlCommand(sqlQuery, conectionDataBase))
                    {
                        comand.Parameters.AddWithValue("@nome", this.txtbName.Text);
                        comand.Parameters.AddWithValue("@Id", this.txtbID.Text);
                        float price = float.Parse(txtbPrice.Text);
                        comand.Parameters.AddWithValue("@preco", price);

                        comand.ExecuteNonQuery();

                    }

                    
                }

            }

            catch (Exception error)
            {

                MessageBox.Show("falha ao excluir product"+error.Message);
            }





        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conectionDataBase = new SqlConnection(DataBaseProductsConection.stringConection))
                {
                    conectionDataBase.Open();
                   
                    var sqlQuery = "DELETE from tbl_products Where Id_product=" + txtbSearch.Text;
                    using (SqlCommand comand = new SqlCommand(sqlQuery, conectionDataBase))
                    {
                        MessageBox.Show("product apagado");
                        txtbSearch.Clear();
                        txtbID.Clear();
                        txtbName.Clear();
                        txtbPrice.Clear();

                        comand.ExecuteNonQuery();
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
