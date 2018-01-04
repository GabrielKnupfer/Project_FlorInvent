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
    public class EstoqueDao
    {
        public static void Incluir(IEstoqueEntity estoque)
        {
            EstoqueSqlFactory fac = new EstoqueSqlFactory();
            fac.Inserir(estoque);
        }

        public static IEstoqueEntity ConsultarPorCodigoItem(int codigoItem)
        {
            EstoqueSqlFactory fac = new EstoqueSqlFactory();
            IList<IEstoqueEntity> regs = Binder.Bind<IEstoqueEntity>(new EstoqueBinder(), fac.ConsultarPorIdItem(codigoItem));
            if (regs.Count > 0)
                return regs[0];

            return null;
        }

        public static IList<IEstoqueEntity> ConsultarPorIdItem(int IdItem)
        {
            EstoqueSqlFactory fac = new EstoqueSqlFactory();
            IList<IEstoqueEntity> regs = Binder.Bind<IEstoqueEntity>(new EstoqueBinder(), fac.ConsultarPorIdItem(IdItem));
            return regs;
        }

        public static IList<IEstoqueEntity> ConsultarEstoque(string filtro)
        {
            EstoqueSqlFactory fac = new EstoqueSqlFactory();
            IList<IEstoqueEntity> regs = Binder.Bind<IEstoqueEntity>(new EstoqueBinder(), fac.ConsultarEstoque(filtro));
            return regs;
        }

        public static void Atualizar(IEstoqueEntity estoque, int codigoItem)
        {
            EstoqueSqlFactory fac = new EstoqueSqlFactory();
            fac.Atualizar(estoque, codigoItem);
        }

        public class EstoqueBinder : IBindable<IEstoqueEntity>
        {
            public IEstoqueEntity Bind(DataRow source)
            {
                IEstoqueEntity item = new EstoqueEntity();
                item.IdItem = Convert.ToInt32(source["IdItem"]);
                item.QuantidadeTotal = Convert.ToInt32(source["QuantidadeTotal"]);
                item.QuantidadeUtilizada = Convert.ToInt32(source["QuantidadeUtilizada"]);
                item.IdEstoque = Convert.ToInt32(source["IdEstoque"]);

                return item;
            }
        }
    }
}
