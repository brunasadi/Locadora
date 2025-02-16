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
    public partial class Formautomovel : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_locadora_2metec_2023"].ConnectionString;
        public Formautomovel()
        {
            InitializeComponent();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome, anofab, cor, km, val, status, idmarca, idmodelo;


                nome = txtnome.Text;
                anofab = txtanofab.Text;
                cor = txtcor.Text;
                km = txtkm.Text;
                val = txtvalor.Text;
                status = cmbstatus.Text;
                idmarca = txtidmarca.Text;
                idmodelo = txtidmodelo.Text;




                if (nome == string.Empty || cor == string.Empty || status == string.Empty || idmarca == string.Empty || idmodelo == string.Empty)


                {
                    MessageBox.Show("Não foi possivel realizar o cadastro");
                }

                else
                {
                    string sql_insert = @"insert into tb_automovel
                  (
                    TB_AUTOMOVEL_NOME, 
                    TB_AUTOMOVEL_ANO_FAB, 
                    TB_AUTOMOVEL_COR, 
                    TB_AUTOMOVEL_KM,
                    TB_AUTOMOVEL_VALOR_D,
                    TB_AUTOMOVEL_STATUS,
                     TB_MARCA_ID,
                      TB_MODELO_ID

                 ) values (
                  @automovel_nome,
                   @automovel_ano_fab,
                    @automovel_cor,
                    @automovel_km,
                    @automovel_valor_d,
                    @automovel_status,
                    @marca_id,
                    @modelo_id

                    
                         )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                    executacmdMySql_insert.Parameters.AddWithValue("@automovel_nome", nome);
                    executacmdMySql_insert.Parameters.AddWithValue("@automovel_ano_fab", anofab);
                    executacmdMySql_insert.Parameters.AddWithValue("@automovel_cor", cor);
                    executacmdMySql_insert.Parameters.AddWithValue("@automovel_km", km);
                    executacmdMySql_insert.Parameters.AddWithValue("@automovel_valor_d", val);
                    executacmdMySql_insert.Parameters.AddWithValue("@automovel_status", status);
                    executacmdMySql_insert.Parameters.AddWithValue("@marca_id", idmarca);
                    executacmdMySql_insert.Parameters.AddWithValue("@modelo_id", idmodelo);



                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();


                    string sql_select_automovel = "select*from tb_automovel";
                    MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
                    executacmdMySql_select_automovel.ExecuteNonQuery();

                    DataTable tabela_automovel = new DataTable();
                    MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
                    da_automovel.Fill(tabela_automovel);


                    dgv_automovel.DataSource = tabela_automovel;

                    con.Close();

                    MessageBox.Show("Cadastrado!");

                    // txtnome.Text=string.Empty;//
                    txtnome.Text = string.Empty;
                    txtanofab.Text = string.Empty;
                    txtcor.Text = string.Empty;
                    txtidmarca.Text = string.Empty;
                    txtidmodelo.Text = string.Empty;
                    txtkm.Text = string.Empty;
                    txtvalor.Text = string.Empty;
                    txtid.Text = string.Empty;
                    cmbstatus.Text = string.Empty;


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

            string sql_select_automovel = "select*from tb_automovel;";
            MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
            executacmdMySql_select_automovel.ExecuteNonQuery();

            DataTable tabela_automovel = new DataTable();
            MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
            da_automovel.Fill(tabela_automovel);
            dgv_automovel.DataSource = tabela_automovel;




            con.Close();

            BindingSource bgs = new BindingSource();

            bgs.DataSource = dgv_automovel.DataSource;


            bgs.Filter = "CONVERT(tb_automovel_nome, 'System.String')like '%" + txtpesq.Text + "%'";
            dgv_automovel.DataSource = bgs.DataSource;
        }

        private void Formautomovel_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_automovel = "select*from tb_automovel ";
            MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
            executacmdMySql_select_automovel.ExecuteNonQuery();

            DataTable tabela_automovel = new DataTable();
            MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
            da_automovel.Fill(tabela_automovel);

            dgv_automovel.DataSource = tabela_automovel;


            dgv_automovel.Columns["tb_automovel_id"].HeaderText = "ID";
            dgv_automovel.Columns["tb_automovel_nome"].HeaderText = "Nome";
            dgv_automovel.Columns["tb_automovel_ano_fab"].HeaderText = "Ano Fabricação";
            dgv_automovel.Columns["tb_automovel_cor"].HeaderText = "Cor";
            dgv_automovel.Columns["tb_automovel_km"].HeaderText = "Km";
            dgv_automovel.Columns["tb_automovel_valor_d"].HeaderText = "Valor";
            dgv_automovel.Columns["tb_automovel_status"].HeaderText = "Status";
            dgv_automovel.Columns["tb_marca_id"].HeaderText = "Marca Id";
            dgv_automovel.Columns["tb_modelo_id"].HeaderText = "Modelo Id";
            con.Close();
        }

        private void dgv_automovel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text= dgv_automovel.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgv_automovel.CurrentRow.Cells[1].Value.ToString();
            txtanofab.Text= dgv_automovel.CurrentRow.Cells[2].Value.ToString();
            txtcor.Text= dgv_automovel.CurrentRow.Cells[3].Value.ToString();
            txtkm.Text= dgv_automovel.CurrentRow.Cells[4].Value.ToString();
            txtvalor.Text= dgv_automovel.CurrentRow.Cells[5].Value.ToString();
            cmbstatus.Text= dgv_automovel.CurrentRow.Cells[6].Value.ToString();
            txtidmarca.Text= dgv_automovel.CurrentRow.Cells[7].Value.ToString();
            txtidmodelo.Text= dgv_automovel.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            int codigo;

            string nome, anofab, cor, km, val, status, idmarca, idmodelo;

            codigo = int.Parse(txtid.Text); ;
            nome = txtnome.Text;
            anofab = txtanofab.Text;
            cor = txtcor.Text;
            km = txtkm.Text;
            val = txtvalor.Text;
            status = cmbstatus.Text;
            idmarca = txtidmarca.Text;
            idmodelo = txtidmodelo.Text;


            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            //variavel strig que ira receber comando sql
            string sql_update_cliente = @"update tb_automovel
                        set  TB_automovel_nome= @automovel_nome, 
                     TB_AUTOMOVEL_ANO_FAB= @AUTOMOVEL_ANO_FAB,
            TB_AUTOMOVEL_COR=@AUTOMOVEL_COR, 
             TB_AUTOMOVEL_KM =@AUTOMOVEL_KM,
                 TB_AUTOMOVEL_VALOR_D= @AUTOMOVEL_VALOR_D,
                 TB_AUTOMOVEL_STATUS=@AUTOMOVEL_STATUS,
                    TB_MARCA_ID=@marca_id ,
                            TB_MODELO_ID=@modelo_id
                where tb_automovel_id= @id";




            MySqlCommand executacmdMySql_update_automovel = new MySqlCommand(sql_update_cliente, con);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@automovel_nome", nome);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@automovel_ano_fab", anofab);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@automovel_cor", cor);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@automovel_km", km);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@automovel_valor_d", val);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@automovel_status", status);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@marca_id", idmarca);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@modelo_id", idmodelo);
            executacmdMySql_update_automovel.ExecuteNonQuery();

            string sql_select_automovel = "select*from tb_automovel ";
            MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
            executacmdMySql_select_automovel.ExecuteNonQuery();

            DataTable tabela_automovel = new DataTable();
            MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
            da_automovel.Fill(tabela_automovel);

            dgv_automovel.DataSource = tabela_automovel;


            MessageBox.Show("Atualização realizada com sucesso");

            con.Close();
            txtnome.Text = string.Empty;
            txtanofab.Text = string.Empty;
            txtcor.Text = string.Empty;
            txtidmarca.Text = string.Empty;
            txtidmodelo.Text = string.Empty;
            txtkm.Text = string.Empty;
            txtvalor.Text = string.Empty;
            txtid.Text = string.Empty;
            cmbstatus.Text = string.Empty;
        }

        private void dgv_automovel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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


                string sql_delete_automovel = @"delete from tb_automovel where tb_automovel_id=@codigo";
                MySqlCommand executacmdMySql_delete_automovel = new MySqlCommand(sql_delete_automovel, con);
                executacmdMySql_delete_automovel.Parameters.AddWithValue("@codigo", codigo);
                executacmdMySql_delete_automovel.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado co sucesso");

                string sql_select_automovel = "select*from tb_automovel";
                MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
                executacmdMySql_select_automovel.ExecuteNonQuery();

                DataTable tabela_automovel = new DataTable();
                MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
                da_automovel.Fill(tabela_automovel);
                con.Close();

                dgv_automovel.DataSource = tabela_automovel;
            }

            else if (dialogResult == DialogResult.No)
            {
               
            }

            txtnome.Text = string.Empty;
            txtanofab.Text = string.Empty;
            txtcor.Text = string.Empty;
            txtidmarca.Text = string.Empty;
            txtidmodelo.Text = string.Empty;
            txtkm.Text = string.Empty;
            txtvalor.Text = string.Empty;
            txtid.Text = string.Empty;
            cmbstatus.Text = string.Empty;
        }
    }
}