using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Prj_NSA2
{
    class Conexao
    {
        //Declarando o objeto de conexão passando como parâmetro a string de conexão
        private static string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = \Prj_NSA2\Prj_NSA2\bin\Debug\Bd_Escola.mdb";
        //Provider=Microsoft.Ace.OLEDB.12.0;Data Source = BD_Escola.mdb
        //app.config: Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Prj_NSA2\Prj_NSA2\bin\Debug    


        // variável que representa a conexão com o banco
        private static OleDbConnection conn = null;


        //***********************************


        // método que permite obter a conexão
        public static OleDbConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new OleDbConnection(connString);

            // verifica se a conexão foi feita ocm sucesso
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (Exception)
            {
                conn = null;
                System.Windows.Forms.MessageBox.Show("Conexão não estabelecida!!");
            }

            return conn;

        }

        public static void fecharConexao() // fecha a conexão
        {
            if (conn != null)
            {
                conn.Close();
            }

        }


    }
}
