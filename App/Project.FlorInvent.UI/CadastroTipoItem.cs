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
    public partial class CadastroTipoItem : Form
    {
        public CadastroTipoItem()
        {
            InitializeComponent();
        }

        private void btnCadastroTipoItem_Click(object sender, EventArgs e)
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

            TipoItemDao.IncluirTipoItem(tipoItem);
            MessageBox.Show("Incluido com sucesso!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
