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
    public partial class pesquisar : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_locadora_2metec_2023"].ConnectionString;
        public pesquisar()
        {
            InitializeComponent();
        }

        private void txtpesq_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            //string sql_select_cliente = "select tb_cliente.tb_cliente_id, tb_cliente.tb_cliente_nome from tb_cliente;";
            //MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            //executacmdMySql_select_cliente.ExecuteNonQuery();

            //DataTable tabela_cliente = new DataTable();
            //MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            //da_cliente.Fill(tabela_cliente);

           

            string sql_select_automovel = "select tb_automovel.tb_automovel_id, tb_automovel.tb_automovel_nome from tb_automovel;";
            MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
            executacmdMySql_select_automovel.ExecuteNonQuery();

            DataTable tabela_automovel = new DataTable();
            MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
            da_automovel.Fill(tabela_automovel);


            //dgvpesq.DataSource = tabela_cliente;
            dgvpesq.DataSource = tabela_automovel;



            con.Close();
            BindingSource bgs = new BindingSource();

            bgs.DataSource = dgvpesq.DataSource;
            //bgs.Filter = "CONVERT(TB_CLIENTE_NOME, 'System.String')like '%" + txtpesq.Text + "%'";

            bgs.Filter = "CONVERT(tb_automovel_nome, 'System.String')like '%" + txtpesq.Text + "%'";
           
            dgvpesq.DataSource = bgs.DataSource;

        }
    }
}
