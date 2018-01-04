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
    public class FornecedorDao
    {
        public static void IncluirFornecedor(IFornecedorEntity fornecedor)
        {
            FornecedorSqlFactory fac = new FornecedorSqlFactory();
            fac.IncluirFornecedor(fornecedor);
        }

        public static IList<IFornecedorEntity> ConsultarFornecedor(string filtro)
        {
            FornecedorSqlFactory fac = new FornecedorSqlFactory();
            IList<IFornecedorEntity> regs = Binder.Bind<IFornecedorEntity>(new FornecedorBinder(), fac.ConsultarFornecedores(filtro));
            return regs;
        }

        public static IList<IFornecedorEntity> ConsultarFornecedorById(int codigoForn)
        {
            FornecedorSqlFactory fac = new FornecedorSqlFactory();
            IList<IFornecedorEntity> regs = Binder.Bind<IFornecedorEntity>(new FornecedorBinder(), fac.ConsultarFornecedorById(codigoForn));
            return regs;
        }

        public static void AlterarFornecedor(IFornecedorEntity fornecedor, int codigoForn)
        {
            FornecedorSqlFactory fac = new FornecedorSqlFactory();
            fac.AlterarFornecedor(fornecedor, codigoForn);
        }

        public static IList<IFornecedorEntity> RetornarFornecedores()
        {
            FornecedorSqlFactory fac = new FornecedorSqlFactory();
            IList<IFornecedorEntity> regs = Binder.Bind<IFornecedorEntity>(new FornecedorBinder(), fac.RetornarFornecedores());
            return regs;
        }

        public static IFornecedorEntity ConsultarPorCodigo(int codigo)
        {
            FornecedorSqlFactory fac = new FornecedorSqlFactory();
            IList<IFornecedorEntity> regs = Binder.Bind<IFornecedorEntity>(new FornecedorBinder(), fac.ConsultarPorCodigo(codigo));
            if (regs.Count > 0)
                return regs[0];

            return null;
        }

        public class FornecedorBinder : IBindable<IFornecedorEntity>
        {
            public IFornecedorEntity Bind(DataRow source)
            {
                IFornecedorEntity fornecedor = new FornecedorEntity();
                fornecedor.IdFornecedor = Convert.ToInt32(source["IdFornecedor"]);
                fornecedor.NomeFornecedor = source["Nome"].ToString();
                fornecedor.CNPJ = source["CNPJ"].ToString();
                fornecedor.Telefone = source["Telefone"].ToString();
                fornecedor.Estado = source["Estado"].ToString();
                fornecedor.CEP = source["CEP"].ToString();
                fornecedor.Cidade = source["Cidade"].ToString();
                fornecedor.Bairro = source["Bairro"].ToString();
                fornecedor.Logradouro = source["Logradouro"].ToString();
                fornecedor.Numero = Convert.ToInt32(source["Numero"]);
                fornecedor.Complemento = source["Complemento"].ToString();
                //funcionario.Status = Convert.ToInt32(source["Status"]);

                return fornecedor;
            }
        }
    }
}
