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
    public partial class AdditionalProductsForm : Form
    {
        public AdditionalProductsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void listV(object sender, ItemCheckedEventArgs e)
        {
            int total_price = 0;
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                total_price += Int32.Parse(item.SubItems[1].Text);
            }
            textBox2.Text = total_price.ToString();

            PriceChanged();
        }

        private void ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int total_price = 0;
            foreach (ListViewItem item in listView2.CheckedItems)
            {
                total_price += Int32.Parse(item.SubItems[1].Text);
            }
            textBox3.Text = total_price.ToString();

            PriceChanged();
        }

        private void PriceChanged()
        {
            int total = Int32.Parse(textBox3.Text) + Int32.Parse(textBox2.Text);
            ControlPanelForm.instance.TextBox2.Text = total.ToString();
        }
    }
}
