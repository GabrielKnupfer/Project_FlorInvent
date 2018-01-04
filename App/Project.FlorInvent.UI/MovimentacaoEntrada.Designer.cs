namespace Project.FlorInvent.UI
{
    partial class MovimentacaoEntrada
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
            this.lstItens = new System.Windows.Forms.ListBox();
            this.btnCancelarEntrada = new System.Windows.Forms.Button();
            this.btnSalvarEntrada = new System.Windows.Forms.Button();
            this.dtgridItensSelecionados = new System.Windows.Forms.DataGridView();
            this.CodigoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItensSelecionados = new System.Windows.Forms.Label();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtBuscarItem = new System.Windows.Forms.TextBox();
            this.lblBuscarItem = new System.Windows.Forms.Label();
            this.lblSelecionarFornecedor = new System.Windows.Forms.Label();
            this.cmbSelecionarFornecedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridItensSelecionados)).BeginInit();
            this.SuspendLayout();
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.Location = new System.Drawing.Point(12, 113);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(523, 95);
            this.lstItens.TabIndex = 106;
            this.lstItens.DoubleClick += new System.EventHandler(this.lstItens_DoubleClick);
            // 
            // btnCancelarEntrada
            // 
            this.btnCancelarEntrada.Location = new System.Drawing.Point(422, 402);
            this.btnCancelarEntrada.Name = "btnCancelarEntrada";
            this.btnCancelarEntrada.Size = new System.Drawing.Size(113, 39);
            this.btnCancelarEntrada.TabIndex = 105;
            this.btnCancelarEntrada.Text = "Cancelar";
            this.btnCancelarEntrada.UseVisualStyleBackColor = true;
            this.btnCancelarEntrada.Click += new System.EventHandler(this.btnCancelarEntrada_Click);
            // 
            // btnSalvarEntrada
            // 
            this.btnSalvarEntrada.Location = new System.Drawing.Point(286, 402);
            this.btnSalvarEntrada.Name = "btnSalvarEntrada";
            this.btnSalvarEntrada.Size = new System.Drawing.Size(113, 39);
            this.btnSalvarEntrada.TabIndex = 104;
            this.btnSalvarEntrada.Text = "Salvar";
            this.btnSalvarEntrada.UseVisualStyleBackColor = true;
            this.btnSalvarEntrada.Click += new System.EventHandler(this.btnSalvarEntrada_Click);
            // 
            // dtgridItensSelecionados
            // 
            this.dtgridItensSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridItensSelecionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoItem,
            this.Nome,
            this.Deposito,
            this.Quantidade});
            this.dtgridItensSelecionados.Location = new System.Drawing.Point(12, 263);
            this.dtgridItensSelecionados.Name = "dtgridItensSelecionados";
            this.dtgridItensSelecionados.Size = new System.Drawing.Size(523, 115);
            this.dtgridItensSelecionados.TabIndex = 103;
            // 
            // CodigoItem
            // 
            this.CodigoItem.HeaderText = "Codigo Item";
            this.CodigoItem.Name = "CodigoItem";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Deposito
            // 
            this.Deposito.HeaderText = "Deposito";
            this.Deposito.Name = "Deposito";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // lblItensSelecionados
            // 
            this.lblItensSelecionados.AutoSize = true;
            this.lblItensSelecionados.Location = new System.Drawing.Point(9, 233);
            this.lblItensSelecionados.Name = "lblItensSelecionados";
            this.lblItensSelecionados.Size = new System.Drawing.Size(100, 13);
            this.lblItensSelecionados.TabIndex = 102;
            this.lblItensSelecionados.Text = "Itens Selecionados:";
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.Location = new System.Drawing.Point(451, 70);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(87, 31);
            this.btnBuscarItem.TabIndex = 101;
            this.btnBuscarItem.Text = "Buscar";
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // txtBuscarItem
            // 
            this.txtBuscarItem.Location = new System.Drawing.Point(180, 76);
            this.txtBuscarItem.Name = "txtBuscarItem";
            this.txtBuscarItem.Size = new System.Drawing.Size(244, 20);
            this.txtBuscarItem.TabIndex = 100;
            // 
            // lblBuscarItem
            // 
            this.lblBuscarItem.AutoSize = true;
            this.lblBuscarItem.Location = new System.Drawing.Point(9, 79);
            this.lblBuscarItem.Name = "lblBuscarItem";
            this.lblBuscarItem.Size = new System.Drawing.Size(162, 13);
            this.lblBuscarItem.TabIndex = 99;
            this.lblBuscarItem.Text = "Digite o nome ou código do item:";
            // 
            // lblSelecionarFornecedor
            // 
            this.lblSelecionarFornecedor.AutoSize = true;
            this.lblSelecionarFornecedor.Location = new System.Drawing.Point(9, 43);
            this.lblSelecionarFornecedor.Name = "lblSelecionarFornecedor";
            this.lblSelecionarFornecedor.Size = new System.Drawing.Size(120, 13);
            this.lblSelecionarFornecedor.TabIndex = 97;
            this.lblSelecionarFornecedor.Text = "Selecione o fornecedor:";
            // 
            // cmbSelecionarFornecedor
            // 
            this.cmbSelecionarFornecedor.FormattingEnabled = true;
            this.cmbSelecionarFornecedor.Location = new System.Drawing.Point(145, 40);
            this.cmbSelecionarFornecedor.Name = "cmbSelecionarFornecedor";
            this.cmbSelecionarFornecedor.Size = new System.Drawing.Size(219, 21);
            this.cmbSelecionarFornecedor.TabIndex = 98;
            this.cmbSelecionarFornecedor.SelectedIndexChanged += new System.EventHandler(this.cmbSelecionarFornecedor_SelectedIndexChanged);
            // 
            // MovimentacaoEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 445);
            this.Controls.Add(this.lstItens);
            this.Controls.Add(this.btnCancelarEntrada);
            this.Controls.Add(this.btnSalvarEntrada);
            this.Controls.Add(this.dtgridItensSelecionados);
            this.Controls.Add(this.lblItensSelecionados);
            this.Controls.Add(this.btnBuscarItem);
            this.Controls.Add(this.txtBuscarItem);
            this.Controls.Add(this.lblBuscarItem);
            this.Controls.Add(this.cmbSelecionarFornecedor);
            this.Controls.Add(this.lblSelecionarFornecedor);
            this.MaximizeBox = false;
            this.Name = "MovimentacaoEntrada";
            this.Text = "MovimentacaoEntrada";
            this.Load += new System.EventHandler(this.MovimentacaoEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridItensSelecionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.Button btnCancelarEntrada;
        private System.Windows.Forms.Button btnSalvarEntrada;
        private System.Windows.Forms.DataGridView dtgridItensSelecionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Label lblItensSelecionados;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtBuscarItem;
        private System.Windows.Forms.Label lblBuscarItem;
        private System.Windows.Forms.Label lblSelecionarFornecedor;
        private System.Windows.Forms.ComboBox cmbSelecionarFornecedor;
    }
}