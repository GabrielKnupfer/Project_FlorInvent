using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface;
using Project.FlorInvent.Interface.Enum;

namespace Project.FlorInvent.Dao.Entity
{
    public class FuncionarioEntity : IFuncionarioEntity
    {
        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string DataAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }
        public int Status { get; set; }
    }
}
