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
    public partial class ConsultarItem : Form
    {
        public ConsultarItem()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnConsultarItem_Click(object sender, EventArgs e)
        {
            IList<IItemEntity> itens = ItemDao.ConsultarItem(txtConsultaItem.Text);
            dtgridConsultaItem.Rows.Clear();

            if (itens.Count <= 0)
            {
                MessageBox.Show("A busca não retornou resultado.");
                return;
            }

            int rowId = 0;
            foreach (IItemEntity item in itens)
            {
                rowId = dtgridConsultaItem.Rows.AddCopy(0);
                dtgridConsultaItem.Rows[rowId].Cells["CodigoItem"].Value = item.IdItem;
                dtgridConsultaItem.Rows[rowId].Cells["Nome"].Value = item.Nome;
                dtgridConsultaItem.Rows[rowId].Cells["DescricaoItem"].Value = item.DescricaoItem;
                dtgridConsultaItem.Rows[rowId].Cells["TipoItem"].Value = item.TipoItem.Descricao;
                dtgridConsultaItem.Rows[rowId].Cells["Deposito"].Value = item.deposito.DescricaoDeposito;
            }
        }

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgridConsultaItem.SelectedRows)
            {
                int codigoItemSelecionado = Convert.ToInt32(row.Cells["CodigoItem"].Value);
                AlterarItem frm = new AlterarItem(codigoItemSelecionado);
                frm.ShowDialog();
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            int codigoItem = 0;

            DialogResult result = MessageBox.Show("Deseja realmente excluir o Item?",
                                      "Confirma exclusão ", MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dtgridConsultaItem.SelectedRows)
                {
                    int codigoItemSelecionado = Convert.ToInt32(row.Cells["CodigoItem"].Value);
                    codigoItem = codigoItemSelecionado;
                }

                ItemDao.ExcluirItem(codigoItem);
                MessageBox.Show("Item excluido com sucesso.");

                IList<IItemEntity> itens = ItemDao.ConsultarItem(txtConsultaItem.Text);
                dtgridConsultaItem.Rows.Clear();

                int rowId = 0;
                foreach (IItemEntity Item in itens)
                {
                    rowId = dtgridConsultaItem.Rows.AddCopy(0);
                    dtgridConsultaItem.Rows[rowId].Cells["CodigoItem"].Value = Item.IdItem;
                    dtgridConsultaItem.Rows[rowId].Cells["Nome"].Value = Item.Nome;
                    dtgridConsultaItem.Rows[rowId].Cells["DescricaoItem"].Value = Item.DescricaoItem;
                    dtgridConsultaItem.Rows[rowId].Cells["TipoItem"].Value = Item.TipoItem.Descricao;
                    dtgridConsultaItem.Rows[rowId].Cells["Deposito"].Value = Item.deposito.DescricaoDeposito;
                }
            }
        }
    }
}
