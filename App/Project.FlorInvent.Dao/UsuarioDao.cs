using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.FlorInvent.Interface;
using Project.FlorInvent.Dao.Entity;
using Project.FlorInvent.Data;
using Project.FlorInvent.Interface.Enum;

namespace Project.FlorInvent.Dao
{
    public class UsuarioDao
    {
        public static void IncluirUsuario(IUsuarioEntity usuario)
        {
            UsuarioSqlFactory fac = new UsuarioSqlFactory();
            fac.IncluirUsuario(usuario);
        }

        public static IList<IUsuarioEntity> ConsultarUsuarios(string filtro)
        {
            UsuarioSqlFactory fac = new UsuarioSqlFactory();
            IList<IUsuarioEntity> regs = Binder.Bind<IUsuarioEntity>(new UsuarioBinder(), fac.ConsultarUsuarios(filtro));
            return regs;
        }

        public static IList<IUsuarioEntity> ConsultarUsuarioPorCodigo(int codigoUsuario)
        {
            UsuarioSqlFactory fac = new UsuarioSqlFactory();
            IList<IUsuarioEntity> regs = Binder.Bind<IUsuarioEntity>(new UsuarioBinder(), fac.ConsultarUsuarioPorCodigo(codigoUsuario));
            return regs;
        }

        public static void AlterarUsuario(IUsuarioEntity usuario, int codigoUsuario)
        {
            UsuarioSqlFactory fac = new UsuarioSqlFactory();
            fac.AlterarUsuario(usuario, codigoUsuario);
        }

        public static IList<IUsuarioEntity> VerificarUsuario (string login, string senha)
        {
            UsuarioSqlFactory fac = new UsuarioSqlFactory();
            IList<IUsuarioEntity> regs = Binder.Bind<IUsuarioEntity>(new UsuarioBinder(), fac.VerificarUsuario(login, senha));
            return regs;
        }

        public static IUsuarioEntity ConsultarPorCodigo(int codigo)
        {
            UsuarioSqlFactory fac = new UsuarioSqlFactory();
            IList<IUsuarioEntity> regs = Binder.Bind<IUsuarioEntity>(new UsuarioBinder(), fac.ConsultarPorCodigo(codigo));
            if (regs.Count > 0)
                return regs[0];

            return null;
        }

        public class UsuarioBinder : IBindable<IUsuarioEntity>
        {
            public IUsuarioEntity Bind(DataRow source)
            {
                IUsuarioEntity item = new UsuarioEntity();
                item.IdUsuario = Convert.ToInt32(source["IdUsuario"]);
                item.NomeUsuario = source["Nome"].ToString();
                item.TipoUsuario = (TipoUsuarioEnum)Convert.ToInt32(source["TipoUsuario"]);
                item.Senha = source["Senha"].ToString();

                return item;
            }
        }

    }
}
