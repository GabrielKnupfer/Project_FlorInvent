namespace Project.FlorInvent.UI
{
    partial class ConsultarTipoItem
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
            this.btnExcluirTipoItem = new System.Windows.Forms.Button();
            this.btnCancelarTipoItem = new System.Windows.Forms.Button();
            this.btnAlterarTipoItem = new System.Windows.Forms.Button();
            this.dtgridConsultaITipotem = new System.Windows.Forms.DataGridView();
            this.DescricaoTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarTipoItem = new System.Windows.Forms.Button();
            this.txtConsultaTipoItem = new System.Windows.Forms.TextBox();
            this.lblConsultaTipoItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaITipotem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirTipoItem
            // 
            this.btnExcluirTipoItem.Location = new System.Drawing.Point(276, 344);
            this.btnExcluirTipoItem.Name = "btnExcluirTipoItem";
            this.btnExcluirTipoItem.Size = new System.Drawing.Size(86, 31);
            this.btnExcluirTipoItem.TabIndex = 38;
            this.btnExcluirTipoItem.Text = "Excluir";
            this.btnExcluirTipoItem.UseVisualStyleBackColor = true;
            this.btnExcluirTipoItem.Visible = false;
            this.btnExcluirTipoItem.Click += new System.EventHandler(this.btnExcluirTipoItem_Click);
            // 
            // btnCancelarTipoItem
            // 
            this.btnCancelarTipoItem.Location = new System.Drawing.Point(460, 345);
            this.btnCancelarTipoItem.Name = "btnCancelarTipoItem";
            this.btnCancelarTipoItem.Size = new System.Drawing.Size(86, 31);
            this.btnCancelarTipoItem.TabIndex = 37;
            this.btnCancelarTipoItem.Text = "Cancelar";
            this.btnCancelarTipoItem.UseVisualStyleBackColor = true;
            this.btnCancelarTipoItem.Click += new System.EventHandler(this.btnCancelarTipoItem_Click);
            // 
            // btnAlterarTipoItem
            // 
            this.btnAlterarTipoItem.Location = new System.Drawing.Point(368, 344);
            this.btnAlterarTipoItem.Name = "btnAlterarTipoItem";
            this.btnAlterarTipoItem.Size = new System.Drawing.Size(86, 31);
            this.btnAlterarTipoItem.TabIndex = 36;
            this.btnAlterarTipoItem.Text = "Alterar";
            this.btnAlterarTipoItem.UseVisualStyleBackColor = true;
            this.btnAlterarTipoItem.Click += new System.EventHandler(this.btnAlterarTipoItem_Click);
            // 
            // dtgridConsultaITipotem
            // 
            this.dtgridConsultaITipotem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridConsultaITipotem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescricaoTipoItem,
            this.CodigoTipoItem});
            this.dtgridConsultaITipotem.Location = new System.Drawing.Point(12, 94);
            this.dtgridConsultaITipotem.Name = "dtgridConsultaITipotem";
            this.dtgridConsultaITipotem.Size = new System.Drawing.Size(534, 245);
            this.dtgridConsultaITipotem.TabIndex = 35;
            // 
            // DescricaoTipoItem
            // 
            this.DescricaoTipoItem.HeaderText = "Descrição";
            this.DescricaoTipoItem.Name = "DescricaoTipoItem";
            this.DescricaoTipoItem.Width = 490;
            // 
            // CodigoTipoItem
            // 
            this.CodigoTipoItem.HeaderText = "Codigo Tipo Item";
            this.CodigoTipoItem.Name = "CodigoTipoItem";
            this.CodigoTipoItem.Visible = false;
            // 
            // btnConsultarTipoItem
            // 
            this.btnConsultarTipoItem.Location = new System.Drawing.Point(424, 64);
            this.btnConsultarTipoItem.Name = "btnConsultarTipoItem";
            this.btnConsultarTipoItem.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarTipoItem.TabIndex = 34;
            this.btnConsultarTipoItem.Text = "Buscar";
            this.btnConsultarTipoItem.UseVisualStyleBackColor = true;
            this.btnConsultarTipoItem.Click += new System.EventHandler(this.btnConsultarTipoItem_Click);
            // 
            // txtConsultaTipoItem
            // 
            this.txtConsultaTipoItem.Location = new System.Drawing.Point(12, 68);
            this.txtConsultaTipoItem.Name = "txtConsultaTipoItem";
            this.txtConsultaTipoItem.Size = new System.Drawing.Size(405, 20);
            this.txtConsultaTipoItem.TabIndex = 33;
            // 
            // lblConsultaTipoItem
            // 
            this.lblConsultaTipoItem.AutoSize = true;
            this.lblConsultaTipoItem.Location = new System.Drawing.Point(9, 51);
            this.lblConsultaTipoItem.Name = "lblConsultaTipoItem";
            this.lblConsultaTipoItem.Size = new System.Drawing.Size(162, 13);
            this.lblConsultaTipoItem.TabIndex = 32;
            this.lblConsultaTipoItem.Text = "Digite o nome ou código do item:";
            // 
            // ConsultarTipoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 387);
            this.Controls.Add(this.btnExcluirTipoItem);
            this.Controls.Add(this.btnCancelarTipoItem);
            this.Controls.Add(this.btnAlterarTipoItem);
            this.Controls.Add(this.dtgridConsultaITipotem);
            this.Controls.Add(this.btnConsultarTipoItem);
            this.Controls.Add(this.txtConsultaTipoItem);
            this.Controls.Add(this.lblConsultaTipoItem);
            this.MaximizeBox = false;
            this.Name = "ConsultarTipoItem";
            this.Text = "ConsultarTipoItem";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaITipotem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirTipoItem;
        private System.Windows.Forms.Button btnCancelarTipoItem;
        private System.Windows.Forms.Button btnAlterarTipoItem;
        private System.Windows.Forms.DataGridView dtgridConsultaITipotem;
        private System.Windows.Forms.Button btnConsultarTipoItem;
        private System.Windows.Forms.TextBox txtConsultaTipoItem;
        private System.Windows.Forms.Label lblConsultaTipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoTipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTipoItem;
    }
}