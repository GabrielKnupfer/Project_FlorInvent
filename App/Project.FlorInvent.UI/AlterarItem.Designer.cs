namespace Project.FlorInvent.UI
{
    partial class AlterarItem
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
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnSalvarItem = new System.Windows.Forms.Button();
            this.lblDepositoItem = new System.Windows.Forms.Label();
            this.txtDescricaoItem = new System.Windows.Forms.TextBox();
            this.lblDescricaoItem = new System.Windows.Forms.Label();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.lblNomeItem = new System.Windows.Forms.Label();
            this.cbTipoItem = new System.Windows.Forms.ComboBox();
            this.cbDeposito = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.Location = new System.Drawing.Point(322, 196);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(100, 38);
            this.btnCancelarItem.TabIndex = 48;
            this.btnCancelarItem.Text = "Cancelar";
            this.btnCancelarItem.UseVisualStyleBackColor = true;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnSalvarItem
            // 
            this.btnSalvarItem.Location = new System.Drawing.Point(199, 196);
            this.btnSalvarItem.Name = "btnSalvarItem";
            this.btnSalvarItem.Size = new System.Drawing.Size(100, 38);
            this.btnSalvarItem.TabIndex = 47;
            this.btnSalvarItem.Text = "Salvar";
            this.btnSalvarItem.UseVisualStyleBackColor = true;
            this.btnSalvarItem.Click += new System.EventHandler(this.btnSalvarItem_Click);
            // 
            // lblDepositoItem
            // 
            this.lblDepositoItem.AutoSize = true;
            this.lblDepositoItem.Location = new System.Drawing.Point(22, 163);
            this.lblDepositoItem.Name = "lblDepositoItem";
            this.lblDepositoItem.Size = new System.Drawing.Size(52, 13);
            this.lblDepositoItem.TabIndex = 45;
            this.lblDepositoItem.Text = "Deposito:";
            // 
            // txtDescricaoItem
            // 
            this.txtDescricaoItem.Location = new System.Drawing.Point(106, 125);
            this.txtDescricaoItem.Name = "txtDescricaoItem";
            this.txtDescricaoItem.Size = new System.Drawing.Size(316, 20);
            this.txtDescricaoItem.TabIndex = 44;
            // 
            // lblDescricaoItem
            // 
            this.lblDescricaoItem.AutoSize = true;
            this.lblDescricaoItem.Location = new System.Drawing.Point(22, 128);
            this.lblDescricaoItem.Name = "lblDescricaoItem";
            this.lblDescricaoItem.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoItem.TabIndex = 43;
            this.lblDescricaoItem.Text = "Descricao:";
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(22, 93);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(31, 13);
            this.lblTipoItem.TabIndex = 41;
            this.lblTipoItem.Text = "Tipo:";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(106, 55);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(316, 20);
            this.txtNomeItem.TabIndex = 40;
            // 
            // lblNomeItem
            // 
            this.lblNomeItem.AutoSize = true;
            this.lblNomeItem.Location = new System.Drawing.Point(22, 58);
            this.lblNomeItem.Name = "lblNomeItem";
            this.lblNomeItem.Size = new System.Drawing.Size(38, 13);
            this.lblNomeItem.TabIndex = 39;
            this.lblNomeItem.Text = "Nome:";
            // 
            // cbTipoItem
            // 
            this.cbTipoItem.FormattingEnabled = true;
            this.cbTipoItem.Location = new System.Drawing.Point(106, 90);
            this.cbTipoItem.Name = "cbTipoItem";
            this.cbTipoItem.Size = new System.Drawing.Size(197, 21);
            this.cbTipoItem.TabIndex = 61;
            this.cbTipoItem.SelectedIndexChanged += new System.EventHandler(this.cbTipoItem_SelectedIndexChanged);
            // 
            // cbDeposito
            // 
            this.cbDeposito.FormattingEnabled = true;
            this.cbDeposito.Location = new System.Drawing.Point(106, 160);
            this.cbDeposito.Name = "cbDeposito";
            this.cbDeposito.Size = new System.Drawing.Size(197, 21);
            this.cbDeposito.TabIndex = 62;
            this.cbDeposito.SelectedIndexChanged += new System.EventHandler(this.cbDeposito_SelectedIndexChanged);
            // 
            // AlterarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 270);
            this.Controls.Add(this.cbDeposito);
            this.Controls.Add(this.cbTipoItem);
            this.Controls.Add(this.btnCancelarItem);
            this.Controls.Add(this.btnSalvarItem);
            this.Controls.Add(this.lblDepositoItem);
            this.Controls.Add(this.txtDescricaoItem);
            this.Controls.Add(this.lblDescricaoItem);
            this.Controls.Add(this.lblTipoItem);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.lblNomeItem);
            this.MaximizeBox = false;
            this.Name = "AlterarItem";
            this.Text = "AlterarItem";
            this.Load += new System.EventHandler(this.AlterarItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnSalvarItem;
        private System.Windows.Forms.Label lblDepositoItem;
        private System.Windows.Forms.TextBox txtDescricaoItem;
        private System.Windows.Forms.Label lblDescricaoItem;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.Label lblNomeItem;
        private System.Windows.Forms.ComboBox cbTipoItem;
        private System.Windows.Forms.ComboBox cbDeposito;
    }
}