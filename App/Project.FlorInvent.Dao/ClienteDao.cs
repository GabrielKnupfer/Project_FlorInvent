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
    public class ClienteDao
    {
        public static void IncluirCliente(IClienteEntity cliente)
        {
            ClienteSqlFactory fac = new ClienteSqlFactory();
            fac.IncluirCliente(cliente);
        }

        public static IList<IClienteEntity> ConsultarCliente(string filtro)
        {
            ClienteSqlFactory fac = new ClienteSqlFactory();
            IList<IClienteEntity> regs = Binder.Bind<IClienteEntity>(new ClienteBinder(), fac.ConsultarClientes(filtro));
            return regs;
        }

        public static IList<IClienteEntity> ConsultarClienteById(int codigoClie)
        {
            ClienteSqlFactory fac = new ClienteSqlFactory();
            IList<IClienteEntity> regs = Binder.Bind<IClienteEntity>(new ClienteBinder(), fac.ConsultarClienteById(codigoClie));
            return regs;
        }

        public static void AlterarCliente(IClienteEntity cliente, int codigoClie)
        {
            ClienteSqlFactory fac = new ClienteSqlFactory();
            fac.AlterarCliente(cliente, codigoClie);
        }

        public static IList<IClienteEntity> RetornarClientes()
        {
            ClienteSqlFactory fac = new ClienteSqlFactory();
            IList<IClienteEntity> regs = Binder.Bind<IClienteEntity>(new ClienteBinder(), fac.RetornarClientes());
            return regs;
        }

        public static IClienteEntity ConsultarPorCodigo(int codigo)
        {
            ClienteSqlFactory fac = new ClienteSqlFactory();
            IList<IClienteEntity> regs = Binder.Bind<IClienteEntity>(new ClienteBinder(), fac.ConsultarPorCodigo(codigo));
            if (regs.Count > 0)
                return regs[0];

            return null;
        }

        public class ClienteBinder : IBindable<IClienteEntity>
        {
            public IClienteEntity Bind(DataRow source)
            {
                IClienteEntity cliente = new ClienteEntity();
                cliente.IdCliente = Convert.ToInt32(source["IdCliente"]);
                cliente.NomeCliente = source["Nome"].ToString();
                cliente.CPF = source["CPF"].ToString();
                cliente.Telefone = source["Telefone"].ToString();
                cliente.Estado = source["Estado"].ToString();
                cliente.CEP = source["CEP"].ToString();
                cliente.Cidade = source["Cidade"].ToString();
                cliente.Bairro = source["Bairro"].ToString();
                cliente.Logradouro = source["Logradouro"].ToString();
                cliente.Numero = Convert.ToInt32(source["Numero"]);
                cliente.Complemento = source["Complemento"].ToString();

                return cliente;
            }
        }
    }
}
