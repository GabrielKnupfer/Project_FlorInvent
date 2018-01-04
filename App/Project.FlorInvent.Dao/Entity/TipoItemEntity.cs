using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface;

namespace Project.FlorInvent.Dao.Entity
{
    public class TipoItemEntity : ITipoItemEntity
    {
        public int IdTipoItem { get; set; }
        public string Descricao { get; set; }
        public string TextoExibicao
        {
            get
            {
                return this.Descricao;
            }
        }
    }
}
