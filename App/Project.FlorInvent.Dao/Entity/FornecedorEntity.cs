using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface;

namespace Project.FlorInvent.Dao.Entity
{
    public class FornecedorEntity : IFornecedorEntity
    {
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int Status { get; set; }
        public string TextoExibicao
        {
            get
            {
                return this.CNPJ + " - " +
                    this.NomeFornecedor;
            }
        }
    }
}
