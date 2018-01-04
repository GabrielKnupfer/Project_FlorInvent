using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface;

namespace Project.FlorInvent.Dao.Entity
{
    public class MovimentoSaidaItemEntity : IMovimentoSaidaItemEntity
    {
        public int IdMovimentoSaida { get; set; }
        public int IdItem { get; set; }
        public int IdDeposito { get; set; }
        public int QtdTotal { get; set; }

        private IMovimentoSaidaEntity _movimentosaida;
        public IMovimentoSaidaEntity MovimentoSaida
        {
            get
            {
                if (this._movimentosaida == null)
                    this._movimentosaida = MovimentoSaidaDao.ConsultarPorCodigo(this.IdMovimentoSaida);

                return this._movimentosaida;
            }
        }

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
