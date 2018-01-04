using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FlorInvent.Interface
{
    public interface IMovimentoEntradaEntity
    {
        int IdMovimentacaoEntrada { get; set; }
        int IdUsuario { get; set; }
        int IdFornecedor { get; set; }
        DateTime DataMovimento { get; set; }

        IUsuarioEntity usuario { get; }
        IFornecedorEntity fornecedor { get; }
    }
}
