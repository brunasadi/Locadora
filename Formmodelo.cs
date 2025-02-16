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
    public partial class Formmodelo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_locadora_2metec_2023"].ConnectionString;
        public Formmodelo()
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
                    string sql_insert = @"insert into tb_modelo(
                tb_modelo_desc
                )value(
                @modelo_desc
                )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);
                    executacmdMySql_insert.Parameters.AddWithValue("@modelo_desc", nome);
                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();

                    string sql_select_modelo = "select*from tb_modelo";
                    MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
                    executacmdMySql_select_modelo.ExecuteNonQuery();
                    DataTable tabela_modelo = new DataTable();
                    MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
                    da_modelo.Fill(tabela_modelo);

                    dgv_modelo.DataSource = tabela_modelo;



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

        private void Formmodelo_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_modelo = "select*from tb_modelo";
            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();
            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo);

            dgv_modelo.DataSource = tabela_modelo;

            dgv_modelo.Columns["tb_modelo_id"].HeaderText = "ID";
            dgv_modelo.Columns["tb_modelo_desc"].HeaderText = "Nome";


            con.Close();
        }

        private void dgv_modelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgv_modelo.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgv_modelo.CurrentRow.Cells[1].Value.ToString();
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
            string sql_update_modelo = @"update tb_modelo
                        set tb_modelo_desc=@desc
                where tb_modelo_id=@id";

            MySqlCommand executacmdMySql_update_modelo = new MySqlCommand(sql_update_modelo, con);

            executacmdMySql_update_modelo.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_modelo.Parameters.AddWithValue("@desc", nome);
            executacmdMySql_update_modelo.ExecuteNonQuery();

            string sql_select_modelo = "select*from tb_modelo";
            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();
            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo);

            dgv_modelo.DataSource = tabela_modelo;


            MessageBox.Show("Atualização realizada com sucesso");

            con.Close();
            txtnome.Text = string.Empty;
            txtid.Text = string.Empty;

        }

        private void dgv_modelo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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


                string sql_delete_modelo = @"delete from tb_modelo where tb_modelo_id=@codigo";
                MySqlCommand executacmdMySql_delete_modelo = new MySqlCommand(sql_delete_modelo, con);
                executacmdMySql_delete_modelo.Parameters.AddWithValue("@codigo", codigo);
                executacmdMySql_delete_modelo.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado co sucesso");

                string sql_select_modelo = "select*from tb_modelo";
                MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
                executacmdMySql_select_modelo.ExecuteNonQuery();

                DataTable tabela_modelo = new DataTable();
                MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
                da_modelo.Fill(tabela_modelo);
                con.Close();

                dgv_modelo.DataSource = tabela_modelo;
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

            string sql_select_modelo = "select*from tb_modelo;";
            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();
            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo);
            dgv_modelo.DataSource = tabela_modelo;




            con.Close();

            BindingSource bgs = new BindingSource();

            bgs.DataSource = dgv_modelo.DataSource;


            bgs.Filter = "CONVERT(tb_modelo_desc, 'System.String')like '%" + txtpesq.Text + "%'";
            dgv_modelo.DataSource = bgs.DataSource;
        }
    }
}
