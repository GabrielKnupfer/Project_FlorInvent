using Project.FlorInvent.Dao;
using Project.FlorInvent.Dao.Entity;
using Project.FlorInvent.Interface;
using Project.FlorInvent.Interface.Enum;
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
    public partial class AlterarUsuario : Form
    {
        private int CodigoUsuario;
        public AlterarUsuario(int codigoUsuarioSelecionado)
        {
            this.CodigoUsuario = codigoUsuarioSelecionado;
            InitializeComponent();
        }

        private void AlterarUsuario_Load(object sender, EventArgs e)
        {
            IList<IUsuarioEntity> usuarios = UsuarioDao.ConsultarUsuarioPorCodigo(this.CodigoUsuario);

            foreach (IUsuarioEntity usuario in usuarios)
            {
                txtNomeUsuario.Text = usuario.NomeUsuario;
                txtSenhaUsuario.Text = usuario.Senha;
                if ((int)usuario.TipoUsuario == 1)
                    cmbTipoUsuario.SelectedItem = "Administrador";
                if ((int)usuario.TipoUsuario == 2)
                    cmbTipoUsuario.SelectedItem = "Comum";
            }
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            string erros = "";
            int tipoUsuario = 0;

            if (txtNomeUsuario.Text == "")
                erros += "- Preencha o campo nome do usuario;\n";
            if (txtSenhaUsuario.Text == "")
                erros += "- Preencha o campo senha do usuario;\n";
            if (txtConfirmSenha.Text == "")
                erros += "- Digite a senha novamente;\n";
            if (txtConfirmSenha.Text != txtSenhaUsuario.Text)
                erros += "- As senhas não correspondem;\n";
            if (cmbTipoUsuario.SelectedItem == null)
                erros += "- Selecione um tipo de usuario;\n";

            if (cmbTipoUsuario.SelectedItem.ToString() == "Administrador")
                tipoUsuario = 1;
            if (cmbTipoUsuario.SelectedItem.ToString() == "Comum")
                tipoUsuario = 2;

            if (!string.IsNullOrEmpty(erros))
            {
                MessageBox.Show(erros);
            }
            else
            {
                UsuarioEntity usuario = new UsuarioEntity();
                {
                    usuario.NomeUsuario = txtNomeUsuario.Text;
                    usuario.Senha = txtSenhaUsuario.Text;
                    usuario.TipoUsuario = (TipoUsuarioEnum)Convert.ToInt32(tipoUsuario);
                }

                UsuarioDao.AlterarUsuario(usuario, this.CodigoUsuario);
                MessageBox.Show("Funcionario alterado com sucesso");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
