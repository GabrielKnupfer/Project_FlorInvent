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
    public class MovimentoEntradaSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public int Inserir(IMovimentoEntradaEntity entrada)
        {
            DataTable dt = new DataTable();
            String insSQL = "INSERT INTO MOVIMENTOENTRADA(" +
                            " IDUSUARIO," +
                            " IDFORNECEDOR," +
                            " DATAMOVIMENTO) values (" +
                            "'" + entrada.IdUsuario + "'," +
                            "'" + entrada.IdFornecedor + "'," +
                            "'" + entrada.DataMovimento + "'" +
                            ");" +
                            "SELECT MAX(IDMOVIMENTOENTRADA) FROM MOVIMENTOENTRADA;";
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

            String insSQL = "SELECT * FROM MOVIMENTOENTRADA WHERE IDMOVIMENTOENTRADA = " + codigo + " ORDER BY NOME";
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

            String insSQL = "SELECT * FROM MOVIMENTOENTRADA WHERE DATAMOVIMENTO LIKE '%" + Data + "%' ORDER BY IDMOVIMENTOENTRADA";
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
