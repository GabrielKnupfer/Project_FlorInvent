using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface;

namespace Project.FlorInvent.Dao.Entity
{
    public class ItemEntity : IItemEntity
    {
        public int IdItem { get; set; }
        public string Nome { get; set; }
        public string DescricaoItem { get; set; }
        public int IdTipoItem { get; set; }
        public int IdDeposito { get; set; }
        public string TextoExibicao
        {
            get
            {
                return this.IdItem + " - " +
                    this.Nome;
            }
        }

        private IDepositoEntity _deposito;
        public IDepositoEntity deposito
        {
            get
            {
                if (this._deposito == null)
                    this._deposito = DepositoDao.ConsultarPorCodigo(this.IdDeposito);

                return this._deposito;
            }
        }

        private ITipoItemEntity _tipoItem;
        public ITipoItemEntity TipoItem
        {
            get
            {
                if (this._tipoItem == null)
                    this._tipoItem = TipoItemDao.ConsultarTipoItemPorCodigo(this.IdTipoItem);

                return this._tipoItem;
            }
        }

    }
}
