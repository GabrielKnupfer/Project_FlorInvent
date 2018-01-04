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
    public partial class ConsultarDeposito : Form
    {
        public ConsultarDeposito()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnConsultarDeposito_Click(object sender, EventArgs e)
        {
            IList<IDepositoEntity> depositos = DepositoDao.ConsultarDeposito(txtConsultarDeposito.Text);
            dtgridConsultarDeposito.Rows.Clear();

            if (depositos.Count <= 0)
            {
                MessageBox.Show("A busca não retornou resultado.");
                return;
            }

            int rowId = 0;
            foreach (IDepositoEntity depo in depositos)
            {
                rowId = dtgridConsultarDeposito.Rows.AddCopy(0);
                dtgridConsultarDeposito.Rows[rowId].Cells["CodigoDeposito"].Value = depo.IdDeposito;
                dtgridConsultarDeposito.Rows[rowId].Cells["Descricao"].Value = depo.DescricaoDeposito;
                dtgridConsultarDeposito.Rows[rowId].Cells["Estado"].Value = depo.Estado;
                dtgridConsultarDeposito.Rows[rowId].Cells["CEP"].Value = depo.CEP;
                dtgridConsultarDeposito.Rows[rowId].Cells["Cidade"].Value = depo.Cidade;
                dtgridConsultarDeposito.Rows[rowId].Cells["Bairro"].Value = depo.Bairro;
                dtgridConsultarDeposito.Rows[rowId].Cells["Logradouro"].Value = depo.Logradouro;
                dtgridConsultarDeposito.Rows[rowId].Cells["Numero"].Value = depo.Numero;
                dtgridConsultarDeposito.Rows[rowId].Cells["Complemento"].Value = depo.Complemento;
            }
        }

        private void btnAlterarDeposito_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgridConsultarDeposito.SelectedRows)
            {
                int codigoDepositoSelecionado = Convert.ToInt32(row.Cells["CodigoDeposito"].Value);
                AlterarDeposito frm = new AlterarDeposito(codigoDepositoSelecionado);
                frm.ShowDialog();
            }
        }

        private void btnCancelarDeposito_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluirDeposito_Click(object sender, EventArgs e)
        {
            int codigoDeposito = 0;

            DialogResult result = MessageBox.Show("Deseja realmente excluir o Deposito?",
                                      "Confirma exclusão ", MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dtgridConsultarDeposito.SelectedRows)
                {
                    int codigoDepositoSelecionado = Convert.ToInt32(row.Cells["CodigoDeposito"].Value);
                    codigoDeposito = codigoDepositoSelecionado;
                }

                DepositoDao.ExcluirDeposito(codigoDeposito);
                MessageBox.Show("Deposito excluido com sucesso.");

                IList<IDepositoEntity> depositos = DepositoDao.ConsultarDeposito(txtConsultarDeposito.Text);
                dtgridConsultarDeposito.Rows.Clear();

                int rowId = 0;
                foreach (IDepositoEntity depo in depositos)
                {
                    rowId = dtgridConsultarDeposito.Rows.AddCopy(0);
                    dtgridConsultarDeposito.Rows[rowId].Cells["CodigoDeposito"].Value = depo.IdDeposito;
                    dtgridConsultarDeposito.Rows[rowId].Cells["Descricao"].Value = depo.DescricaoDeposito;
                    dtgridConsultarDeposito.Rows[rowId].Cells["Estado"].Value = depo.Estado;
                    dtgridConsultarDeposito.Rows[rowId].Cells["CEP"].Value = depo.CEP;
                    dtgridConsultarDeposito.Rows[rowId].Cells["Cidade"].Value = depo.Cidade;
                    dtgridConsultarDeposito.Rows[rowId].Cells["Bairro"].Value = depo.Bairro;
                    dtgridConsultarDeposito.Rows[rowId].Cells["Logradouro"].Value = depo.Logradouro;
                    dtgridConsultarDeposito.Rows[rowId].Cells["Numero"].Value = depo.Numero;
                    dtgridConsultarDeposito.Rows[rowId].Cells["Complemento"].Value = depo.Complemento;
                }
            }
        }
    }
}
