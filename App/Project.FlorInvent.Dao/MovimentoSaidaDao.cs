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
    public class MovimentoSaidaDao
    {
        public static int Inserir(IMovimentoSaidaEntity saida)
        {
            MovimentoSaidaSqlFactory fac = new MovimentoSaidaSqlFactory();
            return fac.Inserir(saida);
        }

        public static IMovimentoSaidaEntity ConsultarPorCodigo(int codigo)
        {
            MovimentoSaidaSqlFactory fac = new MovimentoSaidaSqlFactory();
            IList<IMovimentoSaidaEntity> regs = Binder.Bind<IMovimentoSaidaEntity>(new MovimentoSaidaBinder(), fac.ConsultarPorCodigo(codigo));
            if (regs.Count > 0)
                return regs[0];

            return null;
        }

        public static IList<IMovimentoSaidaEntity> ConsultarPorData(string Data)
        {
            MovimentoSaidaSqlFactory fac = new MovimentoSaidaSqlFactory();
            IList<IMovimentoSaidaEntity> regs = Binder.Bind<IMovimentoSaidaEntity>(new MovimentoSaidaBinder(), fac.ConsultarPorData(Data));
            return regs;
        }

        public class MovimentoSaidaBinder : IBindable<IMovimentoSaidaEntity>
        {
            public IMovimentoSaidaEntity Bind(DataRow source)
            {
                IMovimentoSaidaEntity saida = new MovimentoSaidaEntity();
                saida.IdMovimentoSaida = Convert.ToInt32(source["IdMovimentoSaida"]);
                saida.IdUsuario = Convert.ToInt32(source["IdUsuario"]);
                saida.IdCliente = Convert.ToInt32(source["IdCliente"]);
                saida.DataMovimento = Convert.ToDateTime(source["DataMovimento"]);
                return saida;
            }
        }
    }
}
