namespace Project.FlorInvent.UI
{
    partial class ConsultarDeposito
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
            this.btnExcluirDeposito = new System.Windows.Forms.Button();
            this.btnCancelarDeposito = new System.Windows.Forms.Button();
            this.btnAlterarDeposito = new System.Windows.Forms.Button();
            this.dtgridConsultarDeposito = new System.Windows.Forms.DataGridView();
            this.CodigoDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarDeposito = new System.Windows.Forms.Button();
            this.txtConsultarDeposito = new System.Windows.Forms.TextBox();
            this.lblConsultarDeposito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultarDeposito)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirDeposito
            // 
            this.btnExcluirDeposito.Location = new System.Drawing.Point(276, 352);
            this.btnExcluirDeposito.Name = "btnExcluirDeposito";
            this.btnExcluirDeposito.Size = new System.Drawing.Size(86, 31);
            this.btnExcluirDeposito.TabIndex = 38;
            this.btnExcluirDeposito.Text = "Excluir";
            this.btnExcluirDeposito.UseVisualStyleBackColor = true;
            this.btnExcluirDeposito.Visible = false;
            this.btnExcluirDeposito.Click += new System.EventHandler(this.btnExcluirDeposito_Click);
            // 
            // btnCancelarDeposito
            // 
            this.btnCancelarDeposito.Location = new System.Drawing.Point(460, 352);
            this.btnCancelarDeposito.Name = "btnCancelarDeposito";
            this.btnCancelarDeposito.Size = new System.Drawing.Size(86, 31);
            this.btnCancelarDeposito.TabIndex = 37;
            this.btnCancelarDeposito.Text = "Cancelar";
            this.btnCancelarDeposito.UseVisualStyleBackColor = true;
            this.btnCancelarDeposito.Click += new System.EventHandler(this.btnCancelarDeposito_Click);
            // 
            // btnAlterarDeposito
            // 
            this.btnAlterarDeposito.Location = new System.Drawing.Point(368, 352);
            this.btnAlterarDeposito.Name = "btnAlterarDeposito";
            this.btnAlterarDeposito.Size = new System.Drawing.Size(86, 31);
            this.btnAlterarDeposito.TabIndex = 36;
            this.btnAlterarDeposito.Text = "Alterar";
            this.btnAlterarDeposito.UseVisualStyleBackColor = true;
            this.btnAlterarDeposito.Click += new System.EventHandler(this.btnAlterarDeposito_Click);
            // 
            // dtgridConsultarDeposito
            // 
            this.dtgridConsultarDeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridConsultarDeposito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeposito,
            this.Descricao,
            this.Estado,
            this.CEP,
            this.Cidade,
            this.Bairro,
            this.Logradouro,
            this.Numero,
            this.Complemento});
            this.dtgridConsultarDeposito.Location = new System.Drawing.Point(12, 91);
            this.dtgridConsultarDeposito.Name = "dtgridConsultarDeposito";
            this.dtgridConsultarDeposito.Size = new System.Drawing.Size(534, 245);
            this.dtgridConsultarDeposito.TabIndex = 35;
            // 
            // CodigoDeposito
            // 
            this.CodigoDeposito.HeaderText = "Cód Deposito";
            this.CodigoDeposito.Name = "CodigoDeposito";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
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
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            // 
            // Complemento
            // 
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            // 
            // btnConsultarDeposito
            // 
            this.btnConsultarDeposito.Location = new System.Drawing.Point(424, 61);
            this.btnConsultarDeposito.Name = "btnConsultarDeposito";
            this.btnConsultarDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarDeposito.TabIndex = 34;
            this.btnConsultarDeposito.Text = "Buscar";
            this.btnConsultarDeposito.UseVisualStyleBackColor = true;
            this.btnConsultarDeposito.Click += new System.EventHandler(this.btnConsultarDeposito_Click);
            // 
            // txtConsultarDeposito
            // 
            this.txtConsultarDeposito.Location = new System.Drawing.Point(12, 65);
            this.txtConsultarDeposito.Name = "txtConsultarDeposito";
            this.txtConsultarDeposito.Size = new System.Drawing.Size(405, 20);
            this.txtConsultarDeposito.TabIndex = 33;
            // 
            // lblConsultarDeposito
            // 
            this.lblConsultarDeposito.AutoSize = true;
            this.lblConsultarDeposito.Location = new System.Drawing.Point(9, 48);
            this.lblConsultarDeposito.Name = "lblConsultarDeposito";
            this.lblConsultarDeposito.Size = new System.Drawing.Size(183, 13);
            this.lblConsultarDeposito.TabIndex = 32;
            this.lblConsultarDeposito.Text = "Digite o nome ou código do deposito:";
            // 
            // ConsultarDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 386);
            this.Controls.Add(this.btnExcluirDeposito);
            this.Controls.Add(this.btnCancelarDeposito);
            this.Controls.Add(this.btnAlterarDeposito);
            this.Controls.Add(this.dtgridConsultarDeposito);
            this.Controls.Add(this.btnConsultarDeposito);
            this.Controls.Add(this.txtConsultarDeposito);
            this.Controls.Add(this.lblConsultarDeposito);
            this.MaximizeBox = false;
            this.Name = "ConsultarDeposito";
            this.Text = "ConsultarDeposito";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultarDeposito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirDeposito;
        private System.Windows.Forms.Button btnCancelarDeposito;
        private System.Windows.Forms.Button btnAlterarDeposito;
        private System.Windows.Forms.DataGridView dtgridConsultarDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.Button btnConsultarDeposito;
        private System.Windows.Forms.TextBox txtConsultarDeposito;
        private System.Windows.Forms.Label lblConsultarDeposito;
    }
}