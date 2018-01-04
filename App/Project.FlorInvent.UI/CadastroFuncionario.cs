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
using Project.FlorInvent.Interface.Enum;

namespace Project.FlorInvent.UI
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string erros = "";
            int sexo = 0;

            //Validações
            if (txtNomeFuncionario.Text == "")
                erros += "- Preencha o campo Nome do Funcionário;\n";

            mkdtxtDataNascimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtDataNascimento.Text == "")
                erros += "- Preencha o campo Data Nascimento;\n";
            if (rdbSexoMasculino.Checked == false && rdbSexoFeminino.Checked == false)
                erros += "- Selecione o sexo do Funcionário;\n";

            mkdtxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtCPF.Text == "")
                erros += "- Preencha o campo CPF;\n";

            mkdtxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtTelefone.Text == "")
                erros += "- Preencha o campo Telefone;\n";
            if (txtEstado.Text == "")
                erros += "- Preencha o campo Estado;\n";
            if (txtCidade.Text == "")
                erros += "- Preencha o campo Cidade;\n";

            mkdtxtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtCEP.Text == "")
                erros += "- Preencha o campo CEP;\n";
            if (txtBairro.Text == "")
                erros += "- Preencha o campo Bairro;\n";
            if (txtLogradouro.Text == "")
                erros += "- Preencha o campo Logradouro;\n";
            if (mkdtxtNumero.Text == "")
                erros += "- Preencha o campo Numero;\n";

            mkdtxtDataAdmissao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtDataAdmissao.Text == "")
                erros += "- Preencha o campo Data Admissão;\n";

            if (rdbSexoMasculino.Checked == true && rdbSexoFeminino.Checked == false)
                sexo = 1;
            if (rdbSexoMasculino.Checked == false && rdbSexoFeminino.Checked == true)
                sexo = 2;

            mkdtxtDataNascimento.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mkdtxtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mkdtxtTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mkdtxtCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mkdtxtDataAdmissao.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            mkdtxtNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!string.IsNullOrEmpty(erros))
            {
                MessageBox.Show(erros);
            }
            else
            {
                FuncionarioEntity funcionario = new FuncionarioEntity();
                {
                    funcionario.NomeFuncionario = txtNomeFuncionario.Text;
                    funcionario.DataNascimento = mkdtxtDataNascimento.Text;
                    funcionario.Sexo = (SexoEnum)Convert.ToInt32(sexo);
                    funcionario.CPF = mkdtxtCPF.Text;
                    funcionario.Telefone = mkdtxtTelefone.Text;
                    funcionario.Estado = txtEstado.Text;
                    funcionario.Cep = mkdtxtCEP.Text;
                    funcionario.Cidade = txtCidade.Text;
                    funcionario.Bairro = txtBairro.Text;
                    funcionario.Logradouro = txtLogradouro.Text;
                    funcionario.Numero = int.Parse(mkdtxtNumero.Text);
                    funcionario.Complemento = txtComplemento.Text;
                    funcionario.DataAdmissao = mkdtxtDataAdmissao.Text;
                }

                FuncionarioDao.IncluirFuncionario(funcionario);
                MessageBox.Show("Incluido com sucesso!");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
