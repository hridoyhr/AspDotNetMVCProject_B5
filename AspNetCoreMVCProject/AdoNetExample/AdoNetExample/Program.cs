using System;
using System.Data.SqlClient;

namespace AdoNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-CPJOTGU\\SQLEXPRESS;Database=AspnetCoreB5;User Id=aspnetCoreB5;Password=1234;";
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            using SqlCommand command = new SqlCommand();
            command.CommandText = "delete student where weight = 45";
            command.Connection = connection;
            command.ExecuteNonQuery();

            Console.WriteLine("Successfuly");
        }
    }
}
