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
    public partial class AlterarItem : Form
    {
        private int CodigoItem;
        private int _depositoSelecionado;
        private int _tipoItemSelecionado;

        public AlterarItem(int codigoItemSelecionado)
        {
            this.CodigoItem = codigoItemSelecionado;
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnSalvarItem_Click(object sender, EventArgs e)
        {
            string erros = "";
            //Validações
            if (txtNomeItem.Text == "")
                erros += "- Preencha o campo Nome;\n";
            if (cbTipoItem.Text == "")
                erros += "- Preencha o campo Tipo;\n";
            if (txtDescricaoItem.Text == "")
                erros += "- Preencha o campo Descrição;\n";
            if (cbDeposito.Text == "")
                erros += "- Preencha o campo Deposito;\n";

            if (!string.IsNullOrEmpty(erros))
            {
                MessageBox.Show(erros);
            }

            else
            {
                ItemEntity item = new ItemEntity();
                {
                    item.Nome = txtNomeItem.Text;
                    item.DescricaoItem = txtDescricaoItem.Text;
                    item.IdTipoItem = _tipoItemSelecionado;
                    item.IdDeposito = _depositoSelecionado;
                }

                ItemDao.AlterarItem(item, this.CodigoItem);
                MessageBox.Show("Item alterado com sucesso");
                this.Close();
            }
        }

        private void AlterarItem_Load(object sender, EventArgs e)
        {
            //Lista depositos
            cbDeposito.DisplayMember = "TextoExibicao";
            cbDeposito.ValueMember = "IdDeposito";

            IList<IDepositoEntity> lstDepositos = DepositoDao.RetornarDepositos();
            foreach (IDepositoEntity deposito in lstDepositos)
            {
                cbDeposito.Items.Add(deposito);
            }

            //Lista tipo itens
            cbTipoItem.DisplayMember = "TextoExibicao";
            cbTipoItem.ValueMember = "IdTipoItem";

            IList<ITipoItemEntity> lstTipoItens = TipoItemDao.RetornarTipoItem();
            foreach (ITipoItemEntity tipoitem in lstTipoItens)
            {
                cbTipoItem.Items.Add(tipoitem);
            }

            //Preenche todos os campos
            IList<IItemEntity> itens = ItemDao.ConsultarById(this.CodigoItem);

            foreach (IItemEntity item in itens)
            {
                txtNomeItem.Text = item.Nome.ToString();
                txtDescricaoItem.Text = item.DescricaoItem.ToString();
                cbTipoItem.Text = item.TipoItem.TextoExibicao.ToString();
                cbDeposito.Text = item.deposito.TextoExibicao.ToString();
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipoItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ITipoItemEntity tipoItemSelecionado = (TipoItemEntity)cbTipoItem.SelectedItem;
            _tipoItemSelecionado = tipoItemSelecionado.IdTipoItem;
        }

        private void cbDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDepositoEntity depositoSelecionado = (DepositoEntity)cbDeposito.SelectedItem;
            _depositoSelecionado = depositoSelecionado.IdDeposito;
        }
    }
}
