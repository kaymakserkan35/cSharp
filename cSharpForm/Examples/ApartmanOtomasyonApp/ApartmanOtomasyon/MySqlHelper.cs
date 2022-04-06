using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace ApartmanOtomasyonDeneme
{

    class MySqlHelper
    {
        private string ConnectionString { get; set; }
        private MySqlConnection Connection { get; set; }

        public MySqlHelper()
        {
            ConnectionString = @"server = localhost; user id = root; password = nyks6957!; database = ApartmanOtomasyonDB";
            Connection = new MySqlConnection(ConnectionString);
        }



        public void ExecuteProc(string procName, params MySqlParameter[] ps)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.AddRange(ps);
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable GetTable(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, ConnectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
