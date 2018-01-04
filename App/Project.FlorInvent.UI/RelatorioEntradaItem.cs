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
    public partial class RelatorioEntradaItem : Form
    {
        private int CodigoMovimentoEntrada;
        public RelatorioEntradaItem(int codigoMovimentoEntradaSelecionado)
        {
            this.CodigoMovimentoEntrada = codigoMovimentoEntradaSelecionado;
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void RelatorioEntradaItem_Load(object sender, EventArgs e)
        {
            IList<IMovimentoEntradaItemEntity> entradaItens = MovimentoEntradaItemDao.ConsultarPorCodigoMovimentoEntrada(this.CodigoMovimentoEntrada);

            int rowId = 0;
            foreach (IMovimentoEntradaItemEntity entradaItem in entradaItens)
            {
                rowId = dtGridItens.Rows.AddCopy(0);
                dtGridItens.Rows[rowId].Cells["IdMovimentoEntrada"].Value = entradaItem.IdMovimentoEntrada;
                dtGridItens.Rows[rowId].Cells["Item"].Value = entradaItem.item.IdItem + " - " + entradaItem.item.Nome;
                dtGridItens.Rows[rowId].Cells["Deposito"].Value = entradaItem.item.deposito.DescricaoDeposito;
                dtGridItens.Rows[rowId].Cells["Quantidade"].Value = entradaItem.QtdTotal;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
