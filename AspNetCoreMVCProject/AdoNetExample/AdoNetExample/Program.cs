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

            var sql = "insert into student(name, weight) values('Hayder', 400)";
            writeOperation(sql, connection);

            Console.WriteLine("Success");
        }
        
        static void writeOperation(string sql, SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            using SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = connection;

            command.ExecuteNonQuery();

        }
    }
}
