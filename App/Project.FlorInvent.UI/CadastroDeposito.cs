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
    public partial class CadastroDeposito : Form
    {
        public CadastroDeposito()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnSalvarDeposito_Click(object sender, EventArgs e)
        {
            string erros = "";

            //Validações
            if (txtDescricaoDeposito.Text == "")
                erros += "- Preencha o campo Descrição;\n";
            if (txtEstadoDeposito.Text == "")
                erros += "- Preencha o campo Estado;\n";
            if (txtCidadeDeposito.Text == "")
                erros += "- Preencha o campo Cidade;\n";

            mkdtxtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtCEP.Text == "")
                erros += "- Preencha o campo CEP;\n";
            if (txtBairroDeposito.Text == "")
                erros += "- Preencha o campo Bairro;\n";
            if (txtLogradouroDeposito.Text == "")
                erros += "- Preencha o campo Logradouro;\n";
            if (mkdtxtNumero.Text == "")
                erros += "- Preencha o campo Numero;\n";

            mkdtxtCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            mkdtxtNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!string.IsNullOrEmpty(erros))
            {
                MessageBox.Show(erros);
            }

            else
            {
                DepositoEntity deposito = new DepositoEntity();
                {
                    deposito.DescricaoDeposito = txtDescricaoDeposito.Text;
                    deposito.Estado = txtEstadoDeposito.Text;
                    deposito.CEP = mkdtxtCEP.Text;
                    deposito.Cidade = txtCidadeDeposito.Text;
                    deposito.Bairro = txtBairroDeposito.Text;
                    deposito.Logradouro = txtLogradouroDeposito.Text;
                    deposito.Numero = int.Parse(mkdtxtNumero.Text);
                    deposito.Complemento = txtComplementoDeposito.Text;
                }

                DepositoDao.IncluirDeposito(deposito);
                MessageBox.Show("Incluido com sucesso!");
                this.Close();
            }
        }

        private void btnCancelarDeposito_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
