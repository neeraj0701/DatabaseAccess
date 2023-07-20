using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccess
{
    public class Program
    {
        public static void Main()
        {
            string conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(conString);
            //SqlCommand cmd = new SqlCommand("insert into new values(4,'ganesh');", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from new",conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //conn.Open();
            //Console.WriteLine("Connection Etablished");
            //int a = cmd.ExecuteNonQuery();
            //Console.WriteLine(a);
        }
    }
}


