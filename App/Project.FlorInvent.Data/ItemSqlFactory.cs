using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project.FlorInvent.Interface;
using System.Configuration;
using System.Data.SQLite;

namespace Project.FlorInvent.Data
{
    public class ItemSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public void IncluirItem(IItemEntity item)
        {
            String insSQL = "INSERT INTO ITEM(" +
                " NOME," +
                " DESCRICAOITEM," +
                " IDTIPOITEM," +
                " IDDEPOSITO) values (" +
                "'" + item.Nome + "'," +
                "'" + item.DescricaoItem + "'," +
                "'" + item.IdTipoItem + "'," +
                "'" + item.IdDeposito + "'" +
                ");";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarItens(string filtro)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM ITEM WHERE NOME LIKE '%" + filtro + "%' OR IDITEM LIKE '%" + filtro + "%' ORDER BY NOME";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable ConsultarById(int codigo)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM ITEM WHERE IDITEM = " + codigo + " ORDER BY NOME";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable ConsultarPorCodigo(int codigo)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM ITEM WHERE IDITEM = " + codigo;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public void AlterarItem(IItemEntity item, int codigoItem)
        {
            String insSQL = "UPDATE ITEM SET " +
                " NOME = '" + item.Nome + "'," +
                " DESCRICAOITEM = '" + item.DescricaoItem + "'," +
                " IDTIPOITEM = '" + item.IdTipoItem + "'," +
                " IDDEPOSITO = '" + item.IdDeposito + "'" +
                " WHERE IDITEM = " + codigoItem;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public void ExcluirItem(int codigo)
        {
            String insSQL = "DELETE FROM ITEM WHERE IDITEM = " + codigo;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }
    }
}
