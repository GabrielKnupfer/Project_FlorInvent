using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface.Enum;

namespace Project.FlorInvent.Interface
{
    public interface IFuncionarioEntity
    {
        int IdFuncionario { get; set; }
        string NomeFuncionario { get; set; }
        string DataNascimento { get; set; }
        SexoEnum Sexo { get; set; }
        string CPF { get; set; }
        string Telefone { get; set; }
        string Estado { get; set; }
        string Cep { get; set; }
        string Cidade { get; set; }
        string Bairro { get; set; }
        string Logradouro { get; set; }
        int Numero { get; set; }
        string Complemento { get; set; }
        string DataAdmissao { get; set; }
        DateTime DataDesligamento { get; set; }
        int Status { get; set; }
    }
}
