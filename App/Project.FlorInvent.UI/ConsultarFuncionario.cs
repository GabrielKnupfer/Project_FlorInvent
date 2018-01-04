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
    public partial class ConsultarFuncionario : Form
    {
        public ConsultarFuncionario()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            //if(txtConsultaFuncionario.Text.Length <= 3)
            //{
            //    MessageBox.Show("Preencha pelo menos 3 letras do nome ou do CPF do funcionario");

            //    return;
            //}

            IList<IFuncionarioEntity> funcionarios = FuncionarioDao.ConsultarFuncionario(txtConsultaFuncionario.Text);
            dtgridConsultarFuncionario.Rows.Clear();

            if (funcionarios.Count <= 0)
            {
                MessageBox.Show("A busca não retornou resultado.");
                return;
            }

            int rowId = 0;
            foreach (IFuncionarioEntity func in funcionarios)
            {
                rowId = dtgridConsultarFuncionario.Rows.AddCopy(0);
                dtgridConsultarFuncionario.Rows[rowId].Cells["CodigoFuncionario"].Value = func.IdFuncionario;
                dtgridConsultarFuncionario.Rows[rowId].Cells["Nome"].Value = func.NomeFuncionario;
                dtgridConsultarFuncionario.Rows[rowId].Cells["DataNascimento"].Value = func.DataNascimento;
                dtgridConsultarFuncionario.Rows[rowId].Cells["Sexo"].Value = func.Sexo;
                dtgridConsultarFuncionario.Rows[rowId].Cells["CPF"].Value = func.CPF;
                dtgridConsultarFuncionario.Rows[rowId].Cells["Telefone"].Value = func.Telefone;
                dtgridConsultarFuncionario.Rows[rowId].Cells["Estado"].Value = func.Estado;
                dtgridConsultarFuncionario.Rows[rowId].Cells["CEP"].Value = func.Cep;
                dtgridConsultarFuncionario.Rows[rowId].Cells["Cidade"].Value = func.Cidade;
                dtgridConsultarFuncionario.Rows[rowId].Cells["Bairro"].Value = func.Bairro;
                dtgridConsultarFuncionario.Rows[rowId].Cells["Logradouro"].Value = func.Logradouro;
                dtgridConsultarFuncionario.Rows[rowId].Cells["Numero"].Value = func.Numero;
                dtgridConsultarFuncionario.Rows[rowId].Cells["Complemento"].Value = func.Complemento;
                dtgridConsultarFuncionario.Rows[rowId].Cells["DataAdmissao"].Value = func.DataAdmissao;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgridConsultarFuncionario.SelectedRows)
            {
                int codigofuncionarioSelecionado = Convert.ToInt32(row.Cells["CodigoFuncionario"].Value);
                AlterarFuncionario frm = new AlterarFuncionario(codigofuncionarioSelecionado);
                frm.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
