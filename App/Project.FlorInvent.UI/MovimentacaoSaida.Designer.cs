namespace Project.FlorInvent.UI
{
    partial class MovimentacaoSaida
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
            this.btnCancelarSaida = new System.Windows.Forms.Button();
            this.btnSalvarSaida = new System.Windows.Forms.Button();
            this.dtgridItensSelecionados = new System.Windows.Forms.DataGridView();
            this.CodigoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItensSelecionados = new System.Windows.Forms.Label();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtBuscarItem = new System.Windows.Forms.TextBox();
            this.lblBuscarItem = new System.Windows.Forms.Label();
            this.cmbSelecionarCliente = new System.Windows.Forms.ComboBox();
            this.lblSelecionarCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridItensSelecionados)).BeginInit();
            this.SuspendLayout();
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.Location = new System.Drawing.Point(12, 141);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(523, 95);
            this.lstItens.TabIndex = 116;
            this.lstItens.DoubleClick += new System.EventHandler(this.lstItens_DoubleClick);
            // 
            // btnCancelarSaida
            // 
            this.btnCancelarSaida.Location = new System.Drawing.Point(422, 422);
            this.btnCancelarSaida.Name = "btnCancelarSaida";
            this.btnCancelarSaida.Size = new System.Drawing.Size(113, 39);
            this.btnCancelarSaida.TabIndex = 115;
            this.btnCancelarSaida.Text = "Cancelar";
            this.btnCancelarSaida.UseVisualStyleBackColor = true;
            this.btnCancelarSaida.Click += new System.EventHandler(this.btnCancelarSaida_Click);
            // 
            // btnSalvarSaida
            // 
            this.btnSalvarSaida.Location = new System.Drawing.Point(286, 422);
            this.btnSalvarSaida.Name = "btnSalvarSaida";
            this.btnSalvarSaida.Size = new System.Drawing.Size(113, 39);
            this.btnSalvarSaida.TabIndex = 114;
            this.btnSalvarSaida.Text = "Salvar";
            this.btnSalvarSaida.UseVisualStyleBackColor = true;
            this.btnSalvarSaida.Click += new System.EventHandler(this.btnSalvarSaida_Click);
            // 
            // dtgridItensSelecionados
            // 
            this.dtgridItensSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridItensSelecionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoItem,
            this.Nome,
            this.Deposito,
            this.Quantidade});
            this.dtgridItensSelecionados.Location = new System.Drawing.Point(12, 283);
            this.dtgridItensSelecionados.Name = "dtgridItensSelecionados";
            this.dtgridItensSelecionados.Size = new System.Drawing.Size(523, 115);
            this.dtgridItensSelecionados.TabIndex = 113;
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
            this.lblItensSelecionados.Location = new System.Drawing.Point(9, 253);
            this.lblItensSelecionados.Name = "lblItensSelecionados";
            this.lblItensSelecionados.Size = new System.Drawing.Size(100, 13);
            this.lblItensSelecionados.TabIndex = 112;
            this.lblItensSelecionados.Text = "Itens Selecionados:";
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.Location = new System.Drawing.Point(451, 90);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(87, 31);
            this.btnBuscarItem.TabIndex = 111;
            this.btnBuscarItem.Text = "Buscar";
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // txtBuscarItem
            // 
            this.txtBuscarItem.Location = new System.Drawing.Point(180, 96);
            this.txtBuscarItem.Name = "txtBuscarItem";
            this.txtBuscarItem.Size = new System.Drawing.Size(244, 20);
            this.txtBuscarItem.TabIndex = 110;
            // 
            // lblBuscarItem
            // 
            this.lblBuscarItem.AutoSize = true;
            this.lblBuscarItem.Location = new System.Drawing.Point(9, 99);
            this.lblBuscarItem.Name = "lblBuscarItem";
            this.lblBuscarItem.Size = new System.Drawing.Size(162, 13);
            this.lblBuscarItem.TabIndex = 109;
            this.lblBuscarItem.Text = "Digite o nome ou código do item:";
            // 
            // cmbSelecionarCliente
            // 
            this.cmbSelecionarCliente.FormattingEnabled = true;
            this.cmbSelecionarCliente.Location = new System.Drawing.Point(145, 60);
            this.cmbSelecionarCliente.Name = "cmbSelecionarCliente";
            this.cmbSelecionarCliente.Size = new System.Drawing.Size(219, 21);
            this.cmbSelecionarCliente.TabIndex = 108;
            this.cmbSelecionarCliente.SelectedIndexChanged += new System.EventHandler(this.cmbSelecionarCliente_SelectedIndexChanged);
            // 
            // lblSelecionarCliente
            // 
            this.lblSelecionarCliente.AutoSize = true;
            this.lblSelecionarCliente.Location = new System.Drawing.Point(9, 63);
            this.lblSelecionarCliente.Name = "lblSelecionarCliente";
            this.lblSelecionarCliente.Size = new System.Drawing.Size(101, 13);
            this.lblSelecionarCliente.TabIndex = 107;
            this.lblSelecionarCliente.Text = "Selecione o Cliente:";
            // 
            // MovimentacaoSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 465);
            this.Controls.Add(this.lstItens);
            this.Controls.Add(this.btnCancelarSaida);
            this.Controls.Add(this.btnSalvarSaida);
            this.Controls.Add(this.dtgridItensSelecionados);
            this.Controls.Add(this.lblItensSelecionados);
            this.Controls.Add(this.btnBuscarItem);
            this.Controls.Add(this.txtBuscarItem);
            this.Controls.Add(this.lblBuscarItem);
            this.Controls.Add(this.cmbSelecionarCliente);
            this.Controls.Add(this.lblSelecionarCliente);
            this.MaximizeBox = false;
            this.Name = "MovimentacaoSaida";
            this.Text = "MovimentacaoSaida";
            this.Load += new System.EventHandler(this.MovimentacaoSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridItensSelecionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.Button btnCancelarSaida;
        private System.Windows.Forms.Button btnSalvarSaida;
        private System.Windows.Forms.DataGridView dtgridItensSelecionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Label lblItensSelecionados;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtBuscarItem;
        private System.Windows.Forms.Label lblBuscarItem;
        private System.Windows.Forms.ComboBox cmbSelecionarCliente;
        private System.Windows.Forms.Label lblSelecionarCliente;
    }
}