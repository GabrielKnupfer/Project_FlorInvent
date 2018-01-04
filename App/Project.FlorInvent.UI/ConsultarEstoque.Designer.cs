namespace Project.FlorInvent.UI
{
    partial class ConsultarEstoque
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
            this.dtgridConsultaUsuario = new System.Windows.Forms.DataGridView();
            this.btnConsultaEstoque = new System.Windows.Forms.Button();
            this.txtConsultaEstoque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(404, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtgridConsultaUsuario
            // 
            this.dtgridConsultaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridConsultaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoItem,
            this.QuantidadeTotal});
            this.dtgridConsultaUsuario.Location = new System.Drawing.Point(5, 87);
            this.dtgridConsultaUsuario.Name = "dtgridConsultaUsuario";
            this.dtgridConsultaUsuario.Size = new System.Drawing.Size(494, 196);
            this.dtgridConsultaUsuario.TabIndex = 16;
            // 
            // btnConsultaEstoque
            // 
            this.btnConsultaEstoque.Location = new System.Drawing.Point(424, 42);
            this.btnConsultaEstoque.Name = "btnConsultaEstoque";
            this.btnConsultaEstoque.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaEstoque.TabIndex = 15;
            this.btnConsultaEstoque.Text = "Consultar";
            this.btnConsultaEstoque.UseVisualStyleBackColor = true;
            this.btnConsultaEstoque.Click += new System.EventHandler(this.btnConsultaEstoque_Click);
            // 
            // txtConsultaEstoque
            // 
            this.txtConsultaEstoque.Location = new System.Drawing.Point(126, 45);
            this.txtConsultaEstoque.Name = "txtConsultaEstoque";
            this.txtConsultaEstoque.Size = new System.Drawing.Size(292, 20);
            this.txtConsultaEstoque.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Digite o código do item:";
            // 
            // CodigoItem
            // 
            this.CodigoItem.HeaderText = "Codigo do Item";
            this.CodigoItem.Name = "CodigoItem";
            this.CodigoItem.Width = 150;
            // 
            // QuantidadeTotal
            // 
            this.QuantidadeTotal.HeaderText = "Quantidade Total";
            this.QuantidadeTotal.Name = "QuantidadeTotal";
            this.QuantidadeTotal.Width = 150;
            // 
            // ConsultarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 337);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgridConsultaUsuario);
            this.Controls.Add(this.btnConsultaEstoque);
            this.Controls.Add(this.txtConsultaEstoque);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "ConsultarEstoque";
            this.Text = "ConsultarEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConsultaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dtgridConsultaUsuario;
        private System.Windows.Forms.Button btnConsultaEstoque;
        private System.Windows.Forms.TextBox txtConsultaEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeTotal;
    }
}