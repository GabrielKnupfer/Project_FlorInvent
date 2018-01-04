using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FlorInvent.Interface
{
    public interface IClienteEntity
    {
        int IdCliente { get; set; }
        string NomeCliente { get; set; }
        string CPF { get; set; }
        string Telefone { get; set; }
        string Estado { get; set; }
        string CEP { get; set; }
        string Cidade { get; set; }
        string Bairro { get; set; }
        string Logradouro { get; set; }
        int Numero { get; set; }
        string Complemento { get; set; }
        string TextoExibicao { get; }
    }
}
