﻿using Project.FlorInvent.Dao;
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
    public partial class AlterarFornecedor : Form
    {
        private int CodigoFornecedor;
        public AlterarFornecedor(int codigoFornecedorSelecionado)
        {
            this.CodigoFornecedor = codigoFornecedorSelecionado;
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            string erros = "";

            //Validações
            if (txtNomeFornecedor.Text == "")
                erros += "- Preencha o campo Nome do Fornecedor;\n";

            mkdtxtCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtCNPJ.Text == "")
                erros += "- Preencha o campo CNPJ;\n";

            mkdtxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtTelefone.Text == "")
                erros += "- Preencha o campo Telefone;\n";
            if (txtEstadoFornecedor.Text == "")
                erros += "- Preencha o campo Estado;\n";
            if (txtCidadeFornecedor.Text == "")
                erros += "- Preencha o campo Cidade;\n";

            mkdtxtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtCEP.Text == "")
                erros += "- Preencha o campo CEP;\n";
            if (txtBairroFornecedor.Text == "")
                erros += "- Preencha o campo Bairro;\n";
            if (txtLogradouroFornecedor.Text == "")
                erros += "- Preencha o campo Logradouro;\n";

            mkdtxtNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mkdtxtNumero.Text == "")
                erros += "- Preencha o campo Numero;\n";

            mkdtxtCNPJ.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mkdtxtTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mkdtxtCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mkdtxtNumero.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            mkdtxtNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!string.IsNullOrEmpty(erros))
            {
                MessageBox.Show(erros);
            }
            else
            {
                FornecedorEntity fornecedor = new FornecedorEntity();
                {
                    fornecedor.NomeFornecedor = txtNomeFornecedor.Text;
                    fornecedor.CNPJ = mkdtxtCNPJ.Text;
                    fornecedor.Telefone = mkdtxtTelefone.Text;
                    fornecedor.Estado = txtEstadoFornecedor.Text;
                    fornecedor.CEP = mkdtxtCEP.Text;
                    fornecedor.Cidade = txtCidadeFornecedor.Text;
                    fornecedor.Bairro = txtBairroFornecedor.Text;
                    fornecedor.Logradouro = txtLogradouroFornecedor.Text;
                    fornecedor.Numero = int.Parse(mkdtxtNumero.Text);
                    fornecedor.Complemento = txtComplementoFornecedor.Text;
                }

                FornecedorDao.AlterarFornecedor(fornecedor, this.CodigoFornecedor);
                MessageBox.Show("Fornecedor alterado com sucesso");
                this.Close();
            }
        }

        private void AlterarFornecedor_Load(object sender, EventArgs e)
        {
            IList<IFornecedorEntity> fornecedores = FornecedorDao.ConsultarFornecedorById(this.CodigoFornecedor);

            foreach (IFornecedorEntity forn in fornecedores)
            {
                txtNomeFornecedor.Text = forn.NomeFornecedor.ToString();
                mkdtxtCNPJ.Text = forn.CNPJ.ToString();
                mkdtxtTelefone.Text = forn.Telefone.ToString();
                txtEstadoFornecedor.Text = forn.Estado.ToString();
                txtCidadeFornecedor.Text = forn.Cidade.ToString();
                mkdtxtCEP.Text = forn.CEP.ToString();
                txtBairroFornecedor.Text = forn.Bairro.ToString();
                txtLogradouroFornecedor.Text = forn.Logradouro.ToString();
                mkdtxtNumero.Text = forn.Numero.ToString();
                txtComplementoFornecedor.Text = forn.Complemento.ToString();
            }
        }

        private void btnCancelarFornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
