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

namespace Project.FlorInvent.UI
{
    public partial class MovimentacaoSaida : Form
    {
        public MovimentacaoSaida()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private int _ClienteSelecionado;

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            lstItens.DisplayMember = "TextoExibicao";
            lstItens.ValueMember = "ItemId";
            IList<IItemEntity> lst = ItemDao.ConsultarItem(txtBuscarItem.Text);
            if (lst.Count <= 0)
                MessageBox.Show("A busca não retornou resultados.");

            lstItens.DataSource = lst;
        }

        private void MovimentacaoSaida_Load(object sender, EventArgs e)
        {
            cmbSelecionarCliente.DisplayMember = "TextoExibicao";
            cmbSelecionarCliente.ValueMember = "IdCliente";

            IList<IClienteEntity> lstClientes = ClienteDao.RetornarClientes();
            foreach (IClienteEntity fornecedor in lstClientes)
            {
                cmbSelecionarCliente.Items.Add(fornecedor);
            }
        }

        private void btnSalvarSaida_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente criar um novo registro?",
                                                  "Confirma a criação ", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MovimentoSaidaEntity saida = new MovimentoSaidaEntity();
                IList<MovimentoSaidaItemEntity> itens = new List<MovimentoSaidaItemEntity>();

                saida.IdCliente = 1;
                saida.DataMovimento = DateTime.Now;

                saida.IdUsuario = Properties.Settings.Default.IdUsuarioLogado;

                foreach (DataGridViewRow row in dtgridItensSelecionados.Rows)
                {
                    if (row.Cells["CodigoItem"].Value != null && row.Cells["CodigoItem"].Value.ToString() != "")
                    {
                        if (row.Cells["Quantidade"].Value == null)
                        {
                            MessageBox.Show("Preencha a quantidade para o item " + row.Cells["CodigoItem"].Value + " - " + row.Cells["Nome"].Value, "Campo Inválido");
                            return;
                        }

                        IEstoqueEntity estoque = EstoqueDao.ConsultarPorCodigoItem(Convert.ToInt32(row.Cells["CodigoItem"].Value));

                        if (Convert.ToInt32(row.Cells["Quantidade"].Value) > estoque.QuantidadeDisponivel)
                        {
                            MessageBox.Show("A quantidade disponivel para o item " + row.Cells["CodigoItem"].Value + row.Cells["Nome"].Value + " é de " + estoque.QuantidadeDisponivel);
                            return;
                        }

                        IItemEntity item = ItemDao.ConsultarPorCodigo(Convert.ToInt32(row.Cells["CodigoItem"].Value));
                        MovimentoSaidaItemEntity saidaItem = new MovimentoSaidaItemEntity();

                        saidaItem.IdItem = item.IdItem;
                        saidaItem.IdDeposito = Convert.ToInt32(row.Cells["Deposito"].Value);
                        saidaItem.QtdTotal = Convert.ToInt32(row.Cells["Quantidade"].Value);

                        itens.Add(saidaItem);
                    }
                }

                saida.IdMovimentoSaida = MovimentoSaidaDao.Inserir(saida);

                foreach (var saidaItem in itens)
                {
                    saidaItem.IdMovimentoSaida = saida.IdMovimentoSaida;

                    MovimentoSaidaItemEntity movimento = new MovimentoSaidaItemEntity
                    {
                        IdMovimentoSaida = saidaItem.IdMovimentoSaida,
                        IdItem = saidaItem.IdItem,
                        IdDeposito = saidaItem.IdDeposito,
                        QtdTotal = saidaItem.QtdTotal
                    };
                    MovimentoSaidaItemDao.Inserir(movimento);

                    IEstoqueEntity estoqueItem = EstoqueDao.ConsultarPorCodigoItem(saidaItem.IdItem);

                    EstoqueEntity estoque = new EstoqueEntity
                    {
                        QuantidadeTotal = estoqueItem.QuantidadeTotal - saidaItem.QtdTotal
                    };

                    EstoqueDao.Atualizar(estoque, saidaItem.IdItem);
                }

                MessageBox.Show("Registro gravado com sucesso!");
                this.Close();
            }
        }

        private void AdicionarItem()
        {
            IItemEntity itemNovo = (ItemEntity)lstItens.SelectedItem;
            MovimentoSaidaItemEntity newItem = new MovimentoSaidaItemEntity
            {
                IdItem = itemNovo.IdItem
            };
            int rowId = dtgridItensSelecionados.Rows.AddCopy(0);
            dtgridItensSelecionados.Rows[rowId].Cells["CodigoItem"].Value = newItem.item.IdItem;
            dtgridItensSelecionados.Rows[rowId].Cells["Nome"].Value = newItem.item.Nome;
            dtgridItensSelecionados.Rows[rowId].Cells["Deposito"].Value = newItem.item.IdDeposito;
        }

        private void lstItens_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                AdicionarItem();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCancelarSaida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSelecionarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            IClienteEntity clienteSelecionado = (ClienteEntity)cmbSelecionarCliente.SelectedItem;
            _ClienteSelecionado = clienteSelecionado.IdCliente;
        }
    }
}
