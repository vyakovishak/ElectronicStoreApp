
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Windows.UI.Xaml.Media.Imaging;

namespace ElectronicStoreApp
{
    public class DBConnection
    {

        DataTable mydt;
        SqlDataAdapter myadapter;
        
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
            catch (SqlException)
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

        public List<Dictionary<string, string>> Prodocts(String tabelName, String prodoctName, int pageNum)
        {
            int oldPage = 0;
            int newPage = 3;
            if (pageNum > 1 )
            {
                oldPage = newPage;
                newPage = newPage + 3;
            }

            bool dbStatus = ConnectToCustumerDatabase();
            string query;
            if (prodoctName == null)
            {
                 query = "select [customerReviewAverage], [customerReviewCount]," +
                "[longDescription], [manufacturer], [name], [regularPrice]  from dbo." + tabelName + " WHERE imgId BETWEEN "+ oldPage + " AND "+newPage+"";
            }
            else
            {
                 query =  "select TOP 3 [customerReviewAverage], [customerReviewCount]," +
                "[longDescription], [manufacturer], [name], [regularPrice]  from dbo." + tabelName + " WHERE imgId BETWEEN " + oldPage + " AND " + newPage + " AND  manufacturer='" + prodoctName + "'";
            }
            
            if (dbStatus == true)
            {
                List<Dictionary<string, string>> listOfProdocts = new List<Dictionary<string, string>>();
                SqlCommand createUserCD = new SqlCommand();
                createUserCD.CommandText = query;

                createUserCD.Connection = conn;
                SqlDataReader oReader = createUserCD.ExecuteReader();
                while (oReader.Read())
                {
                    var prodoct = new Dictionary<string, string>(){
                        {"customerReviewAverage", oReader["customerReviewAverage"].ToString()},
                        {"customerReviewCount", oReader["customerReviewCount"].ToString()},
                        {"longDescription", Base64Decode(oReader["longDescription"].ToString())},
                        {"manufacturer", oReader["manufacturer"].ToString()},
                        {"name", oReader["name"].ToString()},
                        {"regularPrice", oReader["regularPrice"].ToString()}
                    };
                    listOfProdocts.Add(prodoct);
                }
                return listOfProdocts;
            }           
            else
            {
                MessageBox.Show("We havning a issues connecting to database, please try again!!!");
                return null;
            }
            return null;

        }


        public Image testCall()
        {
            byte[] byteArry;
            Image img;
            bool dbStatus = ConnectToCustumerDatabase();
            string query;
            query = "select bImage  from dbo.Laptops WHERE imgId BETWEEN 1 AND 2 ";
            SqlCommand createUserCD = new SqlCommand();
            createUserCD.CommandText = query;

            createUserCD.Connection = conn;
            SqlDataReader oReader = createUserCD.ExecuteReader();
            while (oReader.Read())
            {
                byteArry = (byte[])oReader["bImage"];
                MemoryStream stream = new MemoryStream();
                stream.Write(byteArry,0, byteArry.Length);
                img = Image.FromStream(stream);
                return img;
            }
            return null;
        }
        public static string Base64Decode(string base64EncodedData)
        {
            byte[] textBytes = Encoding.Unicode.GetBytes(base64EncodedData);
            return Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, textBytes));
        }
    }

}