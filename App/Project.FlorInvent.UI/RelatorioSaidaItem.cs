using Project.FlorInvent.Dao;
using Project.FlorInvent.Dao.Entity;
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
using Project.FlorInvent.Interface.Enum;

namespace Project.FlorInvent.UI
{
    public partial class RelatorioSaidaItem : Form
    {
        private int CodigoMovimentoSaida;
        public RelatorioSaidaItem(int codigoMovimentoSaidaSelecionado)
        {
            this.CodigoMovimentoSaida = codigoMovimentoSaidaSelecionado;
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void RelatorioSaidaItem_Load(object sender, EventArgs e)
        {
            IList<IMovimentoSaidaItemEntity> saidaItens = MovimentoSaidaItemDao.ConsultarPorCodigoMovimentoSaida(this.CodigoMovimentoSaida);

            int rowId = 0;
            foreach (IMovimentoSaidaItemEntity saidaItem in saidaItens)
            {
                rowId = dtGridItens.Rows.AddCopy(0);
                dtGridItens.Rows[rowId].Cells["IdMovimentoEntrada"].Value = saidaItem.IdMovimentoSaida;
                dtGridItens.Rows[rowId].Cells["Item"].Value = saidaItem.item.IdItem + " - " + saidaItem.item.Nome;
                dtGridItens.Rows[rowId].Cells["Deposito"].Value = saidaItem.item.deposito.DescricaoDeposito;
                dtGridItens.Rows[rowId].Cells["Quantidade"].Value = saidaItem.QtdTotal;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
