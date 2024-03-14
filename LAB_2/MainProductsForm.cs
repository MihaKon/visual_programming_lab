using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class MainProductsForm : Form
    {
        public MainProductsForm()
        {
            InitializeComponent();
        }

        private void MainProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                textBox4.Text = listView2.SelectedItems[0].Text;
                textBox3.Text = listView2.SelectedItems[0].SubItems[1].Text;
                priceChanged();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                priceChanged();
            }

        }
        private void priceChanged()
        {
            int total = Int32.Parse(textBox2.Text) + Int32.Parse(textBox3.Text);
            ControlPanelForm.instance.TextBox.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
