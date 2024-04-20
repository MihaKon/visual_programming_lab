using System;
using System.CodeDom;
using System.Windows.Forms;

namespace gridview;
public partial class Form2 : Form
{
    Action<string, string, string> addRow;
    TextBox name, surname;
    ComboBox position;
    public Form2(Action<string, string, string> addRow)
    {
        this.Text = "Extarnal Parts";
        this.Size = new System.Drawing.Size(800, 600);

        this.addRow = addRow;
        
        Label label = new Label();
        label.Text = "Imie";
        label.Location = new Point(20, 20);
        Controls.Add(label);
        
        this.name = new TextBox();
        name.Location = new Point(20, 120);
        name.Size = new Size(150, 50);
        Controls.Add(name);

        Label label2 = new Label();
        label2.Text = "Nazwisko";
        label2.Location = new Point(20, 100);
        Controls.Add(label2);
        
        this.surname = new TextBox();
        surname.Location = new Point(20, 40);
        surname.Size = new Size(150, 50);
        Controls.Add(surname);

        Label label3 = new Label();
        label3.Text = "Pozycja";
        label3.Location = new Point(20, 180);
        Controls.Add(label3);

        this.position = new ComboBox();
        position.Location = new Point(20, 200);
        position.Size = new Size(150, 50);
        getComboBoxItems(position);
        Controls.Add(position);
        
        Button button = new Button();
        button.Text = "OK";
        button.Location = new Point(20, 300);
        button.Size = new Size(90,50);
        button.Click += new EventHandler(this.AddButton_Click);
        Controls.Add(button);

        Button button2 = new Button();
        button2.Text = "cancel";
        button2.Location = new Point(150,300);
        button2.Size = new Size(90,50);
        button2.Click += new EventHandler(this.CancelButton_Click);
        Controls.Add(button2);
    }

    private void getComboBoxItems(ComboBox comboBox)
    {
        Person person = new Person(1, "Jan", "Kowalski");
        foreach (var position in person.Positions)
        {   
            comboBox.Items.Add(position.PositionName);
        }
    }
    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        addRow(name.Text, surname.Text, position.Text);
        this.Close();
    }
}