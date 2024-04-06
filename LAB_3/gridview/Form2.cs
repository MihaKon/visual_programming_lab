using System;
using System.Windows.Forms;

namespace gridview;
public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();

        Button button = new Button();
        button.Text = "OK";
        button.Location = new Point(700, 40);
        button.Size = new Size(90,50);
        button.Click += new EventHandler(this.AddButton_Click);
        Controls.Add(button);

        Button button2 = new Button();
        button2.Text = "Anuluj";
        button2.Location = new Point(700, 120);
        button2.Size = new Size(90,50);
        button2.Click += new EventHandler(this.CancelButton_Click);
        Controls.Add(button2);

        TextBox textBox = new TextBox();
        textBox.Location = new Point(20, 40);
        textBox.Size = new Size(660, 50);
        Controls.Add(textBox);

        TextBox textBox2 = new TextBox();
        textBox2.Location = new Point(20, 120);
        textBox2.Size = new Size(660, 50);
        Controls.Add(textBox2);

        Label label = new Label();
        label.Text = "Imie";
        label.Location = new Point(20, 20);
        Controls.Add(label);

        Label label2 = new Label();
        label2.Text = "Nazwisko";
        label2.Location = new Point(20, 100);
        Controls.Add(label2);
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Dodawanie");
    }
}