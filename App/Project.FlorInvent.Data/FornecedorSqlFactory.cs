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
    public class FornecedorSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public void IncluirFornecedor(IFornecedorEntity fornecedor)
        {
            String insSQL = "INSERT INTO FORNECEDOR(" +
                " NOME," +
                " CNPJ," +
                " TELEFONE," +
                " ESTADO," +
                " CEP," +
                " CIDADE," +
                " BAIRRO," +
                " LOGRADOURO," +
                " NUMERO," +
                " COMPLEMENTO) values (" +
                "'" + fornecedor.NomeFornecedor + "'," +
                "'" + fornecedor.CNPJ + "'," +
                "'" + fornecedor.Telefone + "'," +
                "'" + fornecedor.Estado + "'," +
                "'" + fornecedor.CEP + "'," +
                "'" + fornecedor.Cidade + "'," +
                "'" + fornecedor.Bairro + "'," +
                "'" + fornecedor.Logradouro + "'," +
                "'" + fornecedor.Numero + "'," +
                "'" + fornecedor.Complemento + "'" +
                ");";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarFornecedores(string filtro)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM FORNECEDOR WHERE NOME LIKE '%" + filtro + "%' OR CNPJ LIKE '%" + filtro + "%' ORDER BY NOME";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable ConsultarFornecedorById(int codigoForn)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM FORNECEDOR WHERE IDFORNECEDOR = " + codigoForn;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public void AlterarFornecedor(IFornecedorEntity fornecedor, int condigoForn)
        {
            String insSQL = "UPDATE FORNECEDOR SET " +
                " NOME = '" + fornecedor.NomeFornecedor + "'," +
                " CNPJ = '" + fornecedor.CNPJ + "'," +
                " TELEFONE = '" + fornecedor.Telefone + "'," +
                " ESTADO = '" + fornecedor.Estado + "'," +
                " CEP = '" + fornecedor.CEP + "'," +
                " CIDADE = '" + fornecedor.Cidade + "'," +
                " BAIRRO = '" + fornecedor.Bairro + "'," +
                " LOGRADOURO = '" + fornecedor.Logradouro + "'," +
                " NUMERO = '" + fornecedor.Numero + "'," +
                " COMPLEMENTO = '" + fornecedor.Complemento + "'" +
                " WHERE IDFORNECEDOR = " + condigoForn;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable RetornarFornecedores()
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM FORNECEDOR";
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

            String insSQL = "SELECT * FROM FORNECEDOR WHERE IDFORNECEDOR = " + codigo;
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
