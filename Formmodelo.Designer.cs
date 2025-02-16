
namespace Locadora
{
    partial class Formmodelo
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
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.dgv_modelo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpesq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modelo)).BeginInit();
            this.SuspendLayout();
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Brown;
            this.btndeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeletar.Location = new System.Drawing.Point(479, 128);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(107, 27);
            this.btndeletar.TabIndex = 28;
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
            this.btnatualizar.Location = new System.Drawing.Point(349, 128);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(107, 27);
            this.btnatualizar.TabIndex = 27;
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
            this.btncad.Location = new System.Drawing.Point(219, 128);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(107, 27);
            this.btncad.TabIndex = 26;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // dgv_modelo
            // 
            this.dgv_modelo.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_modelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modelo.Location = new System.Drawing.Point(307, 282);
            this.dgv_modelo.Name = "dgv_modelo";
            this.dgv_modelo.Size = new System.Drawing.Size(313, 209);
            this.dgv_modelo.TabIndex = 25;
            this.dgv_modelo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_modelo_CellClick);
            this.dgv_modelo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_modelo_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(91, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID";
             // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(303, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descrição do modelo";
             // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(532, 78);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(189, 20);
            this.txtnome.TabIndex = 22;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(144, 77);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Modelo";
            // 
            // txtpesq
            // 
            this.txtpesq.Location = new System.Drawing.Point(340, 236);
            this.txtpesq.Name = "txtpesq";
            this.txtpesq.Size = new System.Drawing.Size(323, 20);
            this.txtpesq.TabIndex = 70;
            this.txtpesq.TextChanged += new System.EventHandler(this.txtpesq_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(229, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "Pesquisar";
            // 
            // Formmodelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(887, 546);
            this.Controls.Add(this.txtpesq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.dgv_modelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "Formmodelo";
            this.Text = "Formmodelo";
            this.Load += new System.EventHandler(this.Formmodelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.DataGridView dgv_modelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpesq;
        private System.Windows.Forms.Label label4;
    }
}