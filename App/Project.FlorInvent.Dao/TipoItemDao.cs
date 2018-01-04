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
    public class TipoItemDao
    {
        public static void IncluirTipoItem(ITipoItemEntity tipoItem)
        {
            TipoItemSqlFactory fac = new TipoItemSqlFactory();
            fac.IncluirTipoItem(tipoItem);
        }

        public static ITipoItemEntity ConsultarTipoItemPorCodigo(int codigo)
        {
            TipoItemSqlFactory fac = new TipoItemSqlFactory();
            IList<ITipoItemEntity> regs = Binder.Bind<ITipoItemEntity>(new TipoItemBinder(), fac.ConsultarTipoItemPorCodigo(codigo));
            if (regs.Count > 0)
                return regs[0];

            return null;
        }

        public static IList<ITipoItemEntity> RetornarTipoItem()
        {
            TipoItemSqlFactory fac = new TipoItemSqlFactory();
            IList<ITipoItemEntity> regs = Binder.Bind<ITipoItemEntity>(new TipoItemBinder(), fac.RetornarTipoItem());
            return regs;
        }

        public static IList<ITipoItemEntity> ConsultarTiposItem(string filtro)
        {
            TipoItemSqlFactory fac = new TipoItemSqlFactory();
            IList<ITipoItemEntity> regs = Binder.Bind<ITipoItemEntity>(new TipoItemBinder(), fac.ConsultarTiposItem(filtro));
            return regs;
        }

        public static IList<ITipoItemEntity> ConsultarById(int codigo)
        {
            TipoItemSqlFactory fac = new TipoItemSqlFactory();
            IList<ITipoItemEntity> regs = Binder.Bind<ITipoItemEntity>(new TipoItemBinder(), fac.ConsultarTipoItemPorCodigo(codigo));
            return regs;
        }

        public static void AlterarTipoItem(ITipoItemEntity tipoItem, int codigoTipoItem)
        {
            TipoItemSqlFactory fac = new TipoItemSqlFactory();
            fac.AlterarTipoItem(tipoItem, codigoTipoItem);
        }

        public static void ExcluirTipoItem(int codigo)
        {
            TipoItemSqlFactory fac = new TipoItemSqlFactory();
            fac.ExcluirTipoItem(codigo);
        }

        public class TipoItemBinder : IBindable<ITipoItemEntity>
        {
            public ITipoItemEntity Bind(DataRow source)
            {
                ITipoItemEntity tipoItem = new TipoItemEntity();
                tipoItem.IdTipoItem = Convert.ToInt32(source["IdTipoItem"]);
                tipoItem.Descricao = source["Descricao"].ToString();

                return tipoItem;
            }
        }
    }
}
