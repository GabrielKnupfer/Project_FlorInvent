namespace Project.FlorInvent.UI
{
    partial class RelatorioEntrada
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
            this.mkdtxtBuscarEntrada = new System.Windows.Forms.MaskedTextBox();
            this.btnSairRelatorio = new System.Windows.Forms.Button();
            this.dtgridRelatorioEntrada = new System.Windows.Forms.DataGridView();
            this.btnBuscarEntrada = new System.Windows.Forms.Button();
            this.lblBuscaEntrada = new System.Windows.Forms.Label();
            this.btnItensMovimentacao = new System.Windows.Forms.Button();
            this.CodigoFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMovimentoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridRelatorioEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // mkdtxtBuscarEntrada
            // 
            this.mkdtxtBuscarEntrada.Location = new System.Drawing.Point(288, 52);
            this.mkdtxtBuscarEntrada.Mask = "00/00/0000";
            this.mkdtxtBuscarEntrada.Name = "mkdtxtBuscarEntrada";
            this.mkdtxtBuscarEntrada.Size = new System.Drawing.Size(72, 20);
            this.mkdtxtBuscarEntrada.TabIndex = 10;
            this.mkdtxtBuscarEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // btnSairRelatorio
            // 
            this.btnSairRelatorio.Location = new System.Drawing.Point(405, 406);
            this.btnSairRelatorio.Name = "btnSairRelatorio";
            this.btnSairRelatorio.Size = new System.Drawing.Size(75, 34);
            this.btnSairRelatorio.TabIndex = 9;
            this.btnSairRelatorio.Text = "Sair";
            this.btnSairRelatorio.UseVisualStyleBackColor = true;
            this.btnSairRelatorio.Click += new System.EventHandler(this.btnSairRelatorio_Click);
            // 
            // dtgridRelatorioEntrada
            // 
            this.dtgridRelatorioEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridRelatorioEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoFornecedor,
            this.IdMovimentoEntrada,
            this.CodigoUsuario,
            this.DataMovimento});
            this.dtgridRelatorioEntrada.Location = new System.Drawing.Point(12, 90);
            this.dtgridRelatorioEntrada.Name = "dtgridRelatorioEntrada";
            this.dtgridRelatorioEntrada.Size = new System.Drawing.Size(468, 310);
            this.dtgridRelatorioEntrada.TabIndex = 8;
            // 
            // btnBuscarEntrada
            // 
            this.btnBuscarEntrada.Location = new System.Drawing.Point(382, 52);
            this.btnBuscarEntrada.Name = "btnBuscarEntrada";
            this.btnBuscarEntrada.Size = new System.Drawing.Size(98, 30);
            this.btnBuscarEntrada.TabIndex = 7;
            this.btnBuscarEntrada.Text = "Buscar";
            this.btnBuscarEntrada.UseVisualStyleBackColor = true;
            this.btnBuscarEntrada.Click += new System.EventHandler(this.btnBuscarEntrada_Click);
            // 
            // lblBuscaEntrada
            // 
            this.lblBuscaEntrada.AutoSize = true;
            this.lblBuscaEntrada.Location = new System.Drawing.Point(9, 55);
            this.lblBuscaEntrada.Name = "lblBuscaEntrada";
            this.lblBuscaEntrada.Size = new System.Drawing.Size(273, 13);
            this.lblBuscaEntrada.TabIndex = 6;
            this.lblBuscaEntrada.Text = "Digite a data em que deseja exibir a entrada no estoque:";
            // 
            // btnItensMovimentacao
            // 
            this.btnItensMovimentacao.Location = new System.Drawing.Point(263, 406);
            this.btnItensMovimentacao.Name = "btnItensMovimentacao";
            this.btnItensMovimentacao.Size = new System.Drawing.Size(136, 34);
            this.btnItensMovimentacao.TabIndex = 11;
            this.btnItensMovimentacao.Text = "Visualizar movimentação";
            this.btnItensMovimentacao.UseVisualStyleBackColor = true;
            this.btnItensMovimentacao.Click += new System.EventHandler(this.btnItensMovimentacao_Click);
            // 
            // CodigoFornecedor
            // 
            this.CodigoFornecedor.HeaderText = "Codigo do Fornecedor";
            this.CodigoFornecedor.Name = "CodigoFornecedor";
            this.CodigoFornecedor.Width = 150;
            // 
            // IdMovimentoEntrada
            // 
            this.IdMovimentoEntrada.HeaderText = "Codigo Movimentação";
            this.IdMovimentoEntrada.Name = "IdMovimentoEntrada";
            this.IdMovimentoEntrada.Visible = false;
            // 
            // CodigoUsuario
            // 
            this.CodigoUsuario.HeaderText = "Usuario";
            this.CodigoUsuario.Name = "CodigoUsuario";
            // 
            // DataMovimento
            // 
            this.DataMovimento.HeaderText = "Data da movimentação entrada";
            this.DataMovimento.Name = "DataMovimento";
            this.DataMovimento.Width = 200;
            // 
            // RelatorioEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 452);
            this.Controls.Add(this.btnItensMovimentacao);
            this.Controls.Add(this.mkdtxtBuscarEntrada);
            this.Controls.Add(this.btnSairRelatorio);
            this.Controls.Add(this.dtgridRelatorioEntrada);
            this.Controls.Add(this.btnBuscarEntrada);
            this.Controls.Add(this.lblBuscaEntrada);
            this.MaximizeBox = false;
            this.Name = "RelatorioEntrada";
            this.Text = "RelatorioEntrada";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridRelatorioEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mkdtxtBuscarEntrada;
        private System.Windows.Forms.Button btnSairRelatorio;
        private System.Windows.Forms.DataGridView dtgridRelatorioEntrada;
        private System.Windows.Forms.Button btnBuscarEntrada;
        private System.Windows.Forms.Label lblBuscaEntrada;
        private System.Windows.Forms.Button btnItensMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMovimentoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataMovimento;
    }
}