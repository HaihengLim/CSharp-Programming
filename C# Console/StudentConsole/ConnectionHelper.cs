using MySql.Data.MySqlClient;

namespace StudentConsole;

public class ConnectionHelper
{
    private static string server = "localhost";
    private static string database = "dbM6";
    private static string userId = "root";
    private static string password = "@@@@@@677677Heng";

    private static string ConnectionString = $"Server={server};Database={database};Uid={userId};pwd={password};";

     public MySqlConnection GetConnection(){
        MySqlConnection conn = new(ConnectionString);
        return conn;
     }
}
