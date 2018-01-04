using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface;

namespace Project.FlorInvent.Dao.Entity
{
    public class MovimentoEntradaItemEntity : IMovimentoEntradaItemEntity
    {
        private IMovimentoEntradaEntity _movimentoEntrada;
        public IMovimentoEntradaEntity MovimentoEntrada
        {
            get
            {
                if (this._movimentoEntrada == null)
                    this._movimentoEntrada = MovimentoEntradaDao.ConsultarPorCodigo(this.IdMovimentoEntrada);

                return this._movimentoEntrada;
            }
        }

        public int IdMovimentoEntrada { get; set; }

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

        public int IdItem { get; set; }
        public int IdDeposito { get; set; }
        public int QtdTotal { get; set; }
    }
}
