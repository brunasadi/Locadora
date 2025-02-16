using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Locadora
{
    public partial class Formmarca : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_locadora_2metec_2023"].ConnectionString;
        public Formmarca()
        {
            InitializeComponent();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome;
                nome = txtnome.Text;

                if (nome == string.Empty)
                {
                    MessageBox.Show("Não foi possivel realizar o cadastro");
                }
                else
                {
                    string sql_insert = @"insert into tb_marca(
                tb_marca_nome
                )value(
                @marca_nome
                )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);
                    executacmdMySql_insert.Parameters.AddWithValue("@marca_nome", nome);
                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();

                    string sql_select_marca = "select*from tb_marca";
                    MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
                    executacmdMySql_select_marca.ExecuteNonQuery();
                    DataTable tabela_marca = new DataTable();
                    MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
                    da_marca.Fill(tabela_marca);

                    dgv_marca.DataSource = tabela_marca;



                    con.Close();
                    MessageBox.Show("Cadastrado!");
                }

               
               
                
                // txtnome.Text=string.Empty;//
                txtnome.Text = string.Empty;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);


            }

        }

        private void Formmarca_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_marca = "select*from tb_marca";
            MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_marca = new DataTable();
            MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
            da_marca.Fill(tabela_marca);

            dgv_marca.DataSource = tabela_marca;

            dgv_marca.Columns["tb_marca_id"].HeaderText = "ID";
            dgv_marca.Columns["tb_marca_nome"].HeaderText = "Nome";

            con.Close();
        }

        
            private void dgv_marca_CellClick_1(object sender, DataGridViewCellEventArgs e)
            {

            txtid.Text = dgv_marca.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgv_marca.CurrentRow.Cells[1].Value.ToString();
        }

            private void btnatualizar_Click(object sender, EventArgs e)
        {
            int codigo;
            string nome;

            codigo = int.Parse(txtid.Text);
            nome = txtnome.Text;


            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            //variavel strig que ira receber comando sql
            string sql_update_marca = @"update tb_marca
                        set tb_marca_nome=@nome
                where tb_marca_id=@id";

            MySqlCommand executacmdMySql_update_marca = new MySqlCommand(sql_update_marca, con);

            executacmdMySql_update_marca.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_marca.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_marca.ExecuteNonQuery();

            string sql_select_marca = "select*from tb_marca";
            MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_marca = new DataTable();
            MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
            da_marca.Fill(tabela_marca);

            dgv_marca.DataSource = tabela_marca;


            MessageBox.Show("Atualização realizada com sucesso");

            con.Close();
            txtnome.Text = string.Empty;
            txtid.Text = string.Empty;

        }

        private void dgv_marca_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btncad.Enabled = false;
        }

        private void btnatualizar_MouseClick(object sender, MouseEventArgs e)
        {
            btncad.Enabled = true;
        }

        private void btndeletar_MouseClick(object sender, MouseEventArgs e)
        {
            btncad.Enabled = true;
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            string codigo;
            codigo = (txtid.Text);


            if (txtid.Text == String.Empty)
            {
                MessageBox.Show("Não é possivel apagar campos vazios");
            }





            DialogResult dialogResult = MessageBox.Show("Deseja Apagar?", "Deseja Apagar?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();


                string sql_delete_marca = @"delete from tb_marca where tb_marca_id=@codigo";
                MySqlCommand executacmdMySql_delete_marca = new MySqlCommand(sql_delete_marca, con);
                executacmdMySql_delete_marca.Parameters.AddWithValue("@codigo", codigo);
                executacmdMySql_delete_marca.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado co sucesso");

                string sql_select_marca = "select*from tb_marca";
                MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
                executacmdMySql_select_marca.ExecuteNonQuery();

                DataTable tabela_marca = new DataTable();
                MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
                da_marca.Fill(tabela_marca);
                con.Close();

                dgv_marca.DataSource = tabela_marca;
            }

            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            txtnome.Text = string.Empty;
            txtid.Text = string.Empty;
        }

        private void txtpesq_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_marca = "select*from tb_marca;";
            MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_marca = new DataTable();
            MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
            da_marca.Fill(tabela_marca);
            dgv_marca.DataSource = tabela_marca;




            con.Close();

            BindingSource bgs = new BindingSource();

            bgs.DataSource = dgv_marca.DataSource;


            bgs.Filter = "CONVERT(tb_marca_nome, 'System.String')like '%" + txtpesq.Text + "%'";
            dgv_marca.DataSource = bgs.DataSource;
        }
    }
    }
 
 
