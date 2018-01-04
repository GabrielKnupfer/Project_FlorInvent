namespace Project.FlorInvent.UI
{
    partial class AlterarFuncionario
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mkdtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mkdtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.mkdtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.mkdtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mkdtxtDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.mkdtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbSexoFeminino = new System.Windows.Forms.RadioButton();
            this.rdbSexoMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(622, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 39);
            this.btnCancelar.TabIndex = 80;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(498, 275);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 39);
            this.btnSalvar.TabIndex = 79;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // mkdtxtCPF
            // 
            this.mkdtxtCPF.Location = new System.Drawing.Point(55, 88);
            this.mkdtxtCPF.Mask = "000,000,000-00";
            this.mkdtxtCPF.Name = "mkdtxtCPF";
            this.mkdtxtCPF.Size = new System.Drawing.Size(155, 20);
            this.mkdtxtCPF.TabIndex = 138;
            // 
            // mkdtxtCEP
            // 
            this.mkdtxtCEP.Location = new System.Drawing.Point(574, 118);
            this.mkdtxtCEP.Mask = "00000-000";
            this.mkdtxtCEP.Name = "mkdtxtCEP";
            this.mkdtxtCEP.Size = new System.Drawing.Size(161, 20);
            this.mkdtxtCEP.TabIndex = 137;
            // 
            // mkdtxtNumero
            // 
            this.mkdtxtNumero.Location = new System.Drawing.Point(697, 162);
            this.mkdtxtNumero.Mask = "0099";
            this.mkdtxtNumero.Name = "mkdtxtNumero";
            this.mkdtxtNumero.Size = new System.Drawing.Size(43, 20);
            this.mkdtxtNumero.TabIndex = 136;
            // 
            // mkdtxtTelefone
            // 
            this.mkdtxtTelefone.Location = new System.Drawing.Point(275, 85);
            this.mkdtxtTelefone.Mask = "(99) 0000-0000";
            this.mkdtxtTelefone.Name = "mkdtxtTelefone";
            this.mkdtxtTelefone.Size = new System.Drawing.Size(115, 20);
            this.mkdtxtTelefone.TabIndex = 135;
            // 
            // mkdtxtDataAdmissao
            // 
            this.mkdtxtDataAdmissao.Location = new System.Drawing.Point(101, 232);
            this.mkdtxtDataAdmissao.Mask = "00/00/0000";
            this.mkdtxtDataAdmissao.Name = "mkdtxtDataAdmissao";
            this.mkdtxtDataAdmissao.Size = new System.Drawing.Size(100, 20);
            this.mkdtxtDataAdmissao.TabIndex = 134;
            this.mkdtxtDataAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // mkdtxtDataNascimento
            // 
            this.mkdtxtDataNascimento.Location = new System.Drawing.Point(655, 55);
            this.mkdtxtDataNascimento.Mask = "00/00/0000";
            this.mkdtxtDataNascimento.Name = "mkdtxtDataNascimento";
            this.mkdtxtDataNascimento.Size = new System.Drawing.Size(85, 20);
            this.mkdtxtDataNascimento.TabIndex = 133;
            this.mkdtxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(14, 235);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(81, 13);
            this.lblDataAdmissao.TabIndex = 132;
            this.lblDataAdmissao.Text = "Data Admissão:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(94, 197);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(313, 20);
            this.txtComplemento.TabIndex = 131;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(14, 200);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 130;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(644, 165);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 129;
            this.lblNumero.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(353, 162);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(285, 20);
            this.txtLogradouro.TabIndex = 128;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(283, 165);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 127;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(55, 162);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(213, 20);
            this.txtBairro.TabIndex = 126;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(11, 165);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 125;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(557, 58);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(92, 13);
            this.lblDataNascimento.TabIndex = 124;
            this.lblDataNascimento.Text = "Data Nascimento:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbSexoFeminino);
            this.panel1.Controls.Add(this.rdbSexoMasculino);
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Location = new System.Drawing.Point(418, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 54);
            this.panel1.TabIndex = 123;
            // 
            // rdbSexoFeminino
            // 
            this.rdbSexoFeminino.AutoSize = true;
            this.rdbSexoFeminino.Location = new System.Drawing.Point(45, 27);
            this.rdbSexoFeminino.Name = "rdbSexoFeminino";
            this.rdbSexoFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbSexoFeminino.TabIndex = 2;
            this.rdbSexoFeminino.TabStop = true;
            this.rdbSexoFeminino.Text = "Feminino";
            this.rdbSexoFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbSexoMasculino
            // 
            this.rdbSexoMasculino.AutoSize = true;
            this.rdbSexoMasculino.Location = new System.Drawing.Point(45, 4);
            this.rdbSexoMasculino.Name = "rdbSexoMasculino";
            this.rdbSexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbSexoMasculino.TabIndex = 1;
            this.rdbSexoMasculino.TabStop = true;
            this.rdbSexoMasculino.Text = "Masculino";
            this.rdbSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(4, 4);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(536, 121);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 122;
            this.lblCEP.Text = "CEP:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(324, 118);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(188, 20);
            this.txtCidade.TabIndex = 121;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(275, 121);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 120;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(55, 118);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(201, 20);
            this.txtEstado.TabIndex = 119;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(11, 121);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 118;
            this.lblEstado.Text = "Estado:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(216, 88);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 117;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(11, 88);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 116;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(55, 55);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(335, 20);
            this.txtNomeFuncionario.TabIndex = 115;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(11, 58);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(38, 13);
            this.lblNomeFuncionario.TabIndex = 114;
            this.lblNomeFuncionario.Text = "Nome:";
            // 
            // AlterarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 335);
            this.Controls.Add(this.mkdtxtCPF);
            this.Controls.Add(this.mkdtxtCEP);
            this.Controls.Add(this.mkdtxtNumero);
            this.Controls.Add(this.mkdtxtTelefone);
            this.Controls.Add(this.mkdtxtDataAdmissao);
            this.Controls.Add(this.mkdtxtDataNascimento);
            this.Controls.Add(this.lblDataAdmissao);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.Name = "AlterarFuncionario";
            this.Text = "AlterarFuncionario";
            this.Load += new System.EventHandler(this.AlterarFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mkdtxtCPF;
        private System.Windows.Forms.MaskedTextBox mkdtxtCEP;
        private System.Windows.Forms.MaskedTextBox mkdtxtNumero;
        private System.Windows.Forms.MaskedTextBox mkdtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mkdtxtDataAdmissao;
        private System.Windows.Forms.MaskedTextBox mkdtxtDataNascimento;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbSexoFeminino;
        private System.Windows.Forms.RadioButton rdbSexoMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
    }
}