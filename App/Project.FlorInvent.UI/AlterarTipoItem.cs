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
    public partial class AlterarTipoItem : Form
    {
        private int CodigoTipoItem;

        public AlterarTipoItem(int codigoTipoItemSelecionado)
        {
            this.CodigoTipoItem = codigoTipoItemSelecionado;

            InitializeComponent();
        }

        private void btnSalvarTipoItem_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Preencha o campo descrição.");
                return;
            }

            TipoItemEntity tipoItem = new TipoItemEntity();
            {
                tipoItem.Descricao = txtDescricao.Text;
            }

            TipoItemDao.AlterarTipoItem(tipoItem, this.CodigoTipoItem);
            MessageBox.Show("Alterado com sucesso!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlterarTipoItem_Load(object sender, EventArgs e)
        {
            IList<ITipoItemEntity> tiposItem = TipoItemDao.ConsultarById(this.CodigoTipoItem);

            foreach (ITipoItemEntity tipoItem in tiposItem)
            {
                txtDescricao.Text = tipoItem.Descricao.ToString();
            }
        }
    }
}
