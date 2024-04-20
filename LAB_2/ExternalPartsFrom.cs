namespace LAB_2;

public partial class ExternalPartsForm : Form
{   
    private List<ExternalDevice> externalDevicesList = new List<ExternalDevice>();
    private TextBox totalPriceText;
    private double totalPriceValue = 0;
    private Action<double> updateExternalDevicesPrice;
    private ListView externalDevicesListView;
    public ExternalPartsForm(Action<double> updateExternalDevicesPrice)
    {
        this.Text = "Extarnal Parts";
        this.Size = new System.Drawing.Size(800, 600);

        this.updateExternalDevicesPrice = updateExternalDevicesPrice;

        this.externalDevicesListView = new ListView();
        externalDevicesListView.Location = new System.Drawing.Point(10, 10);
        externalDevicesListView.Size = new System.Drawing.Size(500, 200);
        externalDevicesListView.View = View.Details;
        externalDevicesListView.FullRowSelect = true;
        externalDevicesListView.GridLines = true;
        externalDevicesListView.MultiSelect = true;
        externalDevicesListView.CheckBoxes = true;
        externalDevicesListView.ItemChecked += new ItemCheckedEventHandler(externalDevicesListView_ItemChecked);
        getExternalDevices();
        setExternalDevicesListView(externalDevicesListView);
        this.Controls.Add(externalDevicesListView);        

        Label totalPriceLabel = new Label();
        totalPriceLabel.Text = "Total Price:";
        totalPriceLabel.Location = new System.Drawing.Point(10, 220);
        totalPriceLabel.Size = new System.Drawing.Size(150, 50);
        this.Controls.Add(totalPriceLabel);

        this.totalPriceText = new TextBox();
        totalPriceText.Text = totalPriceValue.ToString() + " zł";
        totalPriceText.Location = new System.Drawing.Point(200, 220);
        totalPriceText.ReadOnly = true;
        this.Controls.Add(totalPriceText);

        Button okButton = new Button();
        okButton.Text = "OK";
        okButton.Location = new System.Drawing.Point(100, 350);
        okButton.Click += new System.EventHandler(okButton_Click);
        this.Controls.Add(okButton);

        Button cancelButton = new Button();
        cancelButton.Text = "Cancel";
        cancelButton.Click += new System.EventHandler(cancelButton_Click);
        cancelButton.Location = new System.Drawing.Point(200, 350);
        this.Controls.Add(cancelButton);
    }

    private void getExternalDevices()
    {
        externalDevicesList.Add(new ExternalDevice("Mouse", 50));
        externalDevicesList.Add(new ExternalDevice("Keyboard", 100));
        externalDevicesList.Add(new ExternalDevice("Monitor", 500));
    }

    private void setExternalDevicesListView(ListView externalDevicesListView)
    {
        externalDevicesListView.Columns.Add("Name", -2, HorizontalAlignment.Left);
        externalDevicesListView.Columns.Add("Price", -2, HorizontalAlignment.Left);
        foreach (ExternalDevice externalDevice in externalDevicesList)
        {
            ListViewItem item = new ListViewItem(externalDevice.Name);
            item.SubItems.Add(externalDevice.Price.ToString());
            externalDevicesListView.Items.Add(item);
        }
    }

    private void externalDevicesListView_ItemChecked(object? sender, ItemCheckedEventArgs e)
    {
        totalPriceValue = 0;
        foreach (ListViewItem item in externalDevicesListView.Items)
        {
            if (item.Checked)
            {
                totalPriceValue += Double.Parse(item.SubItems[1].Text);
            }
        }
        totalPriceText.Text = totalPriceValue.ToString() + " zł";
    }
    private void okButton_Click(object? sender, EventArgs e)
    {
        this.updateExternalDevicesPrice(totalPriceValue);
        this.Close();
    }

    private void cancelButton_Click(object? sender, EventArgs e)
    {
        this.Close();
    }
}