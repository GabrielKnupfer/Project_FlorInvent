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

namespace Project.FlorInvent.UI
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            string erros = "";

            //Validações
            if (txtNomeCliente.Text == "")
                erros += "- Preencha o campo Nome do Cliente;\n";

            mkdtxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtCPF.Text == "")
                erros += "- Preencha o campo CPF;\n";

            mkdtxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtTelefone.Text == "")
                erros += "- Preencha o campo Telefone;\n";
            if (txtEstadoCliente.Text == "")
                erros += "- Preencha o campo Estado;\n";
            if (txtCidadeCliente.Text == "")
                erros += "- Preencha o campo Cidade;\n";

            mkdtxtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtCEP.Text == "")
                erros += "- Preencha o campo CEP;\n";
            if (txtBairroCliente.Text == "")
                erros += "- Preencha o campo Bairro;\n";
            if (txtLogradouroCliente.Text == "")
                erros += "- Preencha o campo Logradouro;\n";
            if (mkdtxtNumero.Text == "")
                erros += "- Preencha o campo Numero;\n";

            mkdtxtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mkdtxtTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mkdtxtCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            mkdtxtNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!string.IsNullOrEmpty(erros))
            {
                MessageBox.Show(erros);
            }
            else
            {
                ClienteEntity cliente = new ClienteEntity();
                {
                    cliente.NomeCliente = txtNomeCliente.Text;
                    cliente.CPF = mkdtxtCPF.Text;
                    cliente.Telefone = mkdtxtTelefone.Text;
                    cliente.Estado = txtEstadoCliente.Text;
                    cliente.CEP = mkdtxtCEP.Text;
                    cliente.Cidade = txtCidadeCliente.Text;
                    cliente.Bairro = txtBairroCliente.Text;
                    cliente.Logradouro = txtLogradouroCliente.Text;
                    cliente.Numero = int.Parse(mkdtxtNumero.Text);
                    cliente.Complemento = txtComplementoCliente.Text;
                }

                ClienteDao.IncluirCliente(cliente);
                MessageBox.Show("Incluido com sucesso!");
                this.Close();
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
