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
    public class MovimentoSaidaSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public int Inserir(IMovimentoSaidaEntity saida)
        {
            DataTable dt = new DataTable();
            String insSQL = "INSERT INTO MOVIMENTOSAIDA(" +
                            " IDUSUARIO," +
                            " IDCLIENTE," +
                            " DATAMOVIMENTO) values (" +
                            "'" + saida.IdUsuario + "'," +
                            "'" + saida.IdCliente + "'," +
                            "'" + saida.DataMovimento + "'" +
                            ");" +
                            "SELECT MAX(IDMOVIMENTOSAIDA) FROM MOVIMENTOSAIDA;";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();

            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0][0]);

            return 0;
        }

        public DataTable ConsultarPorCodigo(int codigo)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM MOVIMENTOSAIDA WHERE IDMOVIMENTOSAIDA = " + codigo + " ORDER BY NOME";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable ConsultarPorData(string Data)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM MOVIMENTOSAIDA WHERE DATAMOVIMENTO LIKE '%" + Data + "%' ORDER BY IDMOVIMENTOSAIDA";
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
