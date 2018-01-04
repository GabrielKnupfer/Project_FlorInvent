using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FlorInvent.Interface
{
    public interface IMovimentoSaidaItemEntity
    {
        int IdMovimentoSaida { get; set; }
        int IdItem { get; set; }
        int IdDeposito { get; set; }
        int QtdTotal { get; set; }
        IMovimentoSaidaEntity MovimentoSaida { get; }
        IItemEntity item { get; }
    }
}
