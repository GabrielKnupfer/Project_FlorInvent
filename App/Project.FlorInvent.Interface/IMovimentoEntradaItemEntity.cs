using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FlorInvent.Interface
{
    public interface IMovimentoEntradaItemEntity
    {
        IMovimentoEntradaEntity MovimentoEntrada { get; }
        int IdMovimentoEntrada { get; set; }
        IItemEntity item { get; }
        int IdItem { get; set; }
        int IdDeposito { get; set; }
        int QtdTotal { get; set; }
    }
}
