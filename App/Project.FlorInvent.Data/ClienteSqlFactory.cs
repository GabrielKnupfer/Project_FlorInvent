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
    public class ClienteSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public void IncluirCliente(IClienteEntity cliente)
        {
            String insSQL = "INSERT INTO CLIENTE(" +
                " NOME," +
                " CPF," +
                " TELEFONE," +
                " ESTADO," +
                " CEP," +
                " CIDADE," +
                " BAIRRO," +
                " LOGRADOURO," +
                " NUMERO," +
                " COMPLEMENTO) values (" +
                "'" + cliente.NomeCliente + "'," +
                "'" + cliente.CPF + "'," +
                "'" + cliente.Telefone + "'," +
                "'" + cliente.Estado + "'," +
                "'" + cliente.CEP + "'," +
                "'" + cliente.Cidade + "'," +
                "'" + cliente.Bairro + "'," +
                "'" + cliente.Logradouro + "'," +
                "'" + cliente.Numero + "'," +
                "'" + cliente.Complemento + "'" +
                ");";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarClientes(string filtro)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM CLIENTE WHERE NOME LIKE '%" + filtro + "%' OR CPF LIKE '%" + filtro + "%' ORDER BY NOME";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable ConsultarClienteById(int codigo)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM CLIENTE WHERE IDCLIENTE = " + codigo;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public void AlterarCliente(IClienteEntity cliente, int codigoClie)
        {
            String insSQL = "UPDATE CLIENTE SET " +
                " NOME = '" + cliente.NomeCliente + "'," +
                " CPF = '" + cliente.CPF + "'," +
                " TELEFONE = '" + cliente.Telefone + "'," +
                " ESTADO = '" + cliente.Estado + "'," +
                " CEP = '" + cliente.CEP + "'," +
                " CIDADE = '" + cliente.Cidade + "'," +
                " BAIRRO = '" + cliente.Bairro + "'," +
                " LOGRADOURO = '" + cliente.Logradouro + "'," +
                " NUMERO = '" + cliente.Numero + "'," +
                " COMPLEMENTO = '" + cliente.Complemento + "'" +
                " WHERE IDCLIENTE = " + codigoClie;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable RetornarClientes()
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM CLIENTE";
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

            String insSQL = "SELECT * FROM CLIENTE WHERE IDCLIENTE = " + codigo;
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
