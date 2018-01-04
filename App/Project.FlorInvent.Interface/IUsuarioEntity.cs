using Project.FlorInvent.Interface.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FlorInvent.Interface
{
    public interface IUsuarioEntity
    {
        int IdUsuario { get; set; }
        string NomeUsuario { get; set; }
        TipoUsuarioEnum TipoUsuario { get; set; }
        string Senha { get; set; }
    }
}
