
namespace Locadora
{
    partial class FormCliente2
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
            this.label4 = new System.Windows.Forms.Label();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Clientes Cadastrados";
            // 
            // btndeletar
            // 
            this.btndeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.Location = new System.Drawing.Point(435, 351);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(107, 27);
            this.btndeletar.TabIndex = 13;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.Location = new System.Drawing.Point(309, 351);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(107, 27);
            this.btnatualizar.TabIndex = 12;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click_1);
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(12, 78);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.Size = new System.Drawing.Size(776, 255);
            this.dgv_cliente.TabIndex = 15;
            this.dgv_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cliente_CellClick);
            // 
            // FormCliente2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.dgv_cliente);
            this.Name = "FormCliente2";
            this.Text = "Formcliente2";
            this.Load += new System.EventHandler(this.FormCliente2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.DataGridView dgv_cliente;
    }
}