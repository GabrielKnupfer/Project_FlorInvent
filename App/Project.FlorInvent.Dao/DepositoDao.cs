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
    public class DepositoDao
    {
        public static void IncluirDeposito(IDepositoEntity deposito)
        {
            DepositoSqlFactory fac = new DepositoSqlFactory();
            fac.IncluirDeposito(deposito);
        }

        public static IList<IDepositoEntity> ConsultarDeposito(string filtro)
        {
            DepositoSqlFactory fac = new DepositoSqlFactory();
            IList<IDepositoEntity> regs = Binder.Bind<IDepositoEntity>(new DepositoBinder(), fac.ConsultarDepositos(filtro));
            return regs;
        }

        public static IList<IDepositoEntity> ConsultarDepositoById(int codigoDepo)
        {
            DepositoSqlFactory fac = new DepositoSqlFactory();
            IList<IDepositoEntity> regs = Binder.Bind<IDepositoEntity>(new DepositoBinder(), fac.ConsultarDepositoById(codigoDepo));
            return regs;
        }

        public static void AlterarDeposito(IDepositoEntity deposito, int codigoDepo)
        {
            DepositoSqlFactory fac = new DepositoSqlFactory();
            fac.AlterarDeposito(deposito, codigoDepo);
        }

        public static IDepositoEntity ConsultarPorCodigo(int codigo)
        {
            DepositoSqlFactory fac = new DepositoSqlFactory();
            IList<IDepositoEntity> regs = Binder.Bind<IDepositoEntity>(new DepositoBinder(), fac.ConsultarPorCodigo(codigo));
            if (regs.Count > 0)
                return regs[0];

            return null;
        }

        public static void ExcluirDeposito(int codigo)
        {
            DepositoSqlFactory fac = new DepositoSqlFactory();
            fac.ExcluirDeposito(codigo);
        }

        public static IList<IDepositoEntity> RetornarDepositos()
        {
            DepositoSqlFactory fac = new DepositoSqlFactory();
            IList<IDepositoEntity> regs = Binder.Bind<IDepositoEntity>(new DepositoBinder(), fac.RetornarDepositos());
            return regs;
        }

        public class DepositoBinder : IBindable<IDepositoEntity>
        {
            public IDepositoEntity Bind(DataRow source)
            {
                IDepositoEntity deposito = new DepositoEntity();
                deposito.IdDeposito = Convert.ToInt32(source["IdDeposito"]);
                deposito.DescricaoDeposito = source["Descricao"].ToString();
                deposito.Estado = source["Estado"].ToString();
                deposito.CEP = source["CEP"].ToString();
                deposito.Cidade = source["Cidade"].ToString();
                deposito.Bairro = source["Bairro"].ToString();
                deposito.Logradouro = source["Logradouro"].ToString();
                deposito.Numero = Convert.ToInt32(source["Numero"]);
                deposito.Complemento = source["Complemento"].ToString();

                return deposito;
            }
        }
    }
}
