namespace Project.FlorInvent.UI
{
    partial class ConsultarItem
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
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.dtgridConsultaItem = new System.Windows.Forms.DataGridView();
            this.CodigoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarItem = new System.Windows.Forms.Button();
            this.txtConsultaItem = new System.Windows.Forms.TextBox();
            this.lblConsultaItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(276, 346);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(86, 31);
            this.btnExcluirItem.TabIndex = 31;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Visible = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.Location = new System.Drawing.Point(460, 345);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(86, 31);
            this.btnCancelarItem.TabIndex = 30;
            this.btnCancelarItem.Text = "Cancelar";
            this.btnCancelarItem.UseVisualStyleBackColor = true;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.Location = new System.Drawing.Point(368, 346);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Size = new System.Drawing.Size(86, 31);
            this.btnAlterarItem.TabIndex = 29;
            this.btnAlterarItem.Text = "Alterar";
            this.btnAlterarItem.UseVisualStyleBackColor = true;
            this.btnAlterarItem.Click += new System.EventHandler(this.btnAlterarItem_Click);
            // 
            // dtgridConsultaItem
            // 
            this.dtgridConsultaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridConsultaItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoItem,
            this.Nome,
            this.DescricaoItem,
            this.TipoItem,
            this.Deposito});
            this.dtgridConsultaItem.Location = new System.Drawing.Point(12, 94);
            this.dtgridConsultaItem.Name = "dtgridConsultaItem";
            this.dtgridConsultaItem.Size = new System.Drawing.Size(534, 245);
            this.dtgridConsultaItem.TabIndex = 28;
            // 
            // CodigoItem
            // 
            this.CodigoItem.HeaderText = "Cód Item";
            this.CodigoItem.Name = "CodigoItem";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // DescricaoItem
            // 
            this.DescricaoItem.HeaderText = "Descrição Item";
            this.DescricaoItem.Name = "DescricaoItem";
            // 
            // TipoItem
            // 
            this.TipoItem.HeaderText = "Tipo Item";
            this.TipoItem.Name = "TipoItem";
            // 
            // Deposito
            // 
            this.Deposito.HeaderText = "Deposito";
            this.Deposito.Name = "Deposito";
            // 
            // btnConsultarItem
            // 
            this.btnConsultarItem.Location = new System.Drawing.Point(424, 64);
            this.btnConsultarItem.Name = "btnConsultarItem";
            this.btnConsultarItem.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarItem.TabIndex = 27;
            this.btnConsultarItem.Text = "Buscar";
            this.btnConsultarItem.UseVisualStyleBackColor = true;
            this.btnConsultarItem.Click += new System.EventHandler(this.btnConsultarItem_Click);
            // 
            // txtConsultaItem
            // 
            this.txtConsultaItem.Location = new System.Drawing.Point(12, 68);
            this.txtConsultaItem.Name = "txtConsultaItem";
            this.txtConsultaItem.Size = new System.Drawing.Size(405, 20);
            this.txtConsultaItem.TabIndex = 26;
            // 
            // lblConsultaItem
            // 
            this.lblConsultaItem.AutoSize = true;
            this.lblConsultaItem.Location = new System.Drawing.Point(9, 51);
            this.lblConsultaItem.Name = "lblConsultaItem";
            this.lblConsultaItem.Size = new System.Drawing.Size(162, 13);
            this.lblConsultaItem.TabIndex = 25;
            this.lblConsultaItem.Text = "Digite o nome ou código do item:";
            // 
            // ConsultarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 389);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.btnCancelarItem);
            this.Controls.Add(this.btnAlterarItem);
            this.Controls.Add(this.dtgridConsultaItem);
            this.Controls.Add(this.btnConsultarItem);
            this.Controls.Add(this.txtConsultaItem);
            this.Controls.Add(this.lblConsultaItem);
            this.MaximizeBox = false;
            this.Name = "ConsultarItem";
            this.Text = "ConsultarItem";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.DataGridView dtgridConsultaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito;
        private System.Windows.Forms.Button btnConsultarItem;
        private System.Windows.Forms.TextBox txtConsultaItem;
        private System.Windows.Forms.Label lblConsultaItem;
    }
}