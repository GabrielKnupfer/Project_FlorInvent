using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface;
using Project.FlorInvent.Interface.Enum;

namespace Project.FlorInvent.Dao.Entity
{
    public class UsuarioEntity : IUsuarioEntity
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public string Senha { get; set; }
    }
}
