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
    public class MovimentoEntradaDao
    {
        public static int Inserir(IMovimentoEntradaEntity entrada)
        {
            MovimentoEntradaSqlFactory fac = new MovimentoEntradaSqlFactory();
            return fac.Inserir(entrada);
        }

        public static IMovimentoEntradaEntity ConsultarPorCodigo(int codigo)
        {
            MovimentoEntradaSqlFactory fac = new MovimentoEntradaSqlFactory();
            IList<IMovimentoEntradaEntity> regs = Binder.Bind<IMovimentoEntradaEntity>(new MovimentoEntradaBinder(), fac.ConsultarPorCodigo(codigo));
            if (regs.Count > 0)
                return regs[0];

            return null;
        }

        public static IList<IMovimentoEntradaEntity> ConsultarPorData(string Data)
        {
            MovimentoEntradaSqlFactory fac = new MovimentoEntradaSqlFactory();
            IList<IMovimentoEntradaEntity> regs = Binder.Bind<IMovimentoEntradaEntity>(new MovimentoEntradaBinder(), fac.ConsultarPorData(Data));
            return regs;
        }

        public class MovimentoEntradaBinder : IBindable<IMovimentoEntradaEntity>
        {
            public IMovimentoEntradaEntity Bind(DataRow source)
            {
                IMovimentoEntradaEntity entrada = new MovimentoEntradaEntity();
                entrada.IdMovimentacaoEntrada = Convert.ToInt32(source["IdMovimentoEntrada"]);
                entrada.IdUsuario = Convert.ToInt32(source["IdUsuario"]);
                entrada.IdFornecedor = Convert.ToInt32(source["IdFornecedor"]);
                entrada.DataMovimento = Convert.ToDateTime(source["DataMovimento"]);
                return entrada;
            }
        }
    }
}
