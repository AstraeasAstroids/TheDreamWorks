using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDreamWorks
{
    internal class DBManager
    {
        private void CreateDatabase()
        {
            string dbPath = Path.Combine(Application.StartupPath, "DemoDatabase.sqlite");
            if (!File.Exists(dbPath))
            {
                MessageBox.Show("No database yet");
                SQLiteConnection.CreateFile(dbPath);
                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();
                    string sql = "CREATE TABLE Members (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Chore TEXT, Date TEXT)";
                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Database already created");
            }
        }

        private void AddRecord(string name, string chore, DateTime date )
        {
            using (var connection = new SQLiteConnection("Data Source =DemoDatabase.sqlite;Version=3"))
            {
                connection.Open();
                string sql = "INSERT INTO Members (Name, Chore, Date) VALUES (@Name, @Chore, @Date)";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Chore", chore);
                command.Parameters.AddWithValue("@Date", date.ToString());
                command.ExecuteNonQuery();
            }
        }

       /* private void LoadData()
       {
            using (var connection = new SQLiteConnection("Data Source=DemoDatabase.sqlite;Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Students";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
           }
        }
       */

       /* private void UpdateRecord(int id, string name, int age)
        {
            using (var connection = new SQLiteConnection("Data Source=DemoDatabase.sqlite;Version=3;"))
            {
                connection.Open();
                string sql = "UPDATE Students SET Name = @Name, Age = @Age WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Age", age);
                command.ExecuteNonQuery();
            }
       }*/

        /*private void DeleteRecord(int id)
        {
            using (var connection = new SQLiteConnection("Data Source=DemoDatabase.sqlite;Version=3;"))
            {
                connection.Open();
                string sql = "DELETE FROM Students WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }*/

       
    }
}
