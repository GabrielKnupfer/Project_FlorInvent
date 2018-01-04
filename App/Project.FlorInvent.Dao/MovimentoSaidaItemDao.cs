using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.FlorInvent.Interface;
using Project.FlorInvent.Data;
using Project.FlorInvent.Dao.Entity;

namespace Project.FlorInvent.Dao
{
    public class MovimentoSaidaItemDao
    {
        public static void Inserir(IMovimentoSaidaItemEntity saidaItem)
        {
            MovimentoSaidaItemSqlFactory fac = new MovimentoSaidaItemSqlFactory();
            fac.Inserir(saidaItem);
        }

        public static IList<IMovimentoSaidaItemEntity> ConsultarPorCodigoMovimentoSaida(int codigo)
        {
            MovimentoSaidaItemSqlFactory fac = new MovimentoSaidaItemSqlFactory();
            IList<IMovimentoSaidaItemEntity> regs = Binder.Bind<IMovimentoSaidaItemEntity>(new MovimentoSaidaItemBinder(), fac.ConsultarPorCodigoMovimentoSaida(codigo));
            return regs;
        }

        public class MovimentoSaidaItemBinder : IBindable<IMovimentoSaidaItemEntity>
        {
            public IMovimentoSaidaItemEntity Bind(DataRow source)
            {
                IMovimentoSaidaItemEntity saidaItem = new MovimentoSaidaItemEntity();
                saidaItem.IdMovimentoSaida = Convert.ToInt32(source["IdMovimentoSaida"]);
                saidaItem.IdItem = Convert.ToInt32(source["IdItem"]);
                saidaItem.IdDeposito = Convert.ToInt32(source["IdDeposito"]);
                saidaItem.QtdTotal = Convert.ToInt32(source["Quantidade"]);
                return saidaItem;
            }
        }
    }
}
