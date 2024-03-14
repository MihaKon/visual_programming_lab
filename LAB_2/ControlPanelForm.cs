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

    public partial class ControlPanelForm : Form
    {
        public static ControlPanelForm instance;
        public TextBox TextBox, TextBox2;
        public int necesseryProducts, additionalProducts;
        public ControlPanelForm()
        {
            InitializeComponent();
            instance = this;
            TextBox = textBox1;
            TextBox2 = textBox2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainProductsForm mainProductsForm = new MainProductsForm();
            mainProductsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdditionalProductsForm additionalProductsForm = new AdditionalProductsForm();
            additionalProductsForm.Show();
        }

        private int calcTotal()
        {
            return Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = calcTotal().ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = calcTotal().ToString();
        }
    }
}
