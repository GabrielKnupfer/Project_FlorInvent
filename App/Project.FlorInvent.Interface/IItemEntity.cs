using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FlorInvent.Interface
{
    public interface IItemEntity
    {
        int IdItem { get; set; }
        string Nome { get; set; }
        string DescricaoItem { get; set; }
        int IdTipoItem { get; set; }
        int IdDeposito { get; set; }
        string TextoExibicao { get; }
        IDepositoEntity deposito { get; }
        ITipoItemEntity TipoItem { get; }
    }
}
