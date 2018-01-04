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
    public partial class MovimentacaoEntrada : Form
    {
        public MovimentacaoEntrada()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private int _fornecedorSelecionado;

        private void btnSalvarEntrada_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente criar um novo registro?",
                                                  "Confirma a criação ", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MovimentoEntradaEntity entrada = new MovimentoEntradaEntity();
                IList<MovimentoEntradaItemEntity> itens = new List<MovimentoEntradaItemEntity>();

                entrada.IdFornecedor = _fornecedorSelecionado;
                entrada.DataMovimento = DateTime.Now;

                entrada.IdUsuario = Properties.Settings.Default.IdUsuarioLogado;

                foreach (DataGridViewRow row in dtgridItensSelecionados.Rows)
                {
                    if (row.Cells["CodigoItem"].Value != null && row.Cells["CodigoItem"].Value.ToString() != "")
                    {
                        if (row.Cells["Quantidade"].Value == null)
                        {
                            MessageBox.Show("Preencha a quantidade para o item " + row.Cells["ItemId"].Value + " - " + row.Cells["ItemName"].Value, "Campo Inválido");
                            return;
                        }

                        IItemEntity item = ItemDao.ConsultarPorCodigo(Convert.ToInt32(row.Cells["CodigoItem"].Value));
                        MovimentoEntradaItemEntity entradaItem = new MovimentoEntradaItemEntity();

                        entradaItem.IdItem = item.IdItem;
                        entradaItem.IdDeposito = Convert.ToInt32(row.Cells["Deposito"].Value);
                        entradaItem.QtdTotal = Convert.ToInt32(row.Cells["Quantidade"].Value);

                        itens.Add(entradaItem);
                    }
                }

                entrada.IdMovimentacaoEntrada = MovimentoEntradaDao.Inserir(entrada);

                foreach (var entradaItem in itens)
                {
                    entradaItem.IdMovimentoEntrada = entrada.IdMovimentacaoEntrada;

                    MovimentoEntradaItemEntity movimento = new MovimentoEntradaItemEntity
                    {
                        IdMovimentoEntrada = entradaItem.IdMovimentoEntrada,
                        IdItem = entradaItem.IdItem,
                        IdDeposito = entradaItem.IdDeposito,
                        QtdTotal = entradaItem.QtdTotal
                    };
                    MovimentoEntradaItemDao.Inserir(movimento);



                    EstoqueEntity estoque = new EstoqueEntity
                    {
                        IdItem = entradaItem.IdItem,
                        QuantidadeTotal = entradaItem.QtdTotal,
                        QuantidadeUtilizada = 0
                    };

                    IEstoqueEntity estoqueItem = EstoqueDao.ConsultarPorCodigoItem(entradaItem.IdItem);

                    if (estoqueItem != null)
                    {
                        EstoqueEntity atualizarEstoque = new EstoqueEntity
                        {
                          IdItem = entradaItem.IdItem,
                          QuantidadeTotal = entradaItem.QtdTotal + estoqueItem.QuantidadeTotal,
                          QuantidadeUtilizada = 0
                        };
                        EstoqueDao.Atualizar(atualizarEstoque, entradaItem.IdItem);
                    }
                    else
                    {
                        EstoqueDao.Incluir(estoque);
                    }
                }

                MessageBox.Show("Registro gravado com sucesso!");
                this.Close();
            }
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            lstItens.DisplayMember = "TextoExibicao";
            lstItens.ValueMember = "ItemId";
            IList<IItemEntity> lst = ItemDao.ConsultarItem(txtBuscarItem.Text);
            if (lst.Count <= 0)
                MessageBox.Show("A busca não retornou resultados.");

            lstItens.DataSource = lst;
        }

        private void AdicionarItem()
        {
            IItemEntity itemNovo = (ItemEntity)lstItens.SelectedItem;
            MovimentoEntradaItemEntity newItem = new MovimentoEntradaItemEntity
            {
                IdItem = itemNovo.IdItem
            };
            int rowId = dtgridItensSelecionados.Rows.AddCopy(0);
            dtgridItensSelecionados.Rows[rowId].Cells["CodigoItem"].Value = newItem.item.IdItem;
            dtgridItensSelecionados.Rows[rowId].Cells["Nome"].Value = newItem.item.Nome;
            dtgridItensSelecionados.Rows[rowId].Cells["Deposito"].Value = newItem.item.IdDeposito;
        }

        private void MovimentacaoEntrada_Load(object sender, EventArgs e)
        {
            //IList<IFornecedorEntity> fornecedores = FornecedorDao.RetornarFornecedores();

            //foreach (IFornecedorEntity fornecedor in fornecedores)
            //{
            //    lst = fornecedor.CNPJ + " - " + fornecedor.NomeFornecedor;
            //    cmbSelecionarFornecedor.Items.Add(lst);
            //    cmbSelecionarFornecedor.ValueMember = "IdFornecedor";
            //}

            cmbSelecionarFornecedor.DisplayMember = "TextoExibicao";
            cmbSelecionarFornecedor.ValueMember = "IdFornecedor";

            IList<IFornecedorEntity> lstFornecedores = FornecedorDao.RetornarFornecedores();
            foreach (IFornecedorEntity fornecedor in lstFornecedores)
            {
                cmbSelecionarFornecedor.Items.Add(fornecedor);
            }
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

        private void cmbSelecionarFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFornecedorEntity fornecedorSelecionado = (FornecedorEntity)cmbSelecionarFornecedor.SelectedItem;
            _fornecedorSelecionado = fornecedorSelecionado.IdFornecedor;
        }

        private void btnCancelarEntrada_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
