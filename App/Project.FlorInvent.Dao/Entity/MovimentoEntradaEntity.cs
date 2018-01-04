using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface;

namespace Project.FlorInvent.Dao.Entity
{
    public class MovimentoEntradaEntity : IMovimentoEntradaEntity
    {
        public int IdMovimentacaoEntrada { get; set; }
        public int IdUsuario { get; set; }
        public int IdFornecedor { get; set; }
        public DateTime DataMovimento { get; set; }

        private IUsuarioEntity _usuario;
        public IUsuarioEntity usuario
        {
            get
            {
                if (this._usuario == null)
                    this._usuario = UsuarioDao.ConsultarPorCodigo(this.IdUsuario);

                return this._usuario;
            }
        }

        private IFornecedorEntity _fornecedor;
        public IFornecedorEntity fornecedor
        {
            get
            {
                if (this._fornecedor == null)
                    this._fornecedor = FornecedorDao.ConsultarPorCodigo(this.IdFornecedor);

                return this._fornecedor;
            }
        }
    }
}
