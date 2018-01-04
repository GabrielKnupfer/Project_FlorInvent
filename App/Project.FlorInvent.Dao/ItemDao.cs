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
    public class ItemDao
    {
        public static void IncluirItem(IItemEntity item)
        {
            ItemSqlFactory fac = new ItemSqlFactory();
            fac.IncluirItem(item);
        }

        public static IList<IItemEntity> ConsultarItem(string filtro)
        {
            ItemSqlFactory fac = new ItemSqlFactory();
            IList<IItemEntity> regs = Binder.Bind<IItemEntity>(new ItemBinder(), fac.ConsultarItens(filtro));
            return regs;
        }

        public static IList<IItemEntity> ConsultarById(int codigo)
        {
            ItemSqlFactory fac = new ItemSqlFactory();
            IList<IItemEntity> regs = Binder.Bind<IItemEntity>(new ItemBinder(), fac.ConsultarById(codigo));
            return regs;
        }

        public static IItemEntity ConsultarPorCodigo(int codigo)
        {
            ItemSqlFactory fac = new ItemSqlFactory();
            IList<IItemEntity> regs = Binder.Bind<IItemEntity>(new ItemBinder(), fac.ConsultarPorCodigo(codigo));
            if (regs.Count > 0)
                return regs[0];

            return null;
        }

        public static void AlterarItem(IItemEntity item, int codigoItem)
        {
            ItemSqlFactory fac = new ItemSqlFactory();
            fac.AlterarItem(item, codigoItem);
        }

        public static void ExcluirItem(int codigo)
        {
            ItemSqlFactory fac = new ItemSqlFactory();
            fac.ExcluirItem(codigo);
        }

        public class ItemBinder : IBindable<IItemEntity>
        {
            public IItemEntity Bind(DataRow source)
            {
                IItemEntity item = new ItemEntity();
                item.IdItem = Convert.ToInt32(source["IdItem"]);
                item.Nome = source["Nome"].ToString();
                item.DescricaoItem = source["DescricaoItem"].ToString();
                item.IdTipoItem = Convert.ToInt32(source["IdTipoItem"]);
                item.IdDeposito = Convert.ToInt32(source["IdDeposito"]);

                return item;
            }
        }
    }
}
