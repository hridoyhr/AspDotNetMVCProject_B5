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

            var sql = "delete student where id = 12";
            writeOperation(sql, connection);

            Console.WriteLine("Successfully");
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
