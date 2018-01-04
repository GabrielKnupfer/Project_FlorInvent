using System.Data;

namespace Project.FlorInvent.Dao
{
    public interface IBindable<TOBjectToBind>
    {
        /// <summary>
        /// Extrai os dados do xml e preenche uma Entidade
        /// </summary>
        /// <param name="source">Nó Xml retornado pela classe implementada</param>
        /// <returns>Entidade Preenchida</returns>
        TOBjectToBind Bind(DataRow source);
    }
}