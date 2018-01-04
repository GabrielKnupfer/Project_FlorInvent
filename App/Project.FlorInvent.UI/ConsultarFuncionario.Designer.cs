namespace Project.FlorInvent.UI
{
    partial class ConsultarFuncionario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dtgridConsultarFuncionario = new System.Windows.Forms.DataGridView();
            this.CodigoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.txtConsultaFuncionario = new System.Windows.Forms.TextBox();
            this.lblConsultaFuncionario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultarFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(460, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(368, 359);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(86, 31);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dtgridConsultarFuncionario
            // 
            this.dtgridConsultarFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridConsultarFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoFuncionario,
            this.Nome,
            this.DataNascimento,
            this.Sexo,
            this.CPF,
            this.Telefone,
            this.Estado,
            this.CEP,
            this.Cidade,
            this.Bairro,
            this.Logradouro,
            this.Numero,
            this.Complemento,
            this.DataAdmissao});
            this.dtgridConsultarFuncionario.Location = new System.Drawing.Point(12, 98);
            this.dtgridConsultarFuncionario.Name = "dtgridConsultarFuncionario";
            this.dtgridConsultarFuncionario.Size = new System.Drawing.Size(534, 245);
            this.dtgridConsultarFuncionario.TabIndex = 9;
            // 
            // CodigoFuncionario
            // 
            this.CodigoFuncionario.HeaderText = "Código Funcionário";
            this.CodigoFuncionario.Name = "CodigoFuncionario";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "Data de Nascimento";
            this.DataNascimento.Name = "DataNascimento";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
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
            // DataAdmissao
            // 
            this.DataAdmissao.HeaderText = "Data Admissao";
            this.DataAdmissao.Name = "DataAdmissao";
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(424, 59);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarFuncionario.TabIndex = 8;
            this.btnConsultarFuncionario.Text = "Buscar";
            this.btnConsultarFuncionario.UseVisualStyleBackColor = true;
            this.btnConsultarFuncionario.Click += new System.EventHandler(this.btnConsultarFuncionario_Click);
            // 
            // txtConsultaFuncionario
            // 
            this.txtConsultaFuncionario.Location = new System.Drawing.Point(12, 63);
            this.txtConsultaFuncionario.Name = "txtConsultaFuncionario";
            this.txtConsultaFuncionario.Size = new System.Drawing.Size(405, 20);
            this.txtConsultaFuncionario.TabIndex = 7;
            // 
            // lblConsultaFuncionario
            // 
            this.lblConsultaFuncionario.AutoSize = true;
            this.lblConsultaFuncionario.Location = new System.Drawing.Point(9, 46);
            this.lblConsultaFuncionario.Name = "lblConsultaFuncionario";
            this.lblConsultaFuncionario.Size = new System.Drawing.Size(183, 13);
            this.lblConsultaFuncionario.TabIndex = 6;
            this.lblConsultaFuncionario.Text = "Digite o nome ou CPF do funcionário:";
            // 
            // ConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 396);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dtgridConsultarFuncionario);
            this.Controls.Add(this.btnConsultarFuncionario);
            this.Controls.Add(this.txtConsultaFuncionario);
            this.Controls.Add(this.lblConsultaFuncionario);
            this.MaximizeBox = false;
            this.Name = "ConsultarFuncionario";
            this.Text = "ConsultarFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultarFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dtgridConsultarFuncionario;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.TextBox txtConsultaFuncionario;
        private System.Windows.Forms.Label lblConsultaFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAdmissao;
    }
}