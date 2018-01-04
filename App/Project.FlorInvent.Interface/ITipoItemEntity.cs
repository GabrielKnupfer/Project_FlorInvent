using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FlorInvent.Interface
{
    public interface ITipoItemEntity
    {
        int IdTipoItem { get; set; }
        string Descricao { get; set; }
        string TextoExibicao { get; }
    }
}
