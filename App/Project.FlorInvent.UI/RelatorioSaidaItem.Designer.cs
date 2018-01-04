namespace Project.FlorInvent.UI
{
    partial class RelatorioSaidaItem
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
            this.dtGridItens = new System.Windows.Forms.DataGridView();
            this.IdMovimentoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridItens
            // 
            this.dtGridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMovimentoEntrada,
            this.Item,
            this.Deposito,
            this.Quantidade});
            this.dtGridItens.Location = new System.Drawing.Point(12, 45);
            this.dtGridItens.Name = "dtGridItens";
            this.dtGridItens.Size = new System.Drawing.Size(476, 391);
            this.dtGridItens.TabIndex = 1;
            // 
            // IdMovimentoEntrada
            // 
            this.IdMovimentoEntrada.HeaderText = "Codigo Movimento Entrada";
            this.IdMovimentoEntrada.Name = "IdMovimentoEntrada";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
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
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(413, 442);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // RelatorioSaidaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 472);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dtGridItens);
            this.Name = "RelatorioSaidaItem";
            this.Text = "RelatorioSaidaItem";
            this.Load += new System.EventHandler(this.RelatorioSaidaItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMovimentoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button btnFechar;
    }
}