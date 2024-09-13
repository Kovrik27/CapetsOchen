using ConsoleApp47;
using MySqlConnector;
using System.Windows;

public class DataBase
{
    static readonly DataBase Instance = new DataBase();

    public static DataBase Get() => Instance;

    MySqlConnection mySqlConnection;
    private DataBase()
    {
        MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
        sb.Server = "192.168.200.13";
        sb.UserID = "student";
        sb.Password = "student";
        sb.Database = "veryprostoiorm";
        sb.CharacterSet = "utf8mb4";
        sb.ConnectionTimeout = 5;
        mySqlConnection = new MySqlConnection(sb.ToString());
        MysqlTools.SetConnection(mySqlConnection);
        OpenConnection();
    }

    private bool OpenConnection()
    {
        try
        {
            mySqlConnection.Open();
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    public void CloseConnection()
    {
        try
        {
            mySqlConnection.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}