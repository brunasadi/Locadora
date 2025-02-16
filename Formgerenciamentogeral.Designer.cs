
namespace Locadora
{
	partial class Formgerenciamentogeral
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
            this.dgvcli = new System.Windows.Forms.DataGridView();
            this.dgvauto = new System.Windows.Forms.DataGridView();
            this.dgvlocacao = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnauto = new System.Windows.Forms.Button();
            this.btnloca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcli
            // 
            this.dgvcli.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvcli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcli.Location = new System.Drawing.Point(25, 76);
            this.dgvcli.Name = "dgvcli";
            this.dgvcli.Size = new System.Drawing.Size(244, 305);
            this.dgvcli.TabIndex = 0;
            // 
            // dgvauto
            // 
            this.dgvauto.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvauto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvauto.Location = new System.Drawing.Point(385, 76);
            this.dgvauto.Name = "dgvauto";
            this.dgvauto.Size = new System.Drawing.Size(267, 305);
            this.dgvauto.TabIndex = 1;
            // 
            // dgvlocacao
            // 
            this.dgvlocacao.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvlocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlocacao.Location = new System.Drawing.Point(733, 76);
            this.dgvlocacao.Name = "dgvlocacao";
            this.dgvlocacao.Size = new System.Drawing.Size(327, 305);
            this.dgvlocacao.TabIndex = 2;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.BackColor = System.Drawing.Color.Transparent;
            this.Cliente.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cliente.Location = new System.Drawing.Point(84, 40);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(114, 33);
            this.Cliente.TabIndex = 3;
            this.Cliente.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(436, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Automóvel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(845, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Locação";
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.Brown;
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncliente.Location = new System.Drawing.Point(67, 387);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(154, 35);
            this.btncliente.TabIndex = 7;
            this.btncliente.Text = "Gerenciar Cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnauto
            // 
            this.btnauto.BackColor = System.Drawing.Color.Brown;
            this.btnauto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnauto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnauto.Location = new System.Drawing.Point(417, 387);
            this.btnauto.Name = "btnauto";
            this.btnauto.Size = new System.Drawing.Size(187, 35);
            this.btnauto.TabIndex = 10;
            this.btnauto.Text = "Gerenciar Automóvel";
            this.btnauto.UseVisualStyleBackColor = false;
            this.btnauto.Click += new System.EventHandler(this.btnauto_Click);
            // 
            // btnloca
            // 
            this.btnloca.BackColor = System.Drawing.Color.Brown;
            this.btnloca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnloca.Location = new System.Drawing.Point(804, 387);
            this.btnloca.Name = "btnloca";
            this.btnloca.Size = new System.Drawing.Size(187, 35);
            this.btnloca.TabIndex = 11;
            this.btnloca.Text = "Gerenciar Locação";
            this.btnloca.UseVisualStyleBackColor = false;
            this.btnloca.Click += new System.EventHandler(this.btnloca_Click);
            // 
            // Formgerenciamentogeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::Locadora.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1084, 477);
            this.Controls.Add(this.btnloca);
            this.Controls.Add(this.btnauto);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.dgvlocacao);
            this.Controls.Add(this.dgvauto);
            this.Controls.Add(this.dgvcli);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Formgerenciamentogeral";
            this.Text = "Formgerenciamentogeral";
            this.Load += new System.EventHandler(this.Formgerenciamentogeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvcli;
		private System.Windows.Forms.DataGridView dgvauto;
		private System.Windows.Forms.DataGridView dgvlocacao;
		private System.Windows.Forms.Label Cliente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btncliente;
		private System.Windows.Forms.Button btnauto;
		private System.Windows.Forms.Button btnloca;
	}
}