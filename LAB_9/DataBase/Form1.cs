using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        private DataBaseManager db;

        public Form1()
        {
            string databaseFilePath = @"C:\Users\Lenovo\Desktop\Programowanie Wizualne\visual_programming_lab\LAB_9\DataBase\Database1.mdf";
            loadDb(databaseFilePath);
            InitializeComponent();
        }

        private void loadDb(string filePath)
        {
            db = new DataBaseManager(filePath);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(db);
            form2.Show();
        }
    }
}
