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
    public class MovimentoSaidaItemSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public void Inserir(IMovimentoSaidaItemEntity saidaItem)
        {
            DataTable dt = new DataTable();
            String insSQL = "INSERT INTO MOVIMENTOSAIDAITEM(" +
                            " IDMOVIMENTOSAIDA," +
                            " IDITEM," +
                            " IDDEPOSITO," +
                            " QUANTIDADE) values (" +
                            "" + saidaItem.IdMovimentoSaida + "," +
                            "'" + saidaItem.IdItem + "'," +
                            "'" + saidaItem.IdDeposito + "'," +
                            "'" + saidaItem.QtdTotal + "'" +
                            ");";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarPorCodigoMovimentoSaida(int codigo)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM MOVIMENTOSAIDAITEM WHERE IDMOVIMENTOSAIDA = " + codigo + " ORDER BY IDMOVIMENTOSAIDA";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }
    }
}
