using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace dbwrite
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string connetionString = @"Data Source=LAPTOP-6C1MUBKA\SQLEXPRESS;Initial Catalog=patsdb;Integrated Security=True;";
              SqlConnection cnn = new SqlConnection(connetionString);
              cnn.Open();
              SqlCommand cmd = new SqlCommand("INSERT INTO interns(internid, firstname VALUES(@0, @1)",cnn);
              Console.WriteLine("ID:");

              var identifier = Console.ReadLine();
              Console.WriteLine("name:");
              var name = Console.ReadLine();
              cmd.Parameters.Add(new SqlParameter("0", identifier));
              cmd.Parameters.Add(new SqlParameter("1", name));
              *
            try
            {
                string connetionString = @"Data Source=LAPTOP-6C1MUBKA\SQLEXPRESS;Initial Catalog=patsdb;Integrated Security=True;";
                SqlConnection cnn = new SqlConnection(connetionString);

                /*  Console.WriteLine("trying to connect");
                  using (cnn)
                  {
                      cnn.Open();
                      Console.WriteLine("done");
                  } 
                Console.Write("Inserting a new row into table, press any key to continue...");
               // Console.ReadKey(true);

                StringBuilder sb = new StringBuilder();
                
                sb.Clear();
                sb.Append("INSERT interns (internid, firstname) ");
                sb.Append("VALUES(@internID, @firstname); ");
               string   sql = sb.ToString();
                SqlCommand command = new SqlCommand(sql, cnn);
               
                    command.Parameters.AddWithValue("@internID", "3");
                    command.Parameters.AddWithValue("@firstname", "john");
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected + " row(s) inserted");
                

             //   SqlCommand cmd = new SqlCommand("INSERT INTO interns(internid, firstname)  VALUES(@intern, @firstname)", cnn);

             
            }
            catch
            {
                Console.WriteLine("error");
            }
            */
            // int id = Console.ReadLine();

            Console.WriteLine("ID:");

            var identifier = Console.ReadLine();
            Console.WriteLine("name:");
            var name = Console.ReadLine();

            string connetionString = @"Data Source=LAPTOP-6C1MUBKA\SQLEXPRESS;Initial Catalog=patsdb;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connetionString);
            string query = "INSERT interns (internID, firstname) VALUES (@internID, @firstname)";
            SqlCommand cmd = new SqlCommand(query, cnn);

            cmd.Parameters.AddWithValue("@internID", identifier);
            cmd.Parameters.AddWithValue("@firstname", name);
            //  SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            // cmd.CommandText = "INSERT interns (internID, firstname) VALUES (3, 'john')";
            // cmd.CommandText = "INSERT interns (internID, firstname) VALUES (@internID, '@firstname')";
            //  cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
}
