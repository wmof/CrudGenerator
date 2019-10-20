using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudGenerator
{
    class Conn
    {
        public MySqlConnection conexao;
        public DataSet conexaoDataSet;

        public Conn(ConnUser connUser)
        {
            script = "Server=" + connUser.Server + "; Database=" + connUser.Database + "; Uid=" + connUser.Uid + "; Pwd=" + connUser.Pwd + "";
        }
        string script;
        public MySqlConnection conect()
        {
            {
                conexaoDataSet = new DataSet();
                conexao = new MySqlConnection(script);
                try
                {
                    conexao.Open();
                    return conexao;
                }

                catch (Exception e)
                {
                    MessageBox.Show("Erro de conexão com o banco de dados" + e.Message);
                    conexao.Close();
                    return null;
                }
            }
        }

        public List<Table> selectTable()
        {
            Conn bd = new Conn(new ConnUser { Database = "u376420042_lybe", Uid = "u376420042_user", Server = "sql50.main-hosting.eu", Pwd = "8o|pD#g8" });
            DataSet dataset = new DataSet();
            List<Table> listTable = new List<Table>();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand("SELECT table_name FROM information_schema.tables WHERE table_type = 'base table'", bd.conect());
            adapter.Fill(dataset);

            foreach (DataRow linha in dataset.Tables[0].Rows)
            {
                Table Table = new Table();
                Table.Nome = Convert.ToString(linha["table_name"]);

                DataSet dataset2 = new DataSet();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                adapter2.SelectCommand = new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + Table.Nome + "'", bd.conect());
                adapter2.Fill(dataset2);
                List<Meta> listMeta = new List<Meta>();

                foreach (DataRow linha2 in dataset2.Tables[0].Rows)
                {
                    Meta meta = new Meta();
                    meta.Nome = Convert.ToString(linha2["COLUMN_NAME"]);
                    meta.Tipo = "";
                    listMeta.Add(meta);
                }

                Table.metaDados = listMeta;
                listTable.Add(Table);
            }
            return listTable;
        }
        public void teste()
        {
            var connection = new MySqlConnection(script);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO TABELA1 (CAMPO1) VALUES ('VALOR1')";
                command.ExecuteNonQuery();
                MessageBox.Show("teste OK");
            }
            catch
            {

            }
        }
    }
}