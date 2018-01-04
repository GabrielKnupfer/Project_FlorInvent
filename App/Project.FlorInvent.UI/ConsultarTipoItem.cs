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
    public partial class ConsultarTipoItem : Form
    {
        public ConsultarTipoItem()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnConsultarTipoItem_Click(object sender, EventArgs e)
        {
            IList<ITipoItemEntity> tiposItem = TipoItemDao.ConsultarTiposItem(txtConsultaTipoItem.Text);
            dtgridConsultaITipotem.Rows.Clear();

            if (tiposItem.Count <= 0)
            {
                MessageBox.Show("A busca não retornou resultado.");
                return;
            }

            int rowId = 0;
            foreach (ITipoItemEntity tipoItem in tiposItem)
            {
                rowId = dtgridConsultaITipotem.Rows.AddCopy(0);
                dtgridConsultaITipotem.Rows[rowId].Cells["CodigoTipoItem"].Value = tipoItem.IdTipoItem;
                dtgridConsultaITipotem.Rows[rowId].Cells["DescricaoTipoItem"].Value = tipoItem.Descricao;
            }
        }

        private void btnAlterarTipoItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgridConsultaITipotem.SelectedRows)
            {
                int codigoTipoItemSelecionado = Convert.ToInt32(row.Cells["CodigoTipoItem"].Value);
                AlterarTipoItem frm = new AlterarTipoItem(codigoTipoItemSelecionado);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }

        private void btnExcluirTipoItem_Click(object sender, EventArgs e)
        {
            int codigoTipoItem = 0;

            DialogResult result = MessageBox.Show("Deseja realmente excluir o Tipo de Item?",
                                      "Confirma exclusão ", MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dtgridConsultaITipotem.SelectedRows)
                {
                    int codigoTipoItemSelecionado = Convert.ToInt32(row.Cells["CodigoTipoItem"].Value);
                    codigoTipoItem = codigoTipoItemSelecionado;
                }

                TipoItemDao.ExcluirTipoItem(codigoTipoItem);
                MessageBox.Show("Tipo Item excluido com sucesso.");

                IList<ITipoItemEntity> tiposItem = TipoItemDao.ConsultarTiposItem(txtConsultaTipoItem.Text);

                int rowId = 0;
                foreach (ITipoItemEntity tipoItem in tiposItem)
                {
                    rowId = dtgridConsultaITipotem.Rows.AddCopy(0);
                    dtgridConsultaITipotem.Rows[rowId].Cells["CodigoTipoItem"].Value = tipoItem.IdTipoItem;
                    dtgridConsultaITipotem.Rows[rowId].Cells["DescricaoTipoItem"].Value = tipoItem.Descricao;
                }
            }
        }

        private void btnCancelarTipoItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
