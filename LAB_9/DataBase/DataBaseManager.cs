using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Text;

namespace DataBase
{
    public class DataBaseManager
    {
        private string connectionString;
        public BindingSource dbBindingSource { get; private set; }

        public DataBaseManager(string mdfFilePath)
        {
            connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={mdfFilePath};Integrated Security=True;";
            dbBindingSource = new BindingSource();
        }

        public void ShowData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", connection);
                DataTable dataTable = new DataTable();
                dataTable.TableName = "Users";
                adapter.Fill(dataTable);

                // Convert DataTable to string
                StringBuilder dataStringBuilder = new StringBuilder();

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        dataStringBuilder.Append($"{column.ColumnName}: {row[column]} ");
                    }
                    dataStringBuilder.AppendLine();
                }

                string dataString = dataStringBuilder.ToString();

                // Display data in a message box
                MessageBox.Show(dataString, "Users Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void WriteData(string name, string surname)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Users (name, surname) VALUES (@Name, @Surname)", connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);
                command.ExecuteNonQuery();
            }
        }
        // Additional methods can be added here to perform other database operations
    }
}
