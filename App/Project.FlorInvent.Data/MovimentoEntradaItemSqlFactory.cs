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
    public class MovimentoEntradaItemSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public void Inserir(IMovimentoEntradaItemEntity entradaItem)
        {
            DataTable dt = new DataTable();
            String insSQL = "INSERT INTO MOVIMENTOENTRADAITEM(" +
                            " IDMOVIMENTOENTRADA," +
                            " IDITEM," +
                            " IDDEPOSITO," +
                            " QUANTIDADE) values (" +
                            "" + entradaItem.IdMovimentoEntrada + "," +
                            "'" + entradaItem.IdItem + "'," +
                            "'" + entradaItem.IdDeposito + "'," +
                            "'" + entradaItem.QtdTotal + "'" +
                            ");";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarPorCodigoMovimentoEntrada(int codigo)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM MOVIMENTOENTRADAITEM WHERE IDMOVIMENTOENTRADA = " + codigo + " ORDER BY IDMOVIMENTOENTRADA";
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
