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
    public partial class RelatorioSaida : Form
    {
        public RelatorioSaida()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnBuscarSaida_Click(object sender, EventArgs e)
        {
            IList<IMovimentoSaidaEntity> saidas = MovimentoSaidaDao.ConsultarPorData(mkdTxtBuscarSaida.Text);
            dtgridRelatorioSaida.Rows.Clear();

            if (saidas.Count <= 0)
            {
                MessageBox.Show("A busca não retornou resultado.");
                return;
            }

            int rowId = 0;
            foreach (IMovimentoSaidaEntity saida in saidas)
            {
                rowId = dtgridRelatorioSaida.Rows.AddCopy(0);
                dtgridRelatorioSaida.Rows[rowId].Cells["CodigoCliente"].Value = saida.cliente.NomeCliente;
                dtgridRelatorioSaida.Rows[rowId].Cells["CodigoUsuario"].Value = saida.usuario.NomeUsuario;
                dtgridRelatorioSaida.Rows[rowId].Cells["DataMovimento"].Value = saida.DataMovimento;
                dtgridRelatorioSaida.Rows[rowId].Cells["IdMovimentoSaida"].Value = saida.IdMovimentoSaida;
            }
        }

        private void btnSairRelatorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnItensMovimentacao_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgridRelatorioSaida.SelectedRows)
            {
                int codigoSaidaSelecionado = Convert.ToInt32(row.Cells["IdMovimentoSaida"].Value);
                RelatorioSaidaItem frm = new RelatorioSaidaItem(codigoSaidaSelecionado);
                frm.ShowDialog();
            }
        }
    }
}
