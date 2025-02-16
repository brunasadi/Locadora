
namespace Locadora
{
    partial class FormPrincipal
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
            this.btncli = new System.Windows.Forms.Button();
            this.btnfunc = new System.Windows.Forms.Button();
            this.btncargo = new System.Windows.Forms.Button();
            this.btnmarca = new System.Windows.Forms.Button();
            this.btnmodelo = new System.Windows.Forms.Button();
            this.btnauto = new System.Windows.Forms.Button();
            this.btnloc = new System.Windows.Forms.Button();
            this.btnviz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncli
            // 
            this.btncli.BackColor = System.Drawing.Color.Brown;
            this.btncli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncli.Location = new System.Drawing.Point(144, 44);
            this.btncli.Name = "btncli";
            this.btncli.Size = new System.Drawing.Size(185, 73);
            this.btncli.TabIndex = 0;
            this.btncli.Text = "Gerenciamento de Clientes";
            this.btncli.UseVisualStyleBackColor = false;
            this.btncli.Click += new System.EventHandler(this.btncli_Click);
            // 
            // btnfunc
            // 
            this.btnfunc.BackColor = System.Drawing.Color.Brown;
            this.btnfunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfunc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfunc.Location = new System.Drawing.Point(144, 133);
            this.btnfunc.Name = "btnfunc";
            this.btnfunc.Size = new System.Drawing.Size(185, 73);
            this.btnfunc.TabIndex = 1;
            this.btnfunc.Text = "Gerenciamento de Funcionários";
            this.btnfunc.UseVisualStyleBackColor = false;
            this.btnfunc.Click += new System.EventHandler(this.btnfunc_Click);
            // 
            // btncargo
            // 
            this.btncargo.BackColor = System.Drawing.Color.Brown;
            this.btncargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncargo.Location = new System.Drawing.Point(144, 222);
            this.btncargo.Name = "btncargo";
            this.btncargo.Size = new System.Drawing.Size(185, 73);
            this.btncargo.TabIndex = 2;
            this.btncargo.Text = "Gerenciamento de Cargos";
            this.btncargo.UseVisualStyleBackColor = false;
            this.btncargo.Click += new System.EventHandler(this.btncargo_Click);
            // 
            // btnmarca
            // 
            this.btnmarca.BackColor = System.Drawing.Color.Brown;
            this.btnmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmarca.Location = new System.Drawing.Point(390, 44);
            this.btnmarca.Name = "btnmarca";
            this.btnmarca.Size = new System.Drawing.Size(185, 73);
            this.btnmarca.TabIndex = 3;
            this.btnmarca.Text = "Gerenciamento de Marcas";
            this.btnmarca.UseVisualStyleBackColor = false;
            this.btnmarca.Click += new System.EventHandler(this.btnmarca_Click);
            // 
            // btnmodelo
            // 
            this.btnmodelo.BackColor = System.Drawing.Color.Brown;
            this.btnmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodelo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodelo.Location = new System.Drawing.Point(390, 133);
            this.btnmodelo.Name = "btnmodelo";
            this.btnmodelo.Size = new System.Drawing.Size(185, 73);
            this.btnmodelo.TabIndex = 4;
            this.btnmodelo.Text = "Gerenciamento de Modelos";
            this.btnmodelo.UseVisualStyleBackColor = false;
            this.btnmodelo.Click += new System.EventHandler(this.btnmodelo_Click);
            // 
            // btnauto
            // 
            this.btnauto.BackColor = System.Drawing.Color.Brown;
            this.btnauto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnauto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnauto.Location = new System.Drawing.Point(144, 325);
            this.btnauto.Name = "btnauto";
            this.btnauto.Size = new System.Drawing.Size(185, 73);
            this.btnauto.TabIndex = 5;
            this.btnauto.Text = "Gerenciamento de Automóveis";
            this.btnauto.UseVisualStyleBackColor = false;
            this.btnauto.Click += new System.EventHandler(this.btnauto_Click);
            // 
            // btnloc
            // 
            this.btnloc.BackColor = System.Drawing.Color.Brown;
            this.btnloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnloc.Location = new System.Drawing.Point(390, 222);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(185, 73);
            this.btnloc.TabIndex = 6;
            this.btnloc.Text = "Gerenciamento de Locações";
            this.btnloc.UseVisualStyleBackColor = false;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // btnviz
            // 
            this.btnviz.BackColor = System.Drawing.Color.Brown;
            this.btnviz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnviz.Location = new System.Drawing.Point(390, 325);
            this.btnviz.Name = "btnviz";
            this.btnviz.Size = new System.Drawing.Size(185, 73);
            this.btnviz.TabIndex = 7;
            this.btnviz.Text = "Vizualização Geral";
            this.btnviz.UseVisualStyleBackColor = false;
            this.btnviz.Click += new System.EventHandler(this.btnviz_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(735, 430);
            this.Controls.Add(this.btnviz);
            this.Controls.Add(this.btnloc);
            this.Controls.Add(this.btnauto);
            this.Controls.Add(this.btnmodelo);
            this.Controls.Add(this.btnmarca);
            this.Controls.Add(this.btncargo);
            this.Controls.Add(this.btnfunc);
            this.Controls.Add(this.btncli);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncli;
        private System.Windows.Forms.Button btnfunc;
        private System.Windows.Forms.Button btncargo;
        private System.Windows.Forms.Button btnmarca;
        private System.Windows.Forms.Button btnmodelo;
        private System.Windows.Forms.Button btnauto;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnviz;
    }
}