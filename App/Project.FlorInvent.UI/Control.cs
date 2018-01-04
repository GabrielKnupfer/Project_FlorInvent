using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.FlorInvent.Interface;
using Project.FlorInvent.Dao.Entity;
using Project.FlorInvent.Dao;

namespace Project.FlorInvent.UI
{
    public partial class Control : UserControl
    {
        public Control()
        {
            InitializeComponent();
        }

        private void cadastrarItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarItem consItem = new ConsultarItem();
            consItem.StartPosition = FormStartPosition.CenterScreen;
            consItem.ShowDialog();
        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadFunc = new CadastroFuncionario();
            cadFunc.StartPosition = FormStartPosition.CenterScreen;
            cadFunc.ShowDialog();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor cadFornecedor = new CadastroFornecedor();
            cadFornecedor.StartPosition = FormStartPosition.CenterScreen;
            cadFornecedor.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCliente = new CadastroCliente();
            cadCliente.StartPosition = FormStartPosition.CenterScreen;
            cadCliente.ShowDialog();
        }

        private void cadastrarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroItem cadItem = new CadastroItem();
            cadItem.StartPosition = FormStartPosition.CenterScreen;
            cadItem.ShowDialog();
        }

        private void cadastrarDepositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeposito cadDeposito = new CadastroDeposito();
            cadDeposito.StartPosition = FormStartPosition.CenterScreen;
            cadDeposito.ShowDialog();
        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadUsuario = new CadastroUsuario();
            cadUsuario.StartPosition = FormStartPosition.CenterScreen;
            cadUsuario.ShowDialog();
        }

        private void consultaFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarFuncionario consFuncionario = new ConsultarFuncionario();
            consFuncionario.StartPosition = FormStartPosition.CenterScreen;
            consFuncionario.ShowDialog();
        }

        private void consultaFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFornecedor consFornecedor = new ConsultaFornecedor();
            consFornecedor.StartPosition = FormStartPosition.CenterScreen;
            consFornecedor.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarCliente consCliente = new ConsultarCliente();
            consCliente.StartPosition = FormStartPosition.CenterScreen;
            consCliente.ShowDialog();
        }

        private void cadastrarDepositoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarDeposito consDeposito = new ConsultarDeposito();
            consDeposito.StartPosition = FormStartPosition.CenterScreen;
            consDeposito.ShowDialog();
        }

        private void consultaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuario consUsuario = new ConsultarUsuario();
            consUsuario.StartPosition = FormStartPosition.CenterScreen;
            consUsuario.ShowDialog();
        }

        private void movimentaçãoEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovimentacaoEntrada entrada = new MovimentacaoEntrada();
            entrada.StartPosition = FormStartPosition.CenterScreen;
            entrada.ShowDialog();
        }

        private void movimentaçãoSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovimentacaoSaida saida = new MovimentacaoSaida();
            saida.StartPosition = FormStartPosition.CenterScreen;
            saida.ShowDialog();
        }

        private void relatórioEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioEntrada relatorioEntrada = new RelatorioEntrada();
            relatorioEntrada.StartPosition = FormStartPosition.CenterScreen;
            relatorioEntrada.ShowDialog();
        }

        private void relatórioSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioSaida relatorioSaida = new RelatorioSaida();
            relatorioSaida.StartPosition = FormStartPosition.CenterScreen;
            relatorioSaida.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fazer logout?",
                          "Logout", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair da aplicação?",
                          "Sair", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cadastrarTipoDeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroTipoItem tipoItem = new CadastroTipoItem();
            tipoItem.StartPosition = FormStartPosition.CenterScreen;
            tipoItem.ShowDialog();
        }

        private void consultaTipoDeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTipoItem consTipoItem = new ConsultarTipoItem();
            consTipoItem.StartPosition = FormStartPosition.CenterScreen;
            consTipoItem.ShowDialog();
        }

        private void Control_Load(object sender, EventArgs e)
        {
            int IdUsuario = Properties.Settings.Default.IdUsuarioLogado;
            IUsuarioEntity usuario = UsuarioDao.ConsultarPorCodigo(IdUsuario);

            //funcionario
            if ((int)usuario.TipoUsuario == 1)
                cadastrarFuncionarioToolStripMenuItem.Visible = true;
            if ((int)usuario.TipoUsuario == 2)
                cadastrarFuncionarioToolStripMenuItem.Visible = false;
            //usuario
            if ((int)usuario.TipoUsuario == 1)
                cadastrarUsuarioToolStripMenuItem.Visible = true;
            if ((int)usuario.TipoUsuario == 2)
                cadastrarUsuarioToolStripMenuItem.Visible = false;

            //Consulta

            //funcionario
            if ((int)usuario.TipoUsuario == 1)
                consultaFuncionarioToolStripMenuItem.Visible = true;
            if ((int)usuario.TipoUsuario == 2)
                consultaFuncionarioToolStripMenuItem.Visible = false;
            //usuario
            if ((int)usuario.TipoUsuario == 1)
                consultaUsuarioToolStripMenuItem.Visible = true;
            if ((int)usuario.TipoUsuario == 2)
                consultaUsuarioToolStripMenuItem.Visible = false;
        }

        private void consultaEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEstoque consEstoque = new ConsultarEstoque();
            consEstoque.StartPosition = FormStartPosition.CenterScreen;
            consEstoque.ShowDialog();
        }
    }
}
