namespace Project.FlorInvent.UI
{
    partial class CadastroUsuario
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
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtConfirmSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmSenha = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(173, 176);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(79, 28);
            this.btnCadastrarUsuario.TabIndex = 17;
            this.btnCadastrarUsuario.Text = "Cadastrar";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Comum"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(90, 130);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(134, 21);
            this.cmbTipoUsuario.TabIndex = 16;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(7, 130);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(31, 13);
            this.lblTipoUsuario.TabIndex = 15;
            this.lblTipoUsuario.Text = "Tipo:";
            // 
            // txtConfirmSenha
            // 
            this.txtConfirmSenha.Location = new System.Drawing.Point(150, 100);
            this.txtConfirmSenha.Name = "txtConfirmSenha";
            this.txtConfirmSenha.PasswordChar = '*';
            this.txtConfirmSenha.Size = new System.Drawing.Size(189, 20);
            this.txtConfirmSenha.TabIndex = 14;
            // 
            // lblConfirmSenha
            // 
            this.lblConfirmSenha.AutoSize = true;
            this.lblConfirmSenha.Location = new System.Drawing.Point(7, 107);
            this.lblConfirmSenha.Name = "lblConfirmSenha";
            this.lblConfirmSenha.Size = new System.Drawing.Size(134, 13);
            this.lblConfirmSenha.TabIndex = 13;
            this.lblConfirmSenha.Text = "Digite a senha novamente:";
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(90, 74);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '*';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(249, 20);
            this.txtSenhaUsuario.TabIndex = 12;
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Location = new System.Drawing.Point(7, 77);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaUsuario.TabIndex = 11;
            this.lblSenhaUsuario.Text = "Senha:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(90, 47);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(249, 20);
            this.txtNomeUsuario.TabIndex = 10;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(7, 50);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(77, 13);
            this.lblNomeUsuario.TabIndex = 9;
            this.lblNomeUsuario.Text = "Nome Usuario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 28);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 240);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.txtConfirmSenha);
            this.Controls.Add(this.lblConfirmSenha);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.lblSenhaUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblNomeUsuario);
            this.MaximizeBox = false;
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.TextBox txtConfirmSenha;
        private System.Windows.Forms.Label lblConfirmSenha;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Button btnCancelar;
    }
}