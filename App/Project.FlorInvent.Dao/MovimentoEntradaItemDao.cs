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
    public class MovimentoEntradaItemDao
    {
        public static void Inserir(IMovimentoEntradaItemEntity entradaItem)
        {
            MovimentoEntradaItemSqlFactory fac = new MovimentoEntradaItemSqlFactory();
            fac.Inserir(entradaItem);
        }

        public static IList<IMovimentoEntradaItemEntity> ConsultarPorCodigoMovimentoEntrada(int codigo)
        {
            MovimentoEntradaItemSqlFactory fac = new MovimentoEntradaItemSqlFactory();
            IList<IMovimentoEntradaItemEntity> regs = Binder.Bind<IMovimentoEntradaItemEntity>(new MovimentoEntradaItemBinder(), fac.ConsultarPorCodigoMovimentoEntrada(codigo));
            return regs;
        }

        public class MovimentoEntradaItemBinder : IBindable<IMovimentoEntradaItemEntity>
        {
            public IMovimentoEntradaItemEntity Bind(DataRow source)
            {
                IMovimentoEntradaItemEntity entradaItem = new MovimentoEntradaItemEntity();
                entradaItem.IdMovimentoEntrada = Convert.ToInt32(source["IdMovimentoEntrada"]);
                entradaItem.IdItem = Convert.ToInt32(source["IdItem"]);
                entradaItem.IdDeposito = Convert.ToInt32(source["IdDeposito"]);
                entradaItem.QtdTotal = Convert.ToInt32(source["Quantidade"]);
                return entradaItem;
            }
        }
    }
}
