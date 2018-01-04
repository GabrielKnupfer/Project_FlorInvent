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
    public class TipoItemSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public void IncluirTipoItem(ITipoItemEntity tipoitem)
        {
            String insSQL = "INSERT INTO TIPOITEM(" +
                " DESCRICAO) values (" +
                "'" + tipoitem.Descricao + "'" +
                ");";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarTipoItemPorCodigo(int codigoTipoItem)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM TIPOITEM WHERE IDTIPOITEM = " + codigoTipoItem;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable RetornarTipoItem()
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM TIPOITEM";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable ConsultarTiposItem(string filtro)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM TIPOITEM WHERE DESCRICAO LIKE '%" + filtro + "%' ORDER BY DESCRICAO";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public void AlterarTipoItem(ITipoItemEntity tipoItem, int codigoTipoItem)
        {
            String insSQL = "UPDATE TIPOITEM SET " +
                " DESCRICAO = '" + tipoItem.Descricao + "'" +
                " WHERE IDTIPOITEM = " + codigoTipoItem;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public void ExcluirTipoItem(int codigo)
        {
            String insSQL = "DELETE FROM TIPOITEM WHERE IDTIPOITEM = " + codigo;
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
