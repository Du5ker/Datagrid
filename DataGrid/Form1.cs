using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            string connectionString = "Data Source=database.sqlite;Version=3;";
            string query = "SELECT * FROM MyTable LIMIT 1;"; // Замените "YourTableName" на имя вашей таблицы

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No data found in the table.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowSecondRow();
        }

        private void ShowSecondRow()
        {
            string connectionString = "Data Source=database.sqlite;Version=3;";
            string query = "SELECT * FROM MyTable LIMIT 1 OFFSET 1;"; // Замените "YourTableName" на имя вашей таблицы

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No data found in the table.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowRowByIndex(2);
        }

        private void ShowRowByIndex(int index)
        {
            string connectionString = "Data Source=database.sqlite;Version=3;";
            string query = $"SELECT * FROM MyTable LIMIT +1 OFFSET {index};"; // Замените "YourTableName" на имя вашей таблицы

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No data found in the table.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowRowByIndex2(3);
        }

        private void ShowRowByIndex2(int index)
        {
            string connectionString = "Data Source=database.sqlite;Version=3;";
            string query = $"SELECT * FROM MyTable LIMIT 1 OFFSET {index};"; // Замените "YourTableName" на имя вашей таблицы

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No data found in the table.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowRowByIndex3(4);
        }

        private void ShowRowByIndex3(int index)
        {
            string connectionString = "Data Source=database.sqlite;Version=3;";
            string query = $"SELECT * FROM MyTable LIMIT 1 OFFSET {index};"; // Замените "YourTableName" на имя вашей таблицы

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No data found in the table.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                panel1.Visible = false;
                this.BackColor = Color.Black;
            }
            else if (textBox1.Text == "user" && textBox2.Text == "321")
            {
                panel1.Visible = false;
                this.BackColor = Color.Yellow;
            }
            else MessageBox.Show("пароль не верный");
        } 
    }
}
