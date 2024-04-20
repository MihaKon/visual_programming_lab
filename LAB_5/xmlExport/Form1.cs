using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Permissions;

namespace gridview;

public partial class Form1 : Form
{
    private BindingSource bindingSource = new BindingSource();
    private int id = 1;
    DataTable dataTable;
    DataGridView dataGridView;
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

        Button button5 = new Button();
        button5.Text = "Eksport .XML";
        button5.Location = new Point(360, 390);
        button5.Size = new Size(160,50);
        button5.Click += new EventHandler(this.ExportButtonXML_Click);
        Controls.Add(button5);

        Button button6 = new Button();
        button6.Text = "Import .XML";
        button6.Location = new Point(530, 390);
        button6.Size = new Size(160,50);
        button6.Click += new EventHandler(this.ImportButtonXML_Click);
        Controls.Add(button6);

        this.dataTable = new System.Data.DataTable();
        this.dataTable.TableName = "Persons";
        addDataColumns(dataTable);

        bindingSource.DataSource = dataTable;

        this.dataGridView = new DataGridView();
        dataGridView.Size = new Size(690, 380);
        dataGridView.DataSource = bindingSource;
        dataGridView.AllowUserToAddRows = false;
        dataGridView.AllowUserToDeleteRows = false;
        dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        Controls.Add(dataGridView);
    }

    private void addDataColumns(System.Data.DataTable dataTable)
    {
        Person person = new Person(1, "Jan", "Kowalski");
        Type type = person.GetType();
        var properties = type.GetProperties();
        foreach (var property in properties)
        {
            dataTable.Columns.Add(property.Name, typeof(string));
        }
    }
    private void DeleteButton_Click(object sender, EventArgs e)
    {
        dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2(addRow);
        form2.Show(); 
    }

    private void addRow(string name, string surname, string position)
    {
        dataTable.Rows.Add(id, name, surname, position);
        this.id++;
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "CSV File (*.csv)|*.csv";
        saveFileDialog.Title = "Save CSV File";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveFileDialog.FileName;

            StringBuilder sb = new StringBuilder();

            foreach (DataColumn column in dataTable.Columns)
            {
                sb.Append(column.ColumnName);
                sb.Append(",");
            }
            sb.AppendLine();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    sb.Append(item.ToString());
                    sb.Append(",");
                }
                sb.AppendLine();
            }
            File.WriteAllText(filePath, sb.ToString());
            MessageBox.Show("Data exported successfully!");
        }
    }

    private void ImportButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "CSV File (*.csv)|*.csv";
        openFileDialog.Title = "Import CSV File";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;
            using (StreamReader reader = new StreamReader(filePath))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');
                    dataTable.Rows.Add(data[0],data[1],data[2],data[3]);
                }
            }

            MessageBox.Show("Data imported successfully!");
        }
    }

    private void ExportButtonXML_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "XML File (*.xml)|*.xml";
        saveFileDialog.Title = "Save XML File";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveFileDialog.FileName;
            dataTable.WriteXml(filePath);
            MessageBox.Show("Data exported successfully!");
        }
    }

    private void ImportButtonXML_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "XML File (*.xml)|*.xml";
        openFileDialog.Title = "Import XML File";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;
            dataTable.ReadXml(filePath);
            MessageBox.Show("Data imported successfully!");
        }
    }
}
