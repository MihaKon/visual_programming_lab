using System.Windows.Forms.VisualStyles;

namespace LAB_2;

public partial class SummaryForm : Form
{
    
    private TextBox totalPriceText;
    private double totalPriceValue = 0, pcPartsPriceValue = 0, externalDevicesPriceValue = 0;
    public SummaryForm()
    {
        InitializeComponent();
        Button pcParts = new Button();
        pcParts.Text = "Computer";
        pcParts.Location = new Point(10, 10);
        pcParts.Size = new Size(150, 50);
        pcParts.Click += new EventHandler(pcParts_Click);
        Controls.Add(pcParts);

        Button externalDevices = new Button();
        externalDevices.Text = "External Devices";
        externalDevices.Location = new Point(200, 10);
        externalDevices.Size = new Size(200, 50);
        externalDevices.Click += new EventHandler(externalDevices_Click);
        Controls.Add(externalDevices);

        Label totalPriceLabel = new Label();
        totalPriceLabel.Text = "Total Price:";
        totalPriceLabel.Location = new Point(400, 15);
        totalPriceLabel.Size = new Size(150, 50);
        Controls.Add(totalPriceLabel);

        this.totalPriceText = new TextBox();
        totalPriceText.Text = totalPriceValue.ToString() + " zł";
        totalPriceText.Location = new Point(560, 10);
        totalPriceText.ReadOnly = true;
        Controls.Add(totalPriceText);
    }

    private void pcParts_Click(object? sender, EventArgs e)
    {
        PCParts pcPartsForm = new PCParts(this.updatePcPartsPrice);
        pcPartsForm.Show();
    }

    private void externalDevices_Click(object? sender, EventArgs e)
    {
        ExternalPartsForm externalPartsForm = new ExternalPartsForm();
        externalPartsForm.Show();
    }

    public void updatePcPartsPrice(double price)
    {
        pcPartsPriceValue = price;
        totalPriceValue = pcPartsPriceValue + externalDevicesPriceValue;
        totalPriceText.Text = totalPriceValue.ToString() + " zł";
    }

    public void updateExternalDevicesPrice(double price)
    {
        externalDevicesPriceValue = price;
        totalPriceValue = pcPartsPriceValue + externalDevicesPriceValue;
        totalPriceText.Text = totalPriceValue.ToString() + " zł";
    }
}
