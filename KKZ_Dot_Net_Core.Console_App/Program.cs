// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");


string connectionString = "Data Source=.;Initial Catalog=Dot_Net_Trainning_Batch_5;User ID=sa;Password=sa@123;";
Console.WriteLine("connection string: "+connectionString);
SqlConnection connection = new SqlConnection(connectionString);
Console.WriteLine("connection opening..");
connection.Open();
Console.WriteLine("connection opend");
string query = @"SELECT [BlogId]
      ,[BlogTitle]
      ,[BlogAuthor]
      ,[BlogContent]
      ,[Delete_Flag]
  FROM [dbo].[Tbl_Blog]";
SqlCommand cmd = new SqlCommand(query,connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt=new DataTable();
//adapter.Fill(dt);
SqlDataReader reader= cmd.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine(reader["BlogId"]);
    Console.WriteLine(reader["BlogTitle"]);
    Console.WriteLine(reader["BlogAuthor"]);
    Console.WriteLine(reader["BlogContent"]);

}

Console.WriteLine("connection closing..");
Console.WriteLine("connection closed");
//connection.Close();
//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);

//}

Console.ReadKey();