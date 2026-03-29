using MongoDB.Driver;

namespace WinFormsApp1;

public class ConnectionHelper
{
    private const string connectionString = "mongodb://localhost:27017";

    public MongoClient GetConnection(){
        MongoClient conn = new(connectionString);
        return conn;
    }
}
