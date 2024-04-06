using System;
using System.Windows.Forms;

namespace gridview;

public partial class Form1 : Form
{
    private BindingSource bindingSource = new BindingSource();

    public Form1()
    {
        InitializeComponent();

        Button button = new Button();
        button.Text = "Dodaj";
        button.Location = new Point(700, 40);
        button.Size = new Size(90,50);
        button.Click += new EventHandler(this.AddButton_Click);
        Controls.Add(button);

        Button button2 = new Button();
        button2.Text = "Usuń";
        button2.Location = new Point(700, 120);
        button2.Size = new Size(90,50);
        button2.Click += new EventHandler(this.DeleteButton_Click);
        Controls.Add(button2);

        Button button3 = new Button();
        button3.Text = "Eksport .CSV";
        button3.Location = new Point(20, 390);
        button3.Size = new Size(160,50);
        button3.Click += new EventHandler(this.ExportButton_Click);
        Controls.Add(button3);

        Button button4 = new Button();
        button4.Text = "Import .CSV";
        button4.Location = new Point(190, 390);
        button4.Size = new Size(160,50);
        button4.Click += new EventHandler(this.ImportButton_Click);
        Controls.Add(button4);

        var dataTable = new System.Data.DataTable();
        dataTable.Columns.Add("ID", typeof(int));
        dataTable.Columns.Add("Imie", typeof(string));
        dataTable.Columns.Add("Nazwisko", typeof(string));

        bindingSource.DataSource = dataTable;

        DataGridView dataGridView = new DataGridView();
        dataGridView.Size = new Size(690, 380);
        dataGridView.DataSource = bindingSource;
        Controls.Add(dataGridView);
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Usuwanie");
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Eksport");
    }

    private void ImportButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Import");
    }

}
