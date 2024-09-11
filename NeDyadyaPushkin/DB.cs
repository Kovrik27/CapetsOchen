using CapetsOchen;
using MySqlConnector;
using System.Windows;

public class DB
{
    MySqlConnection mySqlConnection;

    private DB()
    {
        MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
        sb.Server = "192.168.200.13";
        sb.UserID = "student";
        sb.Password = "student";
        sb.Database = "veryprostoiorm";
        sb.CharacterSet = "utf8mb4";
        sb.ConnectionTimeout = 5;
        mySqlConnection = new MySqlConnection(sb.ToString());

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


    

