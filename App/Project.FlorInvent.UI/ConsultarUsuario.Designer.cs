namespace Project.FlorInvent.UI
{
    partial class ConsultarUsuario
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
            this.btnAlterarUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtgridConsultaUsuario = new System.Windows.Forms.DataGridView();
            this.CodigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultaUsuario = new System.Windows.Forms.Button();
            this.txtConsultaUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterarUsuario
            // 
            this.btnAlterarUsuario.Location = new System.Drawing.Point(311, 305);
            this.btnAlterarUsuario.Name = "btnAlterarUsuario";
            this.btnAlterarUsuario.Size = new System.Drawing.Size(95, 23);
            this.btnAlterarUsuario.TabIndex = 12;
            this.btnAlterarUsuario.Text = "Alterar";
            this.btnAlterarUsuario.UseVisualStyleBackColor = true;
            this.btnAlterarUsuario.Click += new System.EventHandler(this.btnAlterarUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(412, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtgridConsultaUsuario
            // 
            this.dtgridConsultaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridConsultaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoUsuario,
            this.Nome,
            this.Tipo});
            this.dtgridConsultaUsuario.Location = new System.Drawing.Point(13, 93);
            this.dtgridConsultaUsuario.Name = "dtgridConsultaUsuario";
            this.dtgridConsultaUsuario.Size = new System.Drawing.Size(494, 196);
            this.dtgridConsultaUsuario.TabIndex = 10;
            // 
            // CodigoUsuario
            // 
            this.CodigoUsuario.HeaderText = "Codigo do Usuario";
            this.CodigoUsuario.Name = "CodigoUsuario";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Usuario";
            this.Nome.Name = "Nome";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo Usuario";
            this.Tipo.Name = "Tipo";
            // 
            // btnConsultaUsuario
            // 
            this.btnConsultaUsuario.Location = new System.Drawing.Point(432, 48);
            this.btnConsultaUsuario.Name = "btnConsultaUsuario";
            this.btnConsultaUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaUsuario.TabIndex = 9;
            this.btnConsultaUsuario.Text = "Consultar";
            this.btnConsultaUsuario.UseVisualStyleBackColor = true;
            this.btnConsultaUsuario.Click += new System.EventHandler(this.btnConsultaUsuario_Click);
            // 
            // txtConsultaUsuario
            // 
            this.txtConsultaUsuario.Location = new System.Drawing.Point(202, 51);
            this.txtConsultaUsuario.Name = "txtConsultaUsuario";
            this.txtConsultaUsuario.Size = new System.Drawing.Size(224, 20);
            this.txtConsultaUsuario.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o nome ou o código do usuario:";
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 342);
            this.Controls.Add(this.btnAlterarUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgridConsultaUsuario);
            this.Controls.Add(this.btnConsultaUsuario);
            this.Controls.Add(this.txtConsultaUsuario);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "ConsultarUsuario";
            this.Text = "ConsultarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dtgridConsultaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Button btnConsultaUsuario;
        private System.Windows.Forms.TextBox txtConsultaUsuario;
        private System.Windows.Forms.Label label1;
    }
}