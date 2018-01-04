using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FlorInvent.Interface
{
    public interface IEstoqueEntity
    {
        int IdEstoque { get; set; }
        int QuantidadeTotal { get; set; }
        int QuantidadeUtilizada { get; set; }
        int IdItem { get; set; }
        int QuantidadeDisponivel { get; }
        IItemEntity item { get; }
    }
}
