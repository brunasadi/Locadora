
namespace Locadora
{
    partial class Formfuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtidcargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpcontrat = new System.Windows.Forms.DateTimePicker();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.txtpesq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_funcionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.BackColor = System.Drawing.Color.Transparent;
            this.Cliente.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.Color.Firebrick;
            this.Cliente.Location = new System.Drawing.Point(408, 18);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(338, 57);
            this.Cliente.TabIndex = 4;
            this.Cliente.Text = "Funcionário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(98, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 78;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(98, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 23);
            this.label6.TabIndex = 77;
            this.label6.Text = "Data de contratação";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(201, 160);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(158, 20);
            this.txttel.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(98, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 75;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(93, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Nome ";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(169, 123);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(189, 20);
            this.txtnome.TabIndex = 73;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(139, 86);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 72;
            // 
            // txtidcargo
            // 
            this.txtidcargo.Location = new System.Drawing.Point(233, 240);
            this.txtidcargo.Name = "txtidcargo";
            this.txtidcargo.Size = new System.Drawing.Size(158, 20);
            this.txtidcargo.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(98, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 80;
            this.label4.Text = "Id do cargo";
            // 
            // dtpcontrat
            // 
            this.dtpcontrat.CustomFormat = "yyyy/MM/dd";
            this.dtpcontrat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpcontrat.Location = new System.Drawing.Point(316, 202);
            this.dtpcontrat.Name = "dtpcontrat";
            this.dtpcontrat.Size = new System.Drawing.Size(200, 20);
            this.dtpcontrat.TabIndex = 81;
            this.dtpcontrat.Value = new System.DateTime(2023, 6, 20, 0, 0, 0, 0);
            this.dtpcontrat.ValueChanged += new System.EventHandler(this.dtpcontrat_ValueChanged);
            this.dtpcontrat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtcontrat_KeyDown);
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.Brown;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncadastrar.Location = new System.Drawing.Point(248, 302);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(154, 35);
            this.btncadastrar.TabIndex = 82;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.Brown;
            this.btnatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnatualizar.Location = new System.Drawing.Point(433, 302);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(154, 35);
            this.btnatualizar.TabIndex = 83;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            this.btnatualizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btnatualizar_MouseClick);
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Brown;
            this.btndeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeletar.Location = new System.Drawing.Point(627, 302);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(154, 35);
            this.btndeletar.TabIndex = 84;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.Btndeletar_Click);
            this.btndeletar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btndeletar_MouseClick);
            // 
            // txtpesq
            // 
            this.txtpesq.Location = new System.Drawing.Point(423, 370);
            this.txtpesq.Name = "txtpesq";
            this.txtpesq.Size = new System.Drawing.Size(323, 20);
            this.txtpesq.TabIndex = 87;
            this.txtpesq.TextChanged += new System.EventHandler(this.txtpesq_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(312, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 86;
            this.label7.Text = "Pesquisar";
            // 
            // dgv_funcionario
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_funcionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_funcionario.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_funcionario.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_funcionario.Location = new System.Drawing.Point(248, 406);
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.Size = new System.Drawing.Size(583, 237);
            this.dgv_funcionario.TabIndex = 85;
            this.dgv_funcionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_funcionario_CellClick);
            this.dgv_funcionario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_funcionario_CellMouseClick);
            // 
            // Formfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1081, 667);
            this.Controls.Add(this.txtpesq);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_funcionario);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.dtpcontrat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidcargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.label1);
            this.Name = "Formfuncionario";
            this.Text = "Formfuncionario";
            this.Load += new System.EventHandler(this.Formfuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtidcargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpcontrat;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.TextBox txtpesq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_funcionario;
    }
}