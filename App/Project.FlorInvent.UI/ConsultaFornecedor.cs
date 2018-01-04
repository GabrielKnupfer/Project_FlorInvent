using Project.FlorInvent.Dao;
using Project.FlorInvent.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.FlorInvent.UI
{
    public partial class ConsultaFornecedor : Form
    {
        public ConsultaFornecedor()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnConsultarFornecedor_Click(object sender, EventArgs e)
        {
            IList<IFornecedorEntity> fornecedores = FornecedorDao.ConsultarFornecedor(txtConsultaFornecedor.Text);
            dtgridConsultaFornecedor.Rows.Clear();

            if (fornecedores.Count <= 0)
            {
                MessageBox.Show("A busca não retornou resultado.");
                return;
            }

            int rowId = 0;
            foreach (IFornecedorEntity forn in fornecedores)
            {
                rowId = dtgridConsultaFornecedor.Rows.AddCopy(0);
                dtgridConsultaFornecedor.Rows[rowId].Cells["CodigoFornecedor"].Value = forn.IdFornecedor;
                dtgridConsultaFornecedor.Rows[rowId].Cells["Nome"].Value = forn.NomeFornecedor;
                dtgridConsultaFornecedor.Rows[rowId].Cells["CNPJ"].Value = forn.CNPJ;
                dtgridConsultaFornecedor.Rows[rowId].Cells["Telefone"].Value = forn.Telefone;
                dtgridConsultaFornecedor.Rows[rowId].Cells["Estado"].Value = forn.Estado;
                dtgridConsultaFornecedor.Rows[rowId].Cells["CEP"].Value = forn.CEP;
                dtgridConsultaFornecedor.Rows[rowId].Cells["Cidade"].Value = forn.Cidade;
                dtgridConsultaFornecedor.Rows[rowId].Cells["Bairro"].Value = forn.Bairro;
                dtgridConsultaFornecedor.Rows[rowId].Cells["Logradouro"].Value = forn.Logradouro;
                dtgridConsultaFornecedor.Rows[rowId].Cells["Numero"].Value = forn.Numero;
                dtgridConsultaFornecedor.Rows[rowId].Cells["Complemento"].Value = forn.Complemento;
            }
        }

        private void btnAlterarFornecedor_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgridConsultaFornecedor.SelectedRows)
            {
                int codigofornecedorSelecionado = Convert.ToInt32(row.Cells["CodigoFornecedor"].Value);
                AlterarFornecedor frm = new AlterarFornecedor(codigofornecedorSelecionado);
                frm.ShowDialog();
            }
        }

        private void btnCancelarFornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
