
namespace Locadora
{
    partial class pesquisar
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
            this.txtpesq = new System.Windows.Forms.TextBox();
            this.dgvpesq = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesq)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpesq
            // 
            this.txtpesq.Location = new System.Drawing.Point(204, 46);
            this.txtpesq.Name = "txtpesq";
            this.txtpesq.Size = new System.Drawing.Size(423, 20);
            this.txtpesq.TabIndex = 0;
            this.txtpesq.TextChanged += new System.EventHandler(this.txtpesq_TextChanged);
            // 
            // dgvpesq
            // 
            this.dgvpesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpesq.Location = new System.Drawing.Point(180, 134);
            this.dgvpesq.Name = "dgvpesq";
            this.dgvpesq.Size = new System.Drawing.Size(480, 244);
            this.dgvpesq.TabIndex = 1;
            // 
            // pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvpesq);
            this.Controls.Add(this.txtpesq);
            this.Name = "pesquisar";
            this.Text = "pesquisar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpesq;
        private System.Windows.Forms.DataGridView dgvpesq;
    }
}