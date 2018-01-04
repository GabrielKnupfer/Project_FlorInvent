using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FlorInvent.Interface
{
    public interface IFornecedorEntity
    {
        int IdFornecedor { get; set; }
        string NomeFornecedor { get; set; }
        string CNPJ { get; set; }
        string Telefone { get; set; }
        string Estado { get; set; }
        string CEP { get; set; }
        string Cidade { get; set; }
        string Bairro { get; set; }
        string Logradouro { get; set; }
        int Numero { get; set; }
        string Complemento { get; set; }
        int Status { get; set; }
        string TextoExibicao { get; }
    }
}
