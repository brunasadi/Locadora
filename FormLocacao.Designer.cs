
namespace Locadora
{
    partial class FormLocacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidfunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpesq = new System.Windows.Forms.TextBox();
            this.dgv_locacao = new System.Windows.Forms.DataGridView();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.dtpfim = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtidauto = new System.Windows.Forms.TextBox();
            this.txtidcli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_locacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(424, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 23);
            this.label7.TabIndex = 108;
            this.label7.Text = "Id do Automóvel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(418, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 23);
            this.label6.TabIndex = 107;
            this.label6.Text = "Id do funcionário";
            // 
            // txtidfunc
            // 
            this.txtidfunc.Location = new System.Drawing.Point(611, 173);
            this.txtidfunc.Name = "txtidfunc";
            this.txtidfunc.Size = new System.Drawing.Size(67, 20);
            this.txtidfunc.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(219, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 104;
            this.label4.Text = "Pesquisar";
            // 
            // txtpesq
            // 
            this.txtpesq.Location = new System.Drawing.Point(350, 325);
            this.txtpesq.Name = "txtpesq";
            this.txtpesq.Size = new System.Drawing.Size(423, 20);
            this.txtpesq.TabIndex = 103;
            this.txtpesq.TextChanged += new System.EventHandler(this.txtpesq_TextChanged);
            // 
            // dgv_locacao
            // 
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgv_locacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_locacao.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_locacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_locacao.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_locacao.Location = new System.Drawing.Point(70, 348);
            this.dgv_locacao.Name = "dgv_locacao";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_locacao.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_locacao.Size = new System.Drawing.Size(888, 233);
            this.dgv_locacao.TabIndex = 102;
            this.dgv_locacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_locacao_CellClick);
            this.dgv_locacao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_locacao_MouseClick);
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Brown;
            this.btndeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeletar.Location = new System.Drawing.Point(594, 247);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(114, 36);
            this.btndeletar.TabIndex = 101;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            this.btndeletar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btndeletar_MouseClick);
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.Brown;
            this.btnatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnatualizar.Location = new System.Drawing.Point(456, 247);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(114, 36);
            this.btnatualizar.TabIndex = 100;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            this.btnatualizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnatualizar_MouseClick);
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.Color.Brown;
            this.btncad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncad.Location = new System.Drawing.Point(323, 247);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(114, 36);
            this.btncad.TabIndex = 99;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(152, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 23);
            this.label13.TabIndex = 98;
            this.label13.Text = "Valor";
            // 
            // txtval
            // 
            this.txtval.Location = new System.Drawing.Point(222, 163);
            this.txtval.Name = "txtval";
            this.txtval.Size = new System.Drawing.Size(158, 20);
            this.txtval.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(342, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 47);
            this.label1.TabIndex = 89;
            this.label1.Text = "Automóvel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(152, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 88;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(147, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 87;
            this.label2.Text = "Tipo";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(193, 91);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 85;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Items.AddRange(new object[] {
            "Diária",
            "Semanal",
            "Mensal",
            ""});
            this.cmbtipo.Location = new System.Drawing.Point(208, 127);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(121, 21);
            this.cmbtipo.TabIndex = 109;
            // 
            // dtpfim
            // 
            this.dtpfim.CustomFormat = "yyyy/MM/dd";
            this.dtpfim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfim.Location = new System.Drawing.Point(629, 128);
            this.dtpfim.Name = "dtpfim";
            this.dtpfim.Size = new System.Drawing.Size(200, 20);
            this.dtpfim.TabIndex = 113;
            this.dtpfim.Value = new System.DateTime(2023, 6, 20, 0, 0, 0, 0);
            this.dtpfim.ValueChanged += new System.EventHandler(this.dtpfim_ValueChanged);
            this.dtpfim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpfim_KeyDown);
            // 
            // dtpinicio
            // 
            this.dtpinicio.CustomFormat = "yyyy/MM/dd";
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpinicio.Location = new System.Drawing.Point(629, 102);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(200, 20);
            this.dtpinicio.TabIndex = 112;
            this.dtpinicio.Value = new System.DateTime(2023, 6, 20, 0, 0, 0, 0);
            this.dtpinicio.ValueChanged += new System.EventHandler(this.dtpinicio_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(473, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 23);
            this.label14.TabIndex = 111;
            this.label14.Text = "Data de Inicio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(473, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 23);
            this.label15.TabIndex = 110;
            this.label15.Text = "Data de Fim";
            // 
            // txtidauto
            // 
            this.txtidauto.Location = new System.Drawing.Point(611, 201);
            this.txtidauto.Name = "txtidauto";
            this.txtidauto.Size = new System.Drawing.Size(67, 20);
            this.txtidauto.TabIndex = 114;
            // 
            // txtidcli
            // 
            this.txtidcli.Location = new System.Drawing.Point(867, 196);
            this.txtidcli.Name = "txtidcli";
            this.txtidcli.Size = new System.Drawing.Size(67, 20);
            this.txtidcli.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(716, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 117;
            this.label5.Text = "Id do Cliente";
            // 
            // FormLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(987, 582);
            this.Controls.Add(this.txtidcli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtidauto);
            this.Controls.Add(this.dtpfim);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtidfunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpesq);
            this.Controls.Add(this.dgv_locacao);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Name = "FormLocacao";
            this.Text = "FormLocacacao";
            this.Load += new System.EventHandler(this.FormLocacacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_locacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidfunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpesq;
        private System.Windows.Forms.DataGridView dgv_locacao;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.DateTimePicker dtpfim;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtidauto;
        private System.Windows.Forms.TextBox txtidcli;
        private System.Windows.Forms.Label label5;
    }
}