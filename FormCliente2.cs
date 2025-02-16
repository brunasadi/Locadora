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
    public partial class FormCliente2 : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_locadora_2metec_2023"].ConnectionString;

        public FormCliente2()
        {
            InitializeComponent();
        }

        private void FormCliente2_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_cliente = "select*from tb_cliente";
            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();
            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);

            dgv_cliente.DataSource = tabela_cliente;


            dgv_cliente.Columns["tb_cliente_id"].HeaderText = "ID";
            dgv_cliente.Columns["tb_cliente_nome"].HeaderText = "Nome";
            dgv_cliente.Columns["tb_cliente_tel"].HeaderText = "Telefone";
            dgv_cliente.Columns["tb_cliente_sexo"].HeaderText = "Sexo";
            dgv_cliente.Columns["tb_cliente_email"].HeaderText = "Email";
            dgv_cliente.Columns["tb_cliente_senha"].HeaderText = "Senha";
            dgv_cliente.Columns["tb_cliente_endereco"].HeaderText = "Endereço";
            dgv_cliente.Columns["tb_cliente_complemento"].HeaderText = "Complemento";
            dgv_cliente.Columns["tb_cliente_bairro"].HeaderText = "Bairro";
            dgv_cliente.Columns["tb_cliente_cidade"].HeaderText = "Cidade";
            dgv_cliente.Columns["tb_cliente_uf"].HeaderText = "UF";
            dgv_cliente.Columns["tb_cliente_dt_nasc"].HeaderText = "Data de nascimento";
            dgv_cliente.Columns["tb_cliente_dt_cad"].HeaderText = "Data de cadastro";
           

            con.Close();
        }

        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           dgv_cliente.CurrentRow.Cells[0].Value.ToString();
           dgv_cliente.CurrentRow.Cells[1].Value.ToString();
              dgv_cliente.CurrentRow.Cells[2].Value.ToString();
              dgv_cliente.CurrentRow.Cells[3].Value.ToString();
            dgv_cliente.CurrentRow.Cells[4].Value.ToString();
            dgv_cliente.CurrentRow.Cells[5].Value.ToString();
            dgv_cliente.CurrentRow.Cells[6].Value.ToString();
            dgv_cliente.CurrentRow.Cells[7].Value.ToString();
            dgv_cliente.CurrentRow.Cells[8].Value.ToString();
            dgv_cliente.CurrentRow.Cells[9].Value.ToString();
            dgv_cliente.CurrentRow.Cells[10].Value.ToString();
            dgv_cliente.CurrentRow.Cells[11].Value.ToString();
            dgv_cliente.CurrentRow.Cells[12].Value.ToString();
           
           
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            //variavel strig que ira receber comando sql
            string sql_update_cliente = @"update tb_cliente
                        set tb_cliente_nome=@nome,
                tb_cliente_tel=@tel, 
                tb_cliente_sexo=@sexo,
                    
                    tb_cliente_email=@email
                where tb_cliente_id=@id";

            MySqlCommand executacmdMySql_update_cliente = new MySqlCommand(sql_update_cliente, con);
            string sql_select_cliente = "select*from tb_cliente";
            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();
            DataTable tabela_cliente = new DataTable();
            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);

            dgv_cliente.DataSource = tabela_cliente;


            MessageBox.Show("Atualização realizada com sucesso");

            con.Close();



        }

        private void btnatualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btndeletar_Click(object sender, EventArgs e)
        {

        }
    }
    }

