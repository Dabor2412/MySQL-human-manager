using MySql.Data.MySqlClient;

namespace HumanManager
{
    internal class Databasemanager
    {
        public MySqlConnection getConnection()
        {
            string connectionString = "SERVER=localhost;DATABASE=menschendatenbank;UID=root;PASSWORD=uyJBgXdd5nMAT6qh;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void closeConnection(MySqlConnection connection)
        {
            connection.Close();
        }
    }
}
