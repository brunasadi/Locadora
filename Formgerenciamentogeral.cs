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
	public partial class Formgerenciamentogeral : Form
	{

        string conexao = ConfigurationManager.ConnectionStrings["bd_locadora_2metec_2023"].ConnectionString;
        public Formgerenciamentogeral()
		{
			InitializeComponent();
		}

		private void Formgerenciamentogeral_Load(object sender, EventArgs e)
		{
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_cliente = " select tb_cliente.tb_cliente_id, tb_cliente.tb_cliente_nome from tb_cliente;";
            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();
            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);

            dgvcli.DataSource = tabela_cliente;


            dgvcli.Columns["tb_cliente_id"].HeaderText = "ID";
            dgvcli.Columns["tb_cliente_nome"].HeaderText = "Nome";


            string sql_select_automovel = " select tb_automovel .tb_automovel_id, tb_automovel .tb_automovel_nome from tb_automovel ;";
            MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
            executacmdMySql_select_automovel.ExecuteNonQuery();

            DataTable tabela_automovel = new DataTable();
            MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
            da_automovel.Fill(tabela_automovel);

            dgvauto.DataSource = tabela_automovel;


            dgvauto.Columns["tb_automovel_id"].HeaderText = "ID";
            dgvauto.Columns["tb_automovel_nome"].HeaderText = "Nome";


            string sql_select_locacao = "select tb_locacao.tb_locacao_id, tb_locacao.tb_cliente_id, tb_locacao.tb_automovel_id from tb_locacao;";
            MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
            executacmdMySql_select_locacao.ExecuteNonQuery();

            DataTable tabela_locacao = new DataTable();
            MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
            da_locacao.Fill(tabela_locacao);

           dgvlocacao.DataSource = tabela_locacao;


            dgvlocacao.Columns["tb_locacao_id"].HeaderText = "ID";
            dgvlocacao.Columns["tb_cliente_id"].HeaderText = "ID Cliente";
            dgvlocacao.Columns["tb_automovel_id"].HeaderText = "ID Automóvel";


            con.Close();
        }

		private void btncliente_Click(object sender, EventArgs e)
		{
            new Formcliente().Show();
        }

		private void btnauto_Click(object sender, EventArgs e)
		{
           // new Formautomovel().Show();
        }

		private void btnloca_Click(object sender, EventArgs e)
		{
            // new Formlocacao().Show();

        }
    }
}
