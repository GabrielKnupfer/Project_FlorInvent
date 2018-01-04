using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface;

namespace Project.FlorInvent.Dao.Entity
{
    public class EstoqueEntity : IEstoqueEntity
    {
        public int IdEstoque { get; set; }
        public int QuantidadeTotal { get; set; }
        public int QuantidadeUtilizada { get; set; }
        public int IdItem { get; set; }
        public int QuantidadeDisponivel { get { return this.QuantidadeTotal - this.QuantidadeUtilizada; } }

        private IItemEntity _item;
        public IItemEntity item
        {
            get
            {
                if (this._item == null)
                    this._item = ItemDao.ConsultarPorCodigo(this.IdItem);

                return this._item;
            }
        }
    }
}
