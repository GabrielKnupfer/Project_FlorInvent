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
    public class DepositoSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public void IncluirDeposito(IDepositoEntity deposito)
        {
            String insSQL = "INSERT INTO DEPOSITO(" +
                " DESCRICAO," +
                " ESTADO," +
                " CEP," +
                " CIDADE," +
                " BAIRRO," +
                " LOGRADOURO," +
                " NUMERO," +
                " COMPLEMENTO) values (" +
                "'" + deposito.DescricaoDeposito + "'," +
                "'" + deposito.Estado + "'," +
                "'" + deposito.CEP + "'," +
                "'" + deposito.Cidade + "'," +
                "'" + deposito.Bairro + "'," +
                "'" + deposito.Logradouro + "'," +
                "'" + deposito.Numero + "'," +
                "'" + deposito.Complemento + "'" +
                ");";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarDepositos(string filtro)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM DEPOSITO WHERE DESCRICAO LIKE '%" + filtro + "%' OR IDDEPOSITO LIKE '%" + filtro + "%' ORDER BY DESCRICAO";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable ConsultarDepositoById(int codigoDepo)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM DEPOSITO WHERE IDDEPOSITO = " + codigoDepo;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public void AlterarDeposito(IDepositoEntity deposito, int codigoDepo)
        {
            String insSQL = "UPDATE DEPOSITO SET " +
                " NOME = '" + deposito.DescricaoDeposito + "'," +
                " ESTADO = '" + deposito.Estado + "'," +
                " CEP = '" + deposito.CEP + "'," +
                " CIDADE = '" + deposito.Cidade + "'," +
                " BAIRRO = '" + deposito.Bairro + "'," +
                " LOGRADOURO = '" + deposito.Logradouro + "'," +
                " NUMERO = '" + deposito.Numero + "'," +
                " COMPLEMENTO = '" + deposito.Complemento + "'" +
                " WHERE IDDEPOSITO = " + codigoDepo;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarPorCodigo(int codigo)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM DEPOSITO WHERE IDDEPOSITO = " + codigo;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public void ExcluirDeposito(int codigo)
        {
            String insSQL = "DELETE FROM DEPOSITO WHERE IDDEPOSITO = " + codigo;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable RetornarDepositos()
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM DEPOSITO";
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
