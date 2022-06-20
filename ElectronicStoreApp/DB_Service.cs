
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ElectronicStoreApp
{
    public class DBConnection
    {

        DataTable mydt;
        SqlDataAdapter myadapter;
        SqlCommand mycommand;
        SqlConnection conn;
        

        public void Disconnect()
        {
            conn.Close();
        }
        public bool ConnectToCustumerDatabase()
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StoreDB ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conn.Open();
                myadapter = new SqlDataAdapter();
                mydt = new DataTable();
                Console.WriteLine("i open");
                return true;
            }
            catch (SqlException e)
            {   
                
                conn = null;
                return false;
            }
        }

        public void UpdateClientInfo()
        {

        }

        public bool Register(string FirstName,string LastName, string Username, string Password, 
                             string Address,  string State,    string Zip)
        {
            bool dbStatus = ConnectToCustumerDatabase();
            if (dbStatus == true)
            {
                
                SqlCommand createUserCD = new SqlCommand();
                createUserCD.CommandText = "Insert into Customer (Username, Password, FirstName, LastName, Address, State, Zip) " +
                                           "Values (@UN, @PW, @FN, @LN, @ADD, @S, @Z)";
                createUserCD.Connection = conn;
                createUserCD.Parameters.AddWithValue("@UN", Username);
                createUserCD.Parameters.AddWithValue("@PW", Password);
                createUserCD.Parameters.AddWithValue("@FN", FirstName);
                createUserCD.Parameters.AddWithValue("@LN", LastName);
                createUserCD.Parameters.AddWithValue("@ADD", Address);
                createUserCD.Parameters.AddWithValue("@S", State);
                createUserCD.Parameters.AddWithValue("@Z", Zip);
                createUserCD.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            else
            {
                MessageBox.Show("We havning a issues connecting to database, please try again!!!");
                return false;
            }
        }
        
        public bool Login(string Username, string Password)
        {
            bool dbStatus = ConnectToCustumerDatabase();
            if (dbStatus == true)
            {
                SqlCommand createUserCD = new SqlCommand();
                createUserCD.CommandText = "SELECT Username, Password FROM dbo.Customer where Username=@UN AND Password=@PW";
                createUserCD.Connection = conn;
                createUserCD.Parameters.AddWithValue("@UN", Username);
                createUserCD.Parameters.AddWithValue("@PW",  Password);
                SqlDataReader oReader = createUserCD.ExecuteReader();
                if (oReader.Read())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Wrong password or username!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("We havning a issues connecting to database, please try again!!!");
                return false;
            }
        }

    }

}