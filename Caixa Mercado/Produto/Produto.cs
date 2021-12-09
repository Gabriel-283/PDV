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
    public partial class lst_Produto : Form
    {

        public lst_Produto()
        {
            InitializeComponent();
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            txtb_busca.Select();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            
                try
                {

                    using (SqlConnection con = new SqlConnection(Conn.StrCon))
                    {
                        con.Open();
                        var sql = "INSERT INTO tbl_Produtos(ID_Produto, Nome_Produto, Preco) VALUES (@Id, @nome, @preco)";



                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {

                            cmd.Parameters.AddWithValue("@nome", this.txtb_Nome.Text);
                            cmd.Parameters.AddWithValue("@Id", this.txtb_Id.Text);
                            cmd.Parameters.AddWithValue("@preco", this.txtb_preco.Text);
                            cmd.ExecuteNonQuery();




                        }

                    }


                    MessageBox.Show("tudo certo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {

                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {

                        cn.Close();

                    }


                }



        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            

            if (txtb_busca.Text == "")
            {
                try
                {
                    using (SqlConnection Cn = new SqlConnection(Conn.StrCon))
                    {
                        Cn.Open();

                        String sqlQuery = "SELECT * FROM tbl_Produtos ";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, Cn))
                        {
                            using (DataTable tb = new DataTable())
                            {
                                da.Fill(tb);
                                dataGridView1.DataSource = tb;
                            }

                        }
                    }

                    txtb_busca.Clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection Cn = new SqlConnection(Conn.StrCon))
                    {
                        Cn.Open();
                        var sql = "SELECT * FROM tbl_Produtos WHERE ID_Produto= '" + txtb_busca.Text + "'";
                        using (SqlDataAdapter da = new SqlDataAdapter(sql, Cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }


                        }

                        //var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                        var tst = Convert.ToInt64 ( txtb_busca.Text);



                        var sql2 = "SELECT * FROM tbl_produtos WHERE ID_Produto= '" + tst + "'";


                        using (SqlCommand cmd = new SqlCommand(sql, Cn))
                        {
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.HasRows)
                                {
                                    if (dr.Read())
                                    {
                                        txtb_Id.Text = dr["ID_Produto"].ToString();
                                        txtb_Nome.Text = dr["Nome_Produto"].ToString();
                                        txtb_preco.Text = dr["preco"].ToString();


                                    }


                                }


                            }


                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                finally
                {

                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {

                        cn.Close();

                    }


                }


            }
        }

        public void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    var sql = "UPDATE tbl_Produtos SET Nome_produto= @nome, ID_Produto= @Id, Preco= @preco WHERE Id_Produto=" + txtb_busca.Text;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nome", this.txtb_Nome.Text);
                        cmd.Parameters.AddWithValue("@Id", this.txtb_Id.Text);
                        float tst = float.Parse(txtb_preco.Text);
                        cmd.Parameters.AddWithValue("@preco", tst);

                        cmd.ExecuteNonQuery();

                    }

                    
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("falha ao excluir produto"+ex.Message);
            }





        }

        private void txtb_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_preco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                   
                    var sql = "DELETE from tbl_Produtos Where Id_Produto=" + txtb_busca.Text;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        MessageBox.Show("Produto apagado");
                        txtb_busca.Clear();
                        txtb_Id.Clear();
                        txtb_Nome.Clear();
                        txtb_preco.Clear();

                        cmd.ExecuteNonQuery();
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
