using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data;
using Project.FlorInvent.Interface;
using Project.FlorInvent.Data;
using Project.FlorInvent.Dao.Entity;
using Project.FlorInvent.Interface.Enum;

namespace Project.FlorInvent.Dao
{
    public class FuncionarioDao
    {
        public static void IncluirFuncionario(IFuncionarioEntity funcionario)
        {
            FuncionarioSqlFactory fac = new FuncionarioSqlFactory();
            fac.IncluirFuncionario(funcionario);
        }
        //
        public static IList<IFuncionarioEntity> ConsultarFuncionario(string filtro)
        {
            FuncionarioSqlFactory fac = new FuncionarioSqlFactory();
            IList<IFuncionarioEntity> regs = Binder.Bind<IFuncionarioEntity>(new FuncionarioBinder(), fac.ConsultarFuncionarios(filtro));
            return regs;
        }

        public static IList<IFuncionarioEntity> ConsultarFuncionarioById(int codigoFunc)
        {
            FuncionarioSqlFactory fac = new FuncionarioSqlFactory();
            IList<IFuncionarioEntity> regs = Binder.Bind<IFuncionarioEntity>(new FuncionarioBinder(), fac.ConsultarFuncionarioById(codigoFunc));
            return regs;
        }

        public static void AlterarFuncionario(IFuncionarioEntity funcionario, int codigoFunc)
        {
            FuncionarioSqlFactory fac = new FuncionarioSqlFactory();
            fac.AlterarFuncionario(funcionario, codigoFunc);
        }

        public class FuncionarioBinder : IBindable<IFuncionarioEntity>
        {
            public IFuncionarioEntity Bind(DataRow source)
            {
                IFuncionarioEntity funcionario = new FuncionarioEntity();
                funcionario.IdFuncionario = Convert.ToInt32(source["IdFuncionario"]);
                funcionario.NomeFuncionario = source["Nome"].ToString();
                funcionario.DataNascimento = source["DataNascimento"].ToString();
                funcionario.Sexo = (SexoEnum)Convert.ToInt32(source["Sexo"]);
                funcionario.CPF = source["CPF"].ToString();
                funcionario.Telefone = source["Telefone"].ToString();
                funcionario.Estado = source["Estado"].ToString();
                funcionario.Cep = source["CEP"].ToString();
                funcionario.Cidade = source["Cidade"].ToString();
                funcionario.Bairro = source["Bairro"].ToString();
                funcionario.Logradouro = source["Logradouro"].ToString();
                funcionario.Numero = Convert.ToInt32(source["Numero"]);
                funcionario.Complemento = source["Complemento"].ToString();
                funcionario.DataAdmissao = source["DataAdmissao"].ToString();
                //funcionario.DataDesligamento = Convert.ToDateTime(source["DataDesligamento"]);
                //funcionario.Status = Convert.ToInt32(source["Status"]);


                return funcionario;
            }
        }
    }
}
