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
    public class FuncionarioSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public void IncluirFuncionario(IFuncionarioEntity funcionario)
        {
            String insSQL = "INSERT INTO FUNCIONARIO(" +
                " NOME," +
                " DATANASCIMENTO," +
                " SEXO," +
                " CPF," +
                " TELEFONE," +
                " ESTADO," +
                " CEP," +
                " CIDADE," +
                " BAIRRO," +
                " LOGRADOURO," +
                " NUMERO," +
                " COMPLEMENTO," +
                " DATAADMISSAO) values (" +
                "'" + funcionario.NomeFuncionario + "'," +
                "'" + funcionario.DataNascimento + "'," +
                "" + (int)funcionario.Sexo + "," +
                "'" + funcionario.CPF + "'," +
                "'" + funcionario.Telefone + "'," +
                "'" + funcionario.Estado + "'," +
                "'" + funcionario.Cep + "'," +
                "'" + funcionario.Cidade + "'," +
                "'" + funcionario.Bairro + "'," +
                "'" + funcionario.Logradouro + "'," +
                "'" + funcionario.Numero + "'," +
                "'" + funcionario.Complemento + "'," +
                "'" + funcionario.DataAdmissao + "'" +
                ");";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarFuncionarios(string filtro)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM FUNCIONARIO WHERE NOME LIKE '%" + filtro + "%' OR CPF LIKE '%" + filtro + "%' ORDER BY NOME";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable ConsultarFuncionarioById(int codigoFunc)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM FUNCIONARIO WHERE IDFUNCIONARIO = " + codigoFunc;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public void AlterarFuncionario(IFuncionarioEntity funcionario, int condigoFunc)
        {
            String insSQL = "UPDATE FUNCIONARIO SET " +
                " NOME = '" + funcionario.NomeFuncionario + "'," +
                " DATANASCIMENTO = '" + funcionario.DataNascimento + "'," +
                " SEXO = " + (int) funcionario.Sexo + "," +
                " CPF = '" + funcionario.CPF + "'," +
                " TELEFONE = '" + funcionario.Telefone + "'," +
                " ESTADO = '" + funcionario.Estado + "'," +
                " CEP = '" + funcionario.Cep + "'," +
                " CIDADE = '" + funcionario.Cidade + "'," +
                " BAIRRO = '" + funcionario.Bairro + "'," +
                " LOGRADOURO = '" + funcionario.Logradouro + "'," +
                " NUMERO = '" + funcionario.Numero + "'," +
                " COMPLEMENTO = '" + funcionario.Complemento + "'," +
                " DATAADMISSAO = '" + funcionario.DataAdmissao + "'" +
                " WHERE IDFUNCIONARIO = " + condigoFunc;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        //public SqlConnection abrirConexao()
        //{


        //  try
        //  {
        //    cn.Open();
        //    return cn;
        //  }
        //  catch (Exception e)
        //  {
        //    throw e;
        //  }
        //}

        //public void fecharConexao(SqlConnection cn)
        //{
        //    try
        //    {
        //        cn.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public DataTable executeQuery(string sql)
        //{
        //    SqlCommand sqlComm = new SqlCommand(sql, abrirConexao());

        //    sqlComm.ExecuteNonQuery();

        //    SqlDataAdapter da = new SqlDataAdapter(sqlComm);

        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    return dt;
        //}

        //public string executeQueryComStringRetorno(string sql)
        //{
        //    string dado;

        //    SqlCommand sqlComm = new SqlCommand(sql, abrirConexao());

        //    sqlComm.ExecuteNonQuery();

        //    SqlDataAdapter da = new SqlDataAdapter(sqlComm);

        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    dado = dt.Rows[0][0].ToString();

        //    return dado;
        //}
    }
}

