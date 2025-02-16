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
    public partial class Formfuncionario : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_locadora_2metec_2023"].ConnectionString;
        public Formfuncionario()
        {
            InitializeComponent();
        }
        private void dtpcontrat_ValueChanged(object sender, EventArgs e)
        {
            dtpcontrat.Format = DateTimePickerFormat.Custom;

            dtpcontrat.CustomFormat = "yyyy-MM-dd";
        }

        private void dtcontrat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dtpcontrat.CustomFormat = " ";
            }
        }


        private void btncadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome, tel, idcargo, dtcontrat;


                nome = txtnome.Text;
                tel = txttel.Text;
                idcargo = txtidcargo.Text;
                dtcontrat = dtpcontrat.Text;



                if (nome == string.Empty || tel == string.Empty || idcargo == string.Empty || string.IsNullOrEmpty(dtcontrat))


                {
                    MessageBox.Show("Não foi possivel realizar o cadastro");
                }

                else
                {
                    string sql_insert = @"insert into tb_funcionario
                  (TB_FUNCIONARIO_NOME,
                   TB_FUNCIONARIO_TEL,
                     TB_CARGO_ID ,
                   TB_FUNCIONARIO_DT_CONTRATO
                    
                 ) values (
                  @funcionario_nome,
                  @funcionario_tel,
                  @cargo_id,
                  @funcionario_dt_contrato
                 
                    
                         )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                    executacmdMySql_insert.Parameters.AddWithValue("@funcionario_nome", nome);
                    executacmdMySql_insert.Parameters.AddWithValue("@funcionario_tel", tel);
                    executacmdMySql_insert.Parameters.AddWithValue("@cargo_id", idcargo);
                    executacmdMySql_insert.Parameters.AddWithValue("@funcionario_dt_contrato", dtcontrat);


                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();


                    string sql_select_funcionario = "select*from tb_funcionario";
                    MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
                    executacmdMySql_select_funcionario.ExecuteNonQuery();

                    DataTable tabela_funcionario = new DataTable();
                    MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
                    da_funcionario.Fill(tabela_funcionario);


                    dgv_funcionario.DataSource = tabela_funcionario;

                    con.Close();

                    MessageBox.Show("Cadastrado!");

                    // txtnome.Text=string.Empty;//
                    txtnome.Text = string.Empty;
                    txttel.Text = string.Empty;
                    txtidcargo.Text = string.Empty;
                    dtpcontrat.Text = string.Empty;
                }





            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);


            }





        }

        private void txtpesq_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_funcionario = "select*from tb_funcionario;";
            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            executacmdMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();
            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);
            dgv_funcionario.DataSource = tabela_funcionario;




            con.Close();

            BindingSource bgs = new BindingSource();

            bgs.DataSource = dgv_funcionario.DataSource;


            bgs.Filter = "CONVERT(tb_funcionario_nome, 'System.String')like '%" + txtpesq.Text + "%'";
            dgv_funcionario.DataSource = bgs.DataSource;
        }

        private void Formfuncionario_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_funcionario = "select*from tb_funcionario";
            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            executacmdMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();
            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);

            dgv_funcionario.DataSource = tabela_funcionario;


            dgv_funcionario.Columns["tb_funcionario_id"].HeaderText = "ID";
            dgv_funcionario.Columns["tb_funcionario_nome"].HeaderText = "Nome";
            dgv_funcionario.Columns["tb_funcionario_tel"].HeaderText = "Telefone";
            dgv_funcionario.Columns["tb_cargo_id"].HeaderText = "Id do Cargo";
            dgv_funcionario.Columns["tb_funcionario_dt_contrato"].HeaderText = "Data de Contrato";




            con.Close();
        }
      
        private void dgv_funcionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgv_funcionario.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgv_funcionario.CurrentRow.Cells[1].Value.ToString();
            txttel.Text = dgv_funcionario.CurrentRow.Cells[2].Value.ToString();
            dtpcontrat.Text = dgv_funcionario.CurrentRow.Cells[3].Value.ToString();
            txtidcargo.Text = dgv_funcionario.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            int codigo;

            string nome, tel, cargoid, dtcontrat;

            codigo = int.Parse(txtid.Text); ;
            nome = txtnome.Text;
            tel = txttel.Text;
           cargoid = txtidcargo.Text;
            dtcontrat = dtpcontrat.Text;

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            //variavel strig que ira receber comando sql
            string sql_update_cliente = @"update tb_funcionario
                        set  TB_funcionario_nome= @funcionario_nome, 
                    tb_funcionario_tel=@funcionario_tel,
            tb_cargo_id =@cargo_id, 
            tb_funcionario_dt_Contrato= @funcionario_dt_contrato
                where tb_funcionario_id= @id";

            MySqlCommand executacmdMySql_update_funcionario = new MySqlCommand(sql_update_cliente, con);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@funcionario_nome", nome);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@funcionario_tel", tel);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@cargo_id", cargoid);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@funcionario_dt_contrato", dtcontrat);
            executacmdMySql_update_funcionario.ExecuteNonQuery();

            string sql_select_funcionario = "select*from tb_funcionario";
            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            executacmdMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();
            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);

            dgv_funcionario.DataSource = tabela_funcionario;


            MessageBox.Show("Atualização realizada com sucesso");

            con.Close();
            txtid.Text = string.Empty;
            txtnome.Text = string.Empty;
            txttel.Text = string.Empty;
            txtidcargo.Text = string.Empty;
            dtpcontrat.Text = string.Empty;
        }

        private void Dgv_funcionario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btncadastrar.Enabled = false;
        }

        private void Btnatualizar_MouseClick(object sender, MouseEventArgs e)
        {
            btncadastrar.Enabled = true;
        }

        private void Btndeletar_MouseClick(object sender, MouseEventArgs e)
        {
            btncadastrar.Enabled = true;
        }

        private void Btndeletar_Click(object sender, EventArgs e)
        {
            int codigo;


            codigo = int.Parse(txtid.Text); ;



            if (txtid.Text == String.Empty)
            {
                MessageBox.Show("Não é possivel apagar campos vazios");
            }





            DialogResult dialogResult = MessageBox.Show("Deseja Apagar?", "Deseja Apagar?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();


                string sql_delete_funcionario = @"delete from tb_funcionario where tb_funcionario_id=@codigo";
                MySqlCommand executacmdMySql_delete_funcionario = new MySqlCommand(sql_delete_funcionario, con);
                executacmdMySql_delete_funcionario.Parameters.AddWithValue("@codigo", codigo);
                executacmdMySql_delete_funcionario.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado co sucesso");

                string sql_select_funcionario = "select*from tb_funcionario";
                MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
                executacmdMySql_select_funcionario.ExecuteNonQuery();

                DataTable tabela_funcionario = new DataTable();
                MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
                da_funcionario.Fill(tabela_funcionario);
                con.Close();

                dgv_funcionario.DataSource = tabela_funcionario;
            }

            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            txtid.Text = string.Empty;
            txtnome.Text = string.Empty;
            txttel.Text = string.Empty;
            txtidcargo.Text = string.Empty;
            
           
        }
    }
}