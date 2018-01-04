namespace Project.FlorInvent.UI
{
    partial class RelatorioSaida
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
            this.mkdTxtBuscarSaida = new System.Windows.Forms.MaskedTextBox();
            this.btnSairRelatorio = new System.Windows.Forms.Button();
            this.dtgridRelatorioSaida = new System.Windows.Forms.DataGridView();
            this.btnBuscarSaida = new System.Windows.Forms.Button();
            this.lblBuscaSaida = new System.Windows.Forms.Label();
            this.btnItensMovimentacao = new System.Windows.Forms.Button();
            this.CodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMovimentoSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridRelatorioSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // mkdTxtBuscarSaida
            // 
            this.mkdTxtBuscarSaida.Location = new System.Drawing.Point(281, 51);
            this.mkdTxtBuscarSaida.Mask = "00/00/0000";
            this.mkdTxtBuscarSaida.Name = "mkdTxtBuscarSaida";
            this.mkdTxtBuscarSaida.Size = new System.Drawing.Size(72, 20);
            this.mkdTxtBuscarSaida.TabIndex = 15;
            this.mkdTxtBuscarSaida.ValidatingType = typeof(System.DateTime);
            // 
            // btnSairRelatorio
            // 
            this.btnSairRelatorio.Location = new System.Drawing.Point(377, 405);
            this.btnSairRelatorio.Name = "btnSairRelatorio";
            this.btnSairRelatorio.Size = new System.Drawing.Size(80, 34);
            this.btnSairRelatorio.TabIndex = 14;
            this.btnSairRelatorio.Text = "Sair";
            this.btnSairRelatorio.UseVisualStyleBackColor = true;
            this.btnSairRelatorio.Click += new System.EventHandler(this.btnSairRelatorio_Click);
            // 
            // dtgridRelatorioSaida
            // 
            this.dtgridRelatorioSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridRelatorioSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCliente,
            this.IdMovimentoSaida,
            this.CodigoUsuario,
            this.DataMovimento});
            this.dtgridRelatorioSaida.Location = new System.Drawing.Point(16, 89);
            this.dtgridRelatorioSaida.Name = "dtgridRelatorioSaida";
            this.dtgridRelatorioSaida.Size = new System.Drawing.Size(441, 310);
            this.dtgridRelatorioSaida.TabIndex = 13;
            // 
            // btnBuscarSaida
            // 
            this.btnBuscarSaida.Location = new System.Drawing.Point(383, 45);
            this.btnBuscarSaida.Name = "btnBuscarSaida";
            this.btnBuscarSaida.Size = new System.Drawing.Size(74, 30);
            this.btnBuscarSaida.TabIndex = 12;
            this.btnBuscarSaida.Text = "Buscar";
            this.btnBuscarSaida.UseVisualStyleBackColor = true;
            this.btnBuscarSaida.Click += new System.EventHandler(this.btnBuscarSaida_Click);
            // 
            // lblBuscaSaida
            // 
            this.lblBuscaSaida.AutoSize = true;
            this.lblBuscaSaida.Location = new System.Drawing.Point(13, 54);
            this.lblBuscaSaida.Name = "lblBuscaSaida";
            this.lblBuscaSaida.Size = new System.Drawing.Size(262, 13);
            this.lblBuscaSaida.TabIndex = 11;
            this.lblBuscaSaida.Text = "Digite a data em que deseja exibir a saida no estoque:";
            // 
            // btnItensMovimentacao
            // 
            this.btnItensMovimentacao.Location = new System.Drawing.Point(235, 405);
            this.btnItensMovimentacao.Name = "btnItensMovimentacao";
            this.btnItensMovimentacao.Size = new System.Drawing.Size(136, 34);
            this.btnItensMovimentacao.TabIndex = 16;
            this.btnItensMovimentacao.Text = "Visualizar movimentação";
            this.btnItensMovimentacao.UseVisualStyleBackColor = true;
            this.btnItensMovimentacao.Click += new System.EventHandler(this.btnItensMovimentacao_Click);
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.HeaderText = "Cliente";
            this.CodigoCliente.Name = "CodigoCliente";
            // 
            // IdMovimentoSaida
            // 
            this.IdMovimentoSaida.HeaderText = "Codigo Movimento Saida";
            this.IdMovimentoSaida.Name = "IdMovimentoSaida";
            this.IdMovimentoSaida.Visible = false;
            // 
            // CodigoUsuario
            // 
            this.CodigoUsuario.HeaderText = "Usuario";
            this.CodigoUsuario.Name = "CodigoUsuario";
            // 
            // DataMovimento
            // 
            this.DataMovimento.HeaderText = "Data da movimentação saida";
            this.DataMovimento.Name = "DataMovimento";
            this.DataMovimento.Width = 200;
            // 
            // RelatorioSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 447);
            this.Controls.Add(this.btnItensMovimentacao);
            this.Controls.Add(this.mkdTxtBuscarSaida);
            this.Controls.Add(this.btnSairRelatorio);
            this.Controls.Add(this.dtgridRelatorioSaida);
            this.Controls.Add(this.btnBuscarSaida);
            this.Controls.Add(this.lblBuscaSaida);
            this.MaximizeBox = false;
            this.Name = "RelatorioSaida";
            this.Text = "RelatorioSaida";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridRelatorioSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mkdTxtBuscarSaida;
        private System.Windows.Forms.Button btnSairRelatorio;
        private System.Windows.Forms.DataGridView dtgridRelatorioSaida;
        private System.Windows.Forms.Button btnBuscarSaida;
        private System.Windows.Forms.Label lblBuscaSaida;
        private System.Windows.Forms.Button btnItensMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMovimentoSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataMovimento;
    }
}