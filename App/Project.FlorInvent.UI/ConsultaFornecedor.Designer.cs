namespace Project.FlorInvent.UI
{
    partial class ConsultaFornecedor
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
            this.btnCancelarFornecedor = new System.Windows.Forms.Button();
            this.btnAlterarFornecedor = new System.Windows.Forms.Button();
            this.dtgridConsultaFornecedor = new System.Windows.Forms.DataGridView();
            this.CodigoFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarFornecedor = new System.Windows.Forms.Button();
            this.txtConsultaFornecedor = new System.Windows.Forms.TextBox();
            this.lblConsultaFornecedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarFornecedor
            // 
            this.btnCancelarFornecedor.Location = new System.Drawing.Point(460, 343);
            this.btnCancelarFornecedor.Name = "btnCancelarFornecedor";
            this.btnCancelarFornecedor.Size = new System.Drawing.Size(86, 31);
            this.btnCancelarFornecedor.TabIndex = 23;
            this.btnCancelarFornecedor.Text = "Cancelar";
            this.btnCancelarFornecedor.UseVisualStyleBackColor = true;
            this.btnCancelarFornecedor.Click += new System.EventHandler(this.btnCancelarFornecedor_Click);
            // 
            // btnAlterarFornecedor
            // 
            this.btnAlterarFornecedor.Location = new System.Drawing.Point(368, 343);
            this.btnAlterarFornecedor.Name = "btnAlterarFornecedor";
            this.btnAlterarFornecedor.Size = new System.Drawing.Size(86, 31);
            this.btnAlterarFornecedor.TabIndex = 22;
            this.btnAlterarFornecedor.Text = "Alterar";
            this.btnAlterarFornecedor.UseVisualStyleBackColor = true;
            this.btnAlterarFornecedor.Click += new System.EventHandler(this.btnAlterarFornecedor_Click);
            // 
            // dtgridConsultaFornecedor
            // 
            this.dtgridConsultaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridConsultaFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoFornecedor,
            this.Nome,
            this.CNPJ,
            this.Telefone,
            this.Estado,
            this.CEP,
            this.Cidade,
            this.Bairro,
            this.Logradouro,
            this.Numero,
            this.Complemento});
            this.dtgridConsultaFornecedor.Location = new System.Drawing.Point(12, 82);
            this.dtgridConsultaFornecedor.Name = "dtgridConsultaFornecedor";
            this.dtgridConsultaFornecedor.Size = new System.Drawing.Size(534, 245);
            this.dtgridConsultaFornecedor.TabIndex = 21;
            // 
            // CodigoFornecedor
            // 
            this.CodigoFornecedor.HeaderText = "Cód Fornecedor";
            this.CodigoFornecedor.Name = "CodigoFornecedor";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            // 
            // Logradouro
            // 
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // Complemento
            // 
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            // 
            // btnConsultarFornecedor
            // 
            this.btnConsultarFornecedor.Location = new System.Drawing.Point(424, 52);
            this.btnConsultarFornecedor.Name = "btnConsultarFornecedor";
            this.btnConsultarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarFornecedor.TabIndex = 20;
            this.btnConsultarFornecedor.Text = "Buscar";
            this.btnConsultarFornecedor.UseVisualStyleBackColor = true;
            this.btnConsultarFornecedor.Click += new System.EventHandler(this.btnConsultarFornecedor_Click);
            // 
            // txtConsultaFornecedor
            // 
            this.txtConsultaFornecedor.Location = new System.Drawing.Point(12, 56);
            this.txtConsultaFornecedor.Name = "txtConsultaFornecedor";
            this.txtConsultaFornecedor.Size = new System.Drawing.Size(405, 20);
            this.txtConsultaFornecedor.TabIndex = 19;
            // 
            // lblConsultaFornecedor
            // 
            this.lblConsultaFornecedor.AutoSize = true;
            this.lblConsultaFornecedor.Location = new System.Drawing.Point(9, 39);
            this.lblConsultaFornecedor.Name = "lblConsultaFornecedor";
            this.lblConsultaFornecedor.Size = new System.Drawing.Size(189, 13);
            this.lblConsultaFornecedor.TabIndex = 18;
            this.lblConsultaFornecedor.Text = "Digite o nome ou CNPJ do fornecedor:";
            // 
            // ConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 382);
            this.Controls.Add(this.btnCancelarFornecedor);
            this.Controls.Add(this.btnAlterarFornecedor);
            this.Controls.Add(this.dtgridConsultaFornecedor);
            this.Controls.Add(this.btnConsultarFornecedor);
            this.Controls.Add(this.txtConsultaFornecedor);
            this.Controls.Add(this.lblConsultaFornecedor);
            this.MaximizeBox = false;
            this.Name = "ConsultaFornecedor";
            this.Text = "ConsultaFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarFornecedor;
        private System.Windows.Forms.Button btnAlterarFornecedor;
        private System.Windows.Forms.DataGridView dtgridConsultaFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.Button btnConsultarFornecedor;
        private System.Windows.Forms.TextBox txtConsultaFornecedor;
        private System.Windows.Forms.Label lblConsultaFornecedor;
    }
}