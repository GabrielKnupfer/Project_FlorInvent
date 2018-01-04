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
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            IList<IClienteEntity> clientes = ClienteDao.ConsultarCliente(txtConsultaCliente.Text);
            dtgridConsultaCliente.Rows.Clear();

            if (clientes.Count <= 0)
            {
                MessageBox.Show("A busca não retornou resultado.");
                return;
            }

            int rowId = 0;
            foreach (IClienteEntity clie in clientes)
            {
                rowId = dtgridConsultaCliente.Rows.AddCopy(0);
                dtgridConsultaCliente.Rows[rowId].Cells["CodigoCliente"].Value = clie.IdCliente;
                dtgridConsultaCliente.Rows[rowId].Cells["Nome"].Value = clie.NomeCliente;
                dtgridConsultaCliente.Rows[rowId].Cells["CPF"].Value = clie.CPF;
                dtgridConsultaCliente.Rows[rowId].Cells["Telefone"].Value = clie.Telefone;
                dtgridConsultaCliente.Rows[rowId].Cells["Estado"].Value = clie.Estado;
                dtgridConsultaCliente.Rows[rowId].Cells["CEP"].Value = clie.CEP;
                dtgridConsultaCliente.Rows[rowId].Cells["Cidade"].Value = clie.Cidade;
                dtgridConsultaCliente.Rows[rowId].Cells["Bairro"].Value = clie.Bairro;
                dtgridConsultaCliente.Rows[rowId].Cells["Logradouro"].Value = clie.Logradouro;
                dtgridConsultaCliente.Rows[rowId].Cells["Numero"].Value = clie.Numero;
                dtgridConsultaCliente.Rows[rowId].Cells["Complemento"].Value = clie.Complemento;
            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgridConsultaCliente.SelectedRows)
            {
                int codigoClienteSelecionado = Convert.ToInt32(row.Cells["CodigoCliente"].Value);
                AlterarCliente frm = new AlterarCliente(codigoClienteSelecionado);
                frm.ShowDialog();
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
