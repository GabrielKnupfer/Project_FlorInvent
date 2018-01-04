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
    public partial class ConsultarUsuario : Form
    {
        public ConsultarUsuario()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnConsultaUsuario_Click(object sender, EventArgs e)
        {
            IList<IUsuarioEntity> usuarios = UsuarioDao.ConsultarUsuarios(txtConsultaUsuario.Text);
            dtgridConsultaUsuario.Rows.Clear();

            if (usuarios.Count <= 0)
            {
                MessageBox.Show("A busca não retornou resultado.");
                return;
            }

            int rowId = 0;
            foreach (IUsuarioEntity usuario in usuarios)
            {
                rowId = dtgridConsultaUsuario.Rows.AddCopy(0);
                dtgridConsultaUsuario.Rows[rowId].Cells["CodigoUsuario"].Value = usuario.IdUsuario;
                dtgridConsultaUsuario.Rows[rowId].Cells["Nome"].Value = usuario.NomeUsuario;
                dtgridConsultaUsuario.Rows[rowId].Cells["Tipo"].Value = usuario.TipoUsuario;
            }
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgridConsultaUsuario.SelectedRows)
            {
                int codigoUsuarioSelecionado = Convert.ToInt32(row.Cells["CodigoUsuario"].Value);
                AlterarUsuario frm = new AlterarUsuario(codigoUsuarioSelecionado);
                frm.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
