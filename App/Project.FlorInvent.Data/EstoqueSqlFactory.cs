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
    public class EstoqueSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public void Inserir(IEstoqueEntity estoque)
        {

            String insSQL = "INSERT INTO ESTOQUE (IDITEM, QUANTIDADETOTAL, QUANTIDADEUTILIZADA) VALUES (" +
                            "'" + estoque.IdItem + "', " +
                            "'" + estoque.QuantidadeTotal + "', " +
                            "'" + estoque.QuantidadeUtilizada + "');";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarPorIdItem(int IdItem)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM ESTOQUE WHERE IDITEM = " + IdItem;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable ConsultarEstoque(string filtro)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM ESTOQUE WHERE IDITEM LIKE '%" + filtro + "%'";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public void Atualizar(IEstoqueEntity estoque, int codigoItem)
        {
            String insSQL = "UPDATE ESTOQUE SET " +
                " QUANTIDADETOTAL = " + estoque.QuantidadeTotal +
                " WHERE IDITEM = " + codigoItem;
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
