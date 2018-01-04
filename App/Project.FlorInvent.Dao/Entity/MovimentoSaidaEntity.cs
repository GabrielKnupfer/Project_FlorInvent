using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FlorInvent.Interface;

namespace Project.FlorInvent.Dao.Entity
{
    public class MovimentoSaidaEntity : IMovimentoSaidaEntity
    {
        public int IdMovimentoSaida { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
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


        private IClienteEntity _cliente;
        public IClienteEntity cliente
        {
            get
            {
                if (this._cliente == null)
                    this._cliente = ClienteDao.ConsultarPorCodigo(this.IdCliente);

                return this._cliente;
            }
        }
    }
}
