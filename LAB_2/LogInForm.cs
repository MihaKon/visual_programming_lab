using System.Media;

namespace LAB_2
{

    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "PC_Master" && textBox2.Text=="1234")
            {
                ControlPanelForm form2 = new ControlPanelForm();
                form2.Show();
                this.Hide();
                return;
            }
            SystemSounds.Exclamation.Play();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
