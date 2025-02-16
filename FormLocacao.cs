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
    public partial class FormLocacao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_locadora_2metec_2023"].ConnectionString;
        public FormLocacao()
        {
            InitializeComponent();
        }

        private void dtpinicio_ValueChanged(object sender, EventArgs e)
        {
            dtpinicio.Format = DateTimePickerFormat.Custom;

            dtpinicio.CustomFormat = "yyyy-MM-dd";
        }

        private void dtpfim_ValueChanged(object sender, EventArgs e)
        {
            dtpfim.Format = DateTimePickerFormat.Custom;

            dtpfim.CustomFormat = "yyyy-MM-dd";
        }

        private void dtpfim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dtpfim.CustomFormat = " ";
            }


        }

        private void btncad_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string tipo, dtinicio, dtfim, idcli, idfunc, idauto, val;


                tipo = cmbtipo.Text;
                dtinicio = dtpinicio.Text;
                dtfim = dtpfim.Text;
                idcli = txtidcli.Text;
                idfunc = txtidfunc.Text;
                idauto = txtidauto.Text;
                val = txtval.Text;



                if (tipo == string.Empty || idcli == string.Empty || idfunc == string.Empty || idfunc == string.Empty || val == string.Empty )


                {
                    MessageBox.Show("Não foi possivel realizar o cadastro");
                }

                else
                {
                    string sql_insert = @"insert into tb_locacao
                  (
                    TB_LOCACAO_TIPO,
                    TB_LOCACAO_VALOR, 
                  TB_LOCACAO_DT_INICIO,
                    TB_LOCACAO_DT_FIM,
                    TB_CLIENTE_ID,
                TB_FUNCIONARIO_ID,
                    TB_AUTOMOVEL_ID
                 ) values (
                  @locacao_tipo,
                  @locacao_valor,
                  @locacao_dt_inicio,
                   @locacao_dt_fim,
                  @cliente_id,
                  @funcionario_id,
                  @automovel_id
                 
                    
                         )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                    executacmdMySql_insert.Parameters.AddWithValue("@locacao_tipo", tipo);
                    executacmdMySql_insert.Parameters.AddWithValue("@locacao_valor", val);
                    executacmdMySql_insert.Parameters.AddWithValue("@locacao_dt_inicio", dtinicio);
                    executacmdMySql_insert.Parameters.AddWithValue("@locacao_dt_fim", dtfim);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_id", idcli);
                    executacmdMySql_insert.Parameters.AddWithValue("@funcionario_id", idfunc);
                    executacmdMySql_insert.Parameters.AddWithValue("@automovel_id", idauto);
                   


                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();


                    string sql_select_locacao = "select*from tb_locacao";
                    MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
                    executacmdMySql_select_locacao.ExecuteNonQuery();

                    DataTable tabela_locacao = new DataTable();
                    MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
                    da_locacao.Fill(tabela_locacao);


                    dgv_locacao.DataSource = tabela_locacao;

                    con.Close();

                    MessageBox.Show("Cadastrado!");

                    // txtnome.Text=string.Empty;//
                    txtid.Text = string.Empty;
                    txtidauto.Text = string.Empty;
                    txtidcli.Text = string.Empty;
                    txtidfunc.Text= string.Empty;
                    txtval.Text = string.Empty;
                    dtpinicio.Text = string.Empty;
                    dtpfim.Text = string.Empty;
                    cmbtipo.Text = string.Empty;


                   
                }





            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);


            }
        }

        private void FormLocacacao_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_locacao = "select*from tb_locacao";
            MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
            executacmdMySql_select_locacao.ExecuteNonQuery();

            DataTable tabela_locacao = new DataTable();
            MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
            da_locacao.Fill(tabela_locacao);

            dgv_locacao.DataSource = tabela_locacao;


            dgv_locacao.Columns["tb_locacao_id"].HeaderText = "ID";
            dgv_locacao.Columns["tb_locacao_tipo"].HeaderText = "Tipo";
            dgv_locacao.Columns["tb_locacao_valor"].HeaderText = "Valor";
            dgv_locacao.Columns["tb_locacao_dt_inicio"].HeaderText = "Data de Inicio";
            dgv_locacao.Columns["tb_locacao_dt_fim"].HeaderText = "Data de Fim";
            dgv_locacao.Columns["tb_funcionario_id"].HeaderText = "Funcionário ID";
            dgv_locacao.Columns["tb_automovel_id"].HeaderText = "Automóvel ID";
            dgv_locacao.Columns["tb_cliente_id"].HeaderText = "Cliente ID";

            con.Close();

        }

        private void dgv_locacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgv_locacao.CurrentRow.Cells[0].Value.ToString();
            cmbtipo.Text = dgv_locacao.CurrentRow.Cells[1].Value.ToString();
            txtval.Text= dgv_locacao.CurrentRow.Cells[2].Value.ToString();
            dtpinicio.Text = dgv_locacao.CurrentRow.Cells[3].Value.ToString();
            dtpfim.Text= dgv_locacao.CurrentRow.Cells[4].Value.ToString();
            txtidcli.Text= dgv_locacao.CurrentRow.Cells[5].Value.ToString();
            txtidfunc.Text= dgv_locacao.CurrentRow.Cells[6].Value.ToString();
            txtidauto.Text= dgv_locacao.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            int codigo;

            string tipo, dtinicio, dtfim, idcli, idfunc, idauto;
            double val;

            codigo = int.Parse(txtid.Text);
            tipo = cmbtipo.Text;
            dtinicio = dtpinicio.Text;
            dtfim = dtpfim.Text;
            idcli = txtidcli.Text;
            idfunc = txtidfunc.Text;
            idauto = txtidauto.Text;
            val = double.Parse(txtval.Text);


            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            //variavel strig que ira receber comando sql
            string sql_update_cliente = @"update tb_locacao
                        set  TB_locacao_tipo =@locacao_tipo, 
                    TB_LOCACAO_VALOR= @locacao_valor,
                  TB_LOCACAO_DT_INICIO= @locacao_dt_inicio,
                    TB_LOCACAO_DT_FIM=  @locacao_dt_fim,
                    TB_CLIENTE_ID= @cliente_id,
                TB_FUNCIONARIO_ID=@funcionario_id,
                    TB_AUTOMOVEL_ID= @automovel_id
                where tb_locacao_id=@id";

            MySqlCommand executacmdMySql_update_locacao = new MySqlCommand(sql_update_cliente, con);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@locacao_tipo", tipo);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@locacao_valor", val);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@locacao_dt_inicio", dtinicio);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@locacao_dt_fim", dtfim);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@cliente_id", idcli);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@funcionario_id", idfunc);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@automovel_id", idauto);
            executacmdMySql_update_locacao.ExecuteNonQuery();

            string sql_select_locacao = "select*from tb_locacao";
            MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
            executacmdMySql_select_locacao.ExecuteNonQuery();

            DataTable tabela_locacao = new DataTable();
            MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
            da_locacao.Fill(tabela_locacao);

            dgv_locacao.DataSource = tabela_locacao;


            MessageBox.Show("Atualização realizada com sucesso");

            con.Close();
            txtid.Text = string.Empty;
            txtidauto.Text = string.Empty;
            txtidcli.Text = string.Empty;
            txtidfunc.Text = string.Empty;
            txtval.Text = string.Empty;
            dtpinicio.Text = string.Empty;
            dtpfim.Text = string.Empty;
            cmbtipo.Text = string.Empty;

        }

        private void dgv_locacao_MouseClick(object sender, MouseEventArgs e)
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


                string sql_delete_locacao = @"delete from tb_locacao where tb_locacao_id=@codigo";
                MySqlCommand executacmdMySql_delete_locacao = new MySqlCommand(sql_delete_locacao, con);
                executacmdMySql_delete_locacao.Parameters.AddWithValue("@codigo", codigo);
                executacmdMySql_delete_locacao.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado co sucesso");

                string sql_select_locacao = "select*from tb_locacao";
                MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
                executacmdMySql_select_locacao.ExecuteNonQuery();

                DataTable tabela_locacao = new DataTable();
                MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
                da_locacao.Fill(tabela_locacao);
                con.Close();

                dgv_locacao.DataSource = tabela_locacao;
            }

            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            txtid.Text = string.Empty;
            txtidauto.Text = string.Empty;
            txtidcli.Text = string.Empty;
            txtidfunc.Text = string.Empty;
            txtval.Text = string.Empty;
            dtpinicio.Text = string.Empty;
            dtpfim.Text = string.Empty;
            cmbtipo.Text = string.Empty;

        }

        private void txtpesq_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_locacao = "select*from tb_locacao;";
            MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
            executacmdMySql_select_locacao.ExecuteNonQuery();

            DataTable tabela_locacao = new DataTable();
            MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
            da_locacao.Fill(tabela_locacao);
            dgv_locacao.DataSource = tabela_locacao;




            con.Close();

            BindingSource bgs = new BindingSource();

            bgs.DataSource = dgv_locacao.DataSource;


            bgs.Filter = "CONVERT(tb_locacao_tipo, 'System.String')like '%" + txtpesq.Text + "%'";
            dgv_locacao.DataSource = bgs.DataSource;
        }
    }
    }

