namespace Project.FlorInvent.UI
{
    partial class ConsultarCliente
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
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.dtgridConsultaCliente = new System.Windows.Forms.DataGridView();
            this.CodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.txtConsultaCliente = new System.Windows.Forms.TextBox();
            this.lblConsultaCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Location = new System.Drawing.Point(466, 343);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(86, 31);
            this.btnCancelarCliente.TabIndex = 17;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Location = new System.Drawing.Point(374, 343);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(86, 31);
            this.btnAlterarCliente.TabIndex = 16;
            this.btnAlterarCliente.Text = "Alterar";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // dtgridConsultaCliente
            // 
            this.dtgridConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridConsultaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCliente,
            this.Nome,
            this.CPF,
            this.Telefone,
            this.Estado,
            this.CEP,
            this.Cidade,
            this.Bairro,
            this.Logradouro,
            this.Numero,
            this.Complemento});
            this.dtgridConsultaCliente.Location = new System.Drawing.Point(18, 82);
            this.dtgridConsultaCliente.Name = "dtgridConsultaCliente";
            this.dtgridConsultaCliente.Size = new System.Drawing.Size(534, 245);
            this.dtgridConsultaCliente.TabIndex = 15;
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.HeaderText = "Cód Cliente";
            this.CodigoCliente.Name = "CodigoCliente";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
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
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(430, 52);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCliente.TabIndex = 14;
            this.btnConsultarCliente.Text = "Buscar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Location = new System.Drawing.Point(18, 56);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(405, 20);
            this.txtConsultaCliente.TabIndex = 13;
            // 
            // lblConsultaCliente
            // 
            this.lblConsultaCliente.AutoSize = true;
            this.lblConsultaCliente.Location = new System.Drawing.Point(15, 39);
            this.lblConsultaCliente.Name = "lblConsultaCliente";
            this.lblConsultaCliente.Size = new System.Drawing.Size(162, 13);
            this.lblConsultaCliente.TabIndex = 12;
            this.lblConsultaCliente.Text = "Digite o nome ou CPF do cliente:";
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 380);
            this.Controls.Add(this.btnCancelarCliente);
            this.Controls.Add(this.btnAlterarCliente);
            this.Controls.Add(this.dtgridConsultaCliente);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.txtConsultaCliente);
            this.Controls.Add(this.lblConsultaCliente);
            this.MaximizeBox = false;
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.DataGridView dtgridConsultaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.TextBox txtConsultaCliente;
        private System.Windows.Forms.Label lblConsultaCliente;
    }
}