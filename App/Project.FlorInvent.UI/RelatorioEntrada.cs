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
    public partial class RelatorioEntrada : Form
    {
        public RelatorioEntrada()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnBuscarEntrada_Click(object sender, EventArgs e)
        {
            IList<IMovimentoEntradaEntity> entradas = MovimentoEntradaDao.ConsultarPorData(mkdtxtBuscarEntrada.Text);
            dtgridRelatorioEntrada.Rows.Clear();

            if (entradas.Count <= 0)
            {
                MessageBox.Show("A busca não retornou resultado.");
                return;
            }

            int rowId = 0;
            foreach (IMovimentoEntradaEntity entrada in entradas)
            {
                rowId = dtgridRelatorioEntrada.Rows.AddCopy(0);
                dtgridRelatorioEntrada.Rows[rowId].Cells["CodigoFornecedor"].Value = entrada.fornecedor.NomeFornecedor;
                dtgridRelatorioEntrada.Rows[rowId].Cells["CodigoUsuario"].Value = entrada.usuario.NomeUsuario;
                dtgridRelatorioEntrada.Rows[rowId].Cells["DataMovimento"].Value = entrada.DataMovimento;
                dtgridRelatorioEntrada.Rows[rowId].Cells["IdMovimentoEntrada"].Value = entrada.IdMovimentacaoEntrada;
            }
        }

        private void btnSairRelatorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnItensMovimentacao_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgridRelatorioEntrada.SelectedRows)
            {
                int codigoEntradaSelecionado = Convert.ToInt32(row.Cells["IdMovimentoEntrada"].Value);
                RelatorioEntradaItem frm = new RelatorioEntradaItem(codigoEntradaSelecionado);
                frm.ShowDialog();
            }
        }
    }
}
