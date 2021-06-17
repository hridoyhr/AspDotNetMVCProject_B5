using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AdoNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-CPJOTGU\\SQLEXPRESS;Database=AspnetCoreB5;User Id=aspnetCoreB5;Password=1234;";

            //var sql = "insert into student (name, weight) values('jalaluddin', 23.09)";
            //WriteOperation(sql, connection);

            var sql2 = "select * from student";
            var students = readOperation(sql2, connection);

            foreach(var student in students)
            {
                Console.WriteLine($"Id = {student.Id}, Name = {student.Name}");
            }
        }

        static void WriteOperation(string sql, SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            using SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = connection;

            command.ExecuteNonQuery();
        }
        
        public class Student
        { 
            public int Id { get; set; }
            public string Name { get; set; }
            //public decimal Weight { get; set; }
        }

        static IList<Student> readOperation(string sql, SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            using SqlCommand command = new SqlCommand(sql, connection);

            var reader = command.ExecuteReader();

            var students = new List<Student>();
            while(reader.Read())
            {
                var student = new Student();

                student.Id = (int)reader["Id"];
                student.Name = (string)reader["Name"];
                //student.Weight = (decimal)reader["Weight"];

                students.Add(student);
            }

            return students;
        }
    }
}
