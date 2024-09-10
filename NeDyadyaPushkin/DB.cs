using ConsoleApp47;
using MySqlConnector;


MySqlConnection mySqlConnection;
MySqlConnectionStringBuilder sb =
    new MySqlConnectionStringBuilder();
sb.Server = "192.168.200.13";
sb.UserID = "student";
sb.Password = "student";
sb.Database = "veryprostoiorm";
sb.CharacterSet = "utf8mb4";
sb.ConnectionTimeout = 5;
mySqlConnection = new MySqlConnection(sb.ToString());

try
{
    mySqlConnection.Open();
}
catch (MySqlException ex)
{
    Console.WriteLine($"{ex.Number}: {ex.Message}");
    return;
}

MysqlTools.SetConnection(mySqlConnection);

DataBase dataBase = new DataBase();

mySqlConnection.Close();
