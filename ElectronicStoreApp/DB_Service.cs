
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
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

        public List<Dictionary<string, object>> Prodocts(String tabelName, String prodoctName, int pageNum)
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
                 "[longDescription], [manufacturer], [name], [regularPrice], [bImage]  from dbo." + tabelName + " WHERE imgId BETWEEN "+ oldPage + " AND "+newPage+"";
            }
            else
            {
                 query =  "select TOP 3 [customerReviewAverage], [customerReviewCount]," +
                 "[longDescription], [manufacturer], [name], [regularPrice], [bImage] from dbo." + tabelName + " WHERE imgId BETWEEN " + oldPage + " AND " + newPage + " AND  manufacturer='" + prodoctName + "'";
            }
            
            if (dbStatus == true)
            {
                List<Dictionary<string, object>> listOfProdocts = new List<Dictionary<string, object>>();
                SqlCommand createUserCD = new SqlCommand();
                createUserCD.CommandText = query;

                createUserCD.Connection = conn;
                SqlDataReader oReader = createUserCD.ExecuteReader();
                while (oReader.Read())
                {
                    byte[] bytes = (byte[])oReader["bImage"];
                    MemoryStream ms = new MemoryStream();
                    ms.Write(bytes,0,bytes.Length);
                    Image img = Image.FromStream(ms);
                    var prodoct = new Dictionary<string, object>(){
                        {"customerReviewAverage", oReader["customerReviewAverage"].ToString()},
                        {"customerReviewCount", oReader["customerReviewCount"].ToString()},
                        {"longDescription", Base64Decode(oReader["longDescription"].ToString())},
                        {"manufacturer", oReader["manufacturer"].ToString()},
                        {"name", oReader["name"].ToString()},
                        {"regularPrice", oReader["regularPrice"].ToString()},
                        {"bImage", img}
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


        public void fixData()
        {
            byte[] byteArry;
            bool dbStatus = ConnectToCustumerDatabase();
            string query;
            query = "select image from dbo.Laptops";
            SqlCommand createUserCD = new SqlCommand();
            createUserCD.CommandText = query;

            createUserCD.Connection = conn;
            SqlDataReader oReader = createUserCD.ExecuteReader();
            oReader.Read();
            int num = 0;

            while (oReader.Read())

            {
                System.Threading.Thread.Sleep(5000);

                byte[] m_Bytes = ReadToEnd((new MemoryStream(new WebClient().DownloadData(oReader["image"].ToString()))));
                
                updateData(m_Bytes, num);
                num = num + 1;
            }
            
        }

        public void updateData(byte[] m_Bytes, int num)
        {
            
            SqlCommand createUserCD = new SqlCommand();
            SqlConnection conn1 = new SqlConnection();
            conn1.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StoreDB ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn1.Open();
            createUserCD.Connection = conn1;
            createUserCD.CommandText = "UPDATE dbo.Laptops SET bImage=@B WHERE imgId=@I";
            createUserCD.Parameters.AddWithValue("@B", m_Bytes);
            createUserCD.Parameters.AddWithValue("@I", num);
            createUserCD.ExecuteNonQuery();
        }
        public static string Base64Decode(string base64EncodedData)
        {
            byte[] textBytes = Encoding.Unicode.GetBytes(base64EncodedData);
            return Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, textBytes));
        }

        public static byte[] ReadToEnd(System.IO.Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }
    }

}