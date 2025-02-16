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

    public partial class Formcliente : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["bd_locadora_2metec_2023"].ConnectionString;
        public Formcliente()
        {
            InitializeComponent();
        }

        private void dtpnasc_ValueChanged(object sender, EventArgs e)
        {
            dtpnasc.Format = DateTimePickerFormat.Custom;

            dtpnasc.CustomFormat = "yyyy-MM-dd";
        }

        private void dtpcad_ValueChanged(object sender, EventArgs e)
        {
           dtpcad.Format = DateTimePickerFormat.Custom;
            dtpcad.CustomFormat = "yyyy-MM-dd";
        }

        private void dtpcad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dtpcad.CustomFormat = " ";
            }
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome, tel,email,senha,uf, bairro,complemento, sexo, dtnasc, cidade,endereco, dtcad;
                 
          
                nome = txtnome.Text;
                tel = txttel.Text;
                email = txtemail.Text;
                senha = txtsenha.Text;
                endereco = txtend.Text;
                uf = cmbuf.Text;
                bairro = txtbairro.Text;
                cidade = txtcidadade.Text;
                complemento = txtcomp.Text;
                sexo = cmbsexo.Text;
                dtnasc = dtpnasc.Text;
                dtcad = dtpcad.Text;



                if (nome == string.Empty || email == string.Empty || tel == string.Empty || senha == string.Empty || sexo == string.Empty || cidade == string.Empty ||
                 uf == string.Empty || bairro == string.Empty || endereco == string.Empty || string.IsNullOrEmpty(dtnasc) || string.IsNullOrEmpty(dtcad))

                  
                {
                    MessageBox.Show("Não foi possivel realizar o cadastro");
                }

                else
                {
                    string sql_insert = @"insert into tb_cliente
                  (TB_CLIENTE_NOME  ,
                   TB_CLIENTE_TEL  ,
                   TB_CLIENTE_SEXO  ,
                    TB_CLIENTE_EMAIL ,
                    TB_CLIENTE_SENHA  ,
                    TB_CLIENTE_ENDERECO  ,
                    TB_CLIENTE_COMPLEMENTO ,
                    TB_CLIENTE_BAIRRO ,
                    TB_CLIENTE_CIDADE ,
                    TB_CLIENTE_UF ,  
                    TB_CLIENTE_DT_NASC  ,
                    TB_CLIENTE_DT_CAD
                 ) values (
                  @cliente_nome,
                  @cliente_tel,
                  @cliente_sexo,
                   @cliente_email,
                  @cliente_senha,
                  @cliente_endereco,
                  @cliente_complemento,
                  @cliente_bairro,
                  @cliente_cidade,
                   @cliente_uf,
                  @cliente_dt_nasc,
                  @cliente_dt_cad
                    
                         )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_nome", nome);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_tel", tel);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_sexo", sexo);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_email", email);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_senha", senha);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_endereco", endereco);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_complemento", complemento);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_bairro", bairro);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_cidade", cidade);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_uf", uf);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_dt_nasc", dtnasc);
                    executacmdMySql_insert.Parameters.AddWithValue("@cliente_dt_cad", dtcad);


                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();


                    string sql_select_cliente = "select*from tb_cliente";
                    MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
                    executacmdMySql_select_cliente.ExecuteNonQuery();

                    DataTable tabela_cliente = new DataTable();
                    MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
                    da_cliente.Fill(tabela_cliente);


                    dgv_cliente.DataSource = tabela_cliente;

                    con.Close();

                    MessageBox.Show("Cadastrado!");

                    // txtnome.Text=string.Empty;//
                    txtnome.Text = string.Empty;
                    txttel.Text = string.Empty;
                    txtemail.Text = string.Empty;
                    txtbairro.Text = string.Empty;
                    txtcidadade.Text = string.Empty;
                    txtcomp.Text = string.Empty;
                    dtpcad.Text = string.Empty;
                    dtpnasc.Text = string.Empty;
                    txtend.Text = string.Empty;
                    txtid.Text = string.Empty;
                    txtsenha.Text = string.Empty;
                    cmbsexo.Text = string.Empty;
                    cmbuf.Text = string.Empty;
                }

               
              
               

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);


            }
        }

        private void Formcliente_Load(object sender, EventArgs e)
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
            dgv_cliente.Columns["tb_cliente_dt_nasc"].HeaderText = "Data de Nascimento";
            dgv_cliente.Columns["tb_cliente_dt_cad"].HeaderText = "Data de Cadastro";




            con.Close();
        }

        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text= dgv_cliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text= dgv_cliente.CurrentRow.Cells[1].Value.ToString();
            txttel.Text =dgv_cliente.CurrentRow.Cells[2].Value.ToString();
            cmbsexo.Text= dgv_cliente.CurrentRow.Cells[3].Value.ToString();
           txtemail.Text= dgv_cliente.CurrentRow.Cells[4].Value.ToString();
           txtsenha.Text= dgv_cliente.CurrentRow.Cells[5].Value.ToString();
            txtend.Text= dgv_cliente.CurrentRow.Cells[6].Value.ToString();
           txtcomp.Text= dgv_cliente.CurrentRow.Cells[7].Value.ToString();
             txtbairro.Text=  dgv_cliente.CurrentRow.Cells[8].Value.ToString();
            txtcidadade.Text= dgv_cliente.CurrentRow.Cells[9].Value.ToString();
             cmbuf.Text= dgv_cliente.CurrentRow.Cells[10].Value.ToString();
            dtpnasc.Text= dgv_cliente.CurrentRow.Cells[11].Value.ToString();
            dtpcad.Text= dgv_cliente.CurrentRow.Cells[12].Value.ToString();
        }

        private void btnatualizar_Click(object sender, EventArgs e)
            
        {
            int codigo;

            string nome, tel, email, senha, uf, bairro, complemento, sexo,  cidade, endereco, dtnasc, dtcad;
           
            codigo = int.Parse(txtid.Text); 
            nome = txtnome.Text;
            tel = txttel.Text;
            email = txtemail.Text;
            senha = txtsenha.Text;
            endereco = txtend.Text;
            uf = cmbuf.Text;
            bairro = txtbairro.Text;
            cidade = txtcidadade.Text;
            complemento = txtcomp.Text;
            sexo = cmbsexo.Text;
            dtnasc = dtpnasc.Text ;
            dtcad =dtpcad.Text;

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            //variavel strig que ira receber comando sql
            string sql_update_cliente = @"update tb_cliente
                        set  TB_CLIENTE_NOME =@cliente_nome, 
                    TB_CLIENTE_TEL =  @cliente_tel,
            TB_CLIENTE_SEXO  = @cliente_sexo,
            TB_CLIENTE_EMAIL =  @cliente_email, 
            TB_CLIENTE_SENHA = @cliente_senha,
             TB_CLIENTE_ENDERECO = @cliente_endereco, 
               TB_CLIENTE_COMPLEMENTO = @cliente_complemento, 
                TB_CLIENTE_BAIRRO =  @cliente_bairro,
               TB_CLIENTE_CIDADE =  @cliente_cidade, 
                TB_CLIENTE_UF = @cliente_uf, 
            TB_CLIENTE_DT_NASC =   @cliente_dt_nasc, 
            TB_CLIENTE_DT_CAD  =@cliente_dt_cad
                where tb_cliente_id=@id";

            MySqlCommand executacmdMySql_update_cliente = new MySqlCommand(sql_update_cliente, con);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_nome", nome);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_tel", tel);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_sexo", sexo);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_email", email);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_senha", senha);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_endereco", endereco);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_complemento", complemento);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_bairro", bairro);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_cidade", cidade);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_uf", uf);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_dt_nasc", dtnasc);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cliente_dt_cad", dtcad);
            executacmdMySql_update_cliente.ExecuteNonQuery();

            string sql_select_cliente = "select*from tb_cliente";
            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();
            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);

            dgv_cliente.DataSource = tabela_cliente;


            MessageBox.Show("Atualização realizada com sucesso");

            con.Close();
            txtnome.Text = string.Empty;
            txttel.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtbairro.Text = string.Empty;
            txtcidadade.Text = string.Empty;
            txtcomp.Text = string.Empty;
            dtpcad.Text = string.Empty;
            dtpnasc.Text = string.Empty;
            txtend.Text = string.Empty;
            txtid.Text = string.Empty;
            txtsenha.Text = string.Empty;
            cmbsexo.Text = string.Empty;
            cmbuf.Text = string.Empty;
        }

        private void dgv_cliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btncad.Enabled = false;
        }

        private void btnatualizar_MouseClick(object sender, MouseEventArgs e)
        {
            btncad.Enabled = true;
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            btncad.Enabled = true;
        }

        private void btndeletar_MouseClick(object sender, MouseEventArgs e)
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


                string sql_delete_cliente = @"delete from tb_cliente where tb_cliente_id=@codigo";
                MySqlCommand executacmdMySql_delete_cliente = new MySqlCommand(sql_delete_cliente, con);
                executacmdMySql_delete_cliente.Parameters.AddWithValue("@codigo", codigo);
                executacmdMySql_delete_cliente.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado co sucesso");

                string sql_select_cliente = "select*from tb_cliente";
                MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
                executacmdMySql_select_cliente.ExecuteNonQuery();

                DataTable tabela_cliente = new DataTable();
                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
                da_cliente.Fill(tabela_cliente);
                con.Close();

                dgv_cliente.DataSource = tabela_cliente;
            }

            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            txtnome.Text = string.Empty;
            txttel.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtbairro.Text = string.Empty;
            txtcidadade.Text = string.Empty;
            txtcomp.Text = string.Empty;
            dtpcad.Text = string.Empty;
            dtpnasc.Text = string.Empty;
            txtend.Text = string.Empty;
            txtid.Text = string.Empty;
            txtsenha.Text = string.Empty;
            cmbsexo.Text = string.Empty;
            cmbuf.Text = string.Empty;
        }

		

        private void txtpesq_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();

            string sql_select_cliente = "select*from tb_cliente;";
            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();
            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);
            dgv_cliente.DataSource = tabela_cliente;

           


            con.Close();

            BindingSource bgs = new BindingSource();

            bgs.DataSource = dgv_cliente.DataSource;


            bgs.Filter = "CONVERT(tb_cliente_nome, 'System.String')like '%" + txtpesq.Text + "%'";
            dgv_cliente.DataSource = bgs.DataSource;
        }

        private void cmbsexo_TextChanged(object sender, EventArgs e)
        {
            BindingSource bgs = new BindingSource();

            bgs.DataSource = cmbsexo.DataSource;


            bgs.Filter = "CONVERT(feminino + masculino, 'System.String')like '%" + cmbsexo.Text + "%'";
            cmbsexo.DataSource = bgs.DataSource;

            cmbsexo.DroppedDown = true;
            Cursor.Current = Cursors.Default;

        }

        private void cmbuf_TextChanged(object sender, EventArgs e)
        {
            BindingSource bgs = new BindingSource();

            bgs.DataSource = cmbuf.DataSource;


            bgs.Filter = "CONVERT(AC+AL+AP+AM+BA+CE+DF+ES+GO+MA+MT+MS+MG+PA+PB+PR+PE+PI+RJ+RN+RS+RO+RR+SC+SP+SE+TO, 'System.String')like '%" + cmbuf.Text + "%'";            
            cmbuf.DataSource = bgs.DataSource;
            cmbuf.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }

       
    }
}
 
