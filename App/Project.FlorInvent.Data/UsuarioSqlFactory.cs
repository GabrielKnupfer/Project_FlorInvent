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
    public class UsuarioSqlFactory
    {
        //private string conec = "Data Source=STIFF-PC;Initial Catalog=SISFLOR;Integrated Security=True";
        //private string conec = "Data Source=LOCALHOST;Initial Catalog=SISFLOR;Integrated Security=True";
        private string conec = ConfigurationSettings.AppSettings["pathDataBase"];

        public void IncluirUsuario(IUsuarioEntity usuario)
        {
            String insSQL = "INSERT INTO USUARIO(" +
                " NOME," +
                " TIPOUSUARIO," +
                " SENHA) values (" +
                "'" + usuario.NomeUsuario + "'," +
                "'" + (int)usuario.TipoUsuario + "'," +
                "'" + usuario.Senha + "'" +
                ");";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable ConsultarUsuarios(string filtro)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM USUARIO WHERE NOME LIKE '%" + filtro + "%' OR IDUSUARIO LIKE '%" + filtro + "%' ORDER BY NOME";
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public DataTable ConsultarUsuarioPorCodigo(int codigoUsuario)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM USUARIO WHERE IDUSUARIO = " + codigoUsuario;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public void AlterarUsuario(IUsuarioEntity usuario, int condigoUsuario)
        {
            String insSQL = "UPDATE USUARIO SET " +
                " NOME = '" + usuario.NomeUsuario + "'," +
                " SENHA = '" + usuario.Senha + "'," +
                " TIPOUSUARIO = '" + (int)usuario.TipoUsuario + "'" +
                " WHERE IDUSUARIO = " + condigoUsuario;
            String strConn = conec;
            SQLiteConnection conn = new SQLiteConnection(conec);
            conn.Open();
            SQLiteCommand sqlComm = new SQLiteCommand(insSQL, conn);
            sqlComm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public DataTable VerificarUsuario(string login, string senha)
        {
            DataTable dt = new DataTable();

            String insSQL = "SELECT * FROM USUARIO WHERE NOME ='" + login + "' AND SENHA = '" + senha + "'";
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

            String insSQL = "SELECT * FROM USUARIO WHERE IDUSUARIO = " + codigo;
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
