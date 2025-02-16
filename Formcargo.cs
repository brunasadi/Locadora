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
    public partial class Formcargo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_locadora_2metec_2023"].ConnectionString;

        public Formcargo()
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

                    string sql_insert = @"insert into tb_cargo(
                tb_cargo_nome
                )value(
                @cargo_nome
                )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);
                    executacmdMySql_insert.Parameters.AddWithValue("@cargo_nome", nome);
                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();

                    string sql_select_cargo = "select*from tb_cargo";
                    MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
                    executacmdMySql_select_cargo.ExecuteNonQuery();
                    DataTable tabela_cargo = new DataTable();
                    MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                    da_cargo.Fill(tabela_cargo);

                    dgv_cargo.DataSource = tabela_cargo;



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

        private void Formcargo_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_cargo = "select*from tb_cargo";
            MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executacmdMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo = new DataTable();
            MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
            da_cargo.Fill(tabela_cargo);

            dgv_cargo.DataSource = tabela_cargo;

            dgv_cargo.Columns["tb_cargo_id"].HeaderText = "ID";
            dgv_cargo.Columns["tb_cargo_nome"].HeaderText = "Nome";

          
            con.Close();
        }

        private void dgv_cargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtid.Text = dgv_cargo.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgv_cargo.CurrentRow.Cells[1].Value.ToString();

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
            string sql_update_cargo = @"update tb_cargo
                        set tb_cargo_nome=@nome
                where tb_cargo_id=@id";

            MySqlCommand executacmdMySql_update_cargo = new MySqlCommand(sql_update_cargo, con);

            executacmdMySql_update_cargo.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_cargo.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_cargo.ExecuteNonQuery();

            string sql_select_cargo = "select*from tb_cargo";
            MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executacmdMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo = new DataTable();
            MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
            da_cargo.Fill(tabela_cargo);

            dgv_cargo.DataSource = tabela_cargo;


            MessageBox.Show("Atualização realizada com sucesso");

            con.Close();
            txtnome.Text = string.Empty;
            txtid.Text = string.Empty;

        }

        private void dgv_cargo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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


                string sql_delete_cargo = @"delete from tb_cargo where tb_cargo_id=@codigo";
                MySqlCommand executacmdMySql_delete_cargo = new MySqlCommand(sql_delete_cargo, con);
                executacmdMySql_delete_cargo.Parameters.AddWithValue("@codigo", codigo);
                executacmdMySql_delete_cargo.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado co sucesso");

                string sql_select_cargo = "select*from tb_cargo";
                MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
                executacmdMySql_select_cargo.ExecuteNonQuery();

                DataTable tabela_cargo = new DataTable();
                MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                da_cargo.Fill(tabela_cargo);
                con.Close();

                dgv_cargo.DataSource = tabela_cargo;
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

            string sql_select_cargo = "select*from tb_cargo;";
            MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executacmdMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo = new DataTable();
            MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
            da_cargo.Fill(tabela_cargo);
            dgv_cargo.DataSource = tabela_cargo;




            con.Close();

            BindingSource bgs = new BindingSource();

            bgs.DataSource = dgv_cargo.DataSource;


            bgs.Filter = "CONVERT(tb_cargo_nome, 'System.String')like '%" + txtpesq.Text + "%'";
            dgv_cargo.DataSource = bgs.DataSource;
        }
    }
}
  
