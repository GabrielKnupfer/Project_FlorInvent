using Project.FlorInvent.Dao;
using Project.FlorInvent.Dao.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.FlorInvent.Interface;

namespace Project.FlorInvent.UI
{
    public partial class CadastroItem : Form
    {

        private int _depositoSelecionado;
        private int _tipoItemSelecionado;

        public CadastroItem()
        {
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
                    item.IdTipoItem = _tipoItemSelecionado;
                    item.DescricaoItem = txtDescricaoItem.Text;
                    item.IdDeposito = _depositoSelecionado;
                }

                ItemDao.IncluirItem(item);
                MessageBox.Show("Incluido com sucesso!");
                this.Close();
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroItem_Load(object sender, EventArgs e)
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
        }

        private void cbDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDepositoEntity depositoSelecionado = (DepositoEntity)cbDeposito.SelectedItem;
            _depositoSelecionado = depositoSelecionado.IdDeposito;
        }

        private void cbTipoItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ITipoItemEntity tipoItemSelecionado = (TipoItemEntity)cbTipoItem.SelectedItem;
            _tipoItemSelecionado = tipoItemSelecionado.IdTipoItem;
        }
    }
}
