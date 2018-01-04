using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.FlorInvent.Interface;
using Project.FlorInvent.Dao;
using Project.FlorInvent.Dao.Entity;

namespace Project.FlorInvent.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool logado = false;
        public int IdUsuarioLogado = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //try
            //{
                Logar();
            //}
            //catch(Exception ex)
            //{
            //    logado = false;
            //    MessageBox.Show(ex + "Erro ao Logar");
            //}
        }

        private void Logar()
        {
            string login = "";
            string senha = "";

            login = txtNomeUsuario.Text;
            senha = txtSenhaUsuario.Text;

            IList<IUsuarioEntity> usuarios = UsuarioDao.VerificarUsuario(login, senha);

            if (usuarios.Count <= 0)
            {
                MessageBox.Show("Erro ao logar, pode ter ocorrido os seguintes erros: \nNão foi possível encontrar o usuario; \nO login ou a senha digitados estão incorretos");
                return;
            }

            foreach (IUsuarioEntity usuario in usuarios)
            {
                if (usuario.NomeUsuario != login && usuario.Senha != senha)
                {
                    MessageBox.Show("O login ou a senha digitados estão incorretos");
                    logado = false;
                }
                if (usuario.NomeUsuario == login && usuario.Senha == senha)
                {
                    logado = true;
                    IdUsuarioLogado = usuario.IdUsuario;

                    Properties.Settings.Default.IdUsuarioLogado = IdUsuarioLogado;

                    MessageBox.Show("Usuario logado com sucesso");
                    this.Dispose();
                    Home home = new Home();
                    home.StartPosition = FormStartPosition.CenterScreen;
                    home.ShowDialog();
                }
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                Logar();
            }
        }
    }
}
