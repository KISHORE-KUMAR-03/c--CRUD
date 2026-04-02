using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        SqlConnection con = new SqlConnection("your_connection_string");
        con.Open();

        // INSERT
        SqlCommand insert = new SqlCommand(
            "INSERT INTO Student(Name, Age) VALUES(@name, @age)", con);
        insert.Parameters.AddWithValue("@name", "Kishore");
        insert.Parameters.AddWithValue("@age", 20);
        insert.ExecuteNonQuery();

        // UPDATE
        SqlCommand update = new SqlCommand(
            "UPDATE Student SET Age=@age WHERE Name=@name", con);
        update.Parameters.AddWithValue("@name", "Kishore");
        update.Parameters.AddWithValue("@age", 21);
        update.ExecuteNonQuery();

        // DELETE
        SqlCommand delete = new SqlCommand(
            "DELETE FROM Student WHERE Name=@name", con);
        delete.Parameters.AddWithValue("@name", "Kishore");
        delete.ExecuteNonQuery();

        Console.WriteLine("CRUD Operations Done");
        con.Close();
    }
}
