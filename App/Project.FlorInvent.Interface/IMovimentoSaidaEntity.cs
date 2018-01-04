using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FlorInvent.Interface
{
    public interface IMovimentoSaidaEntity
    {
        int IdMovimentoSaida { get; set; }
        int IdUsuario { get; set; }
        int IdCliente { get; set; }
        DateTime DataMovimento { get; set; }

        IUsuarioEntity usuario { get; }
        IClienteEntity cliente { get; }
    }
}
