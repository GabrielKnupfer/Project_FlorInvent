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
    public partial class ConsultarEstoque : Form
    {
        public ConsultarEstoque()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnConsultaEstoque_Click(object sender, EventArgs e)
        {
            IList<IEstoqueEntity> estoque = EstoqueDao.ConsultarEstoque(txtConsultaEstoque.Text);
            dtgridConsultaUsuario.Rows.Clear();

            if (estoque.Count <= 0)
            {
                MessageBox.Show("A busca não retornou resultado.");
                return;
            }

            int rowId = 0;
            foreach (IEstoqueEntity est in estoque)
            {
                rowId = dtgridConsultaUsuario.Rows.AddCopy(0);
                dtgridConsultaUsuario.Rows[rowId].Cells["CodigoItem"].Value = est.IdItem;
                dtgridConsultaUsuario.Rows[rowId].Cells["QuantidadeTotal"].Value = est.QuantidadeTotal;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
