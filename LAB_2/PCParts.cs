using System.Diagnostics.Contracts;

namespace LAB_2;

public partial class PCParts : Form
{   
    private List<Disc> discList = new List<Disc>();
    private ComboBox cpuList;
    private TextBox cpuPriceText, discPriceText, totalPriceText;
    private double cpuPriceValue = 0, discPriceValue = 0, totalPriceValue = 0;
    private Action<double> updatePcPartsPrice;
    public PCParts(Action<double> updatePcPartsPrice)
    {
        
        this.updatePcPartsPrice = updatePcPartsPrice;
        this.Text = "PC Parts";
        this.Size = new System.Drawing.Size(800, 600);

        Label cpu = new Label();
        cpu.Text = "CPU";
        cpu.Location = new System.Drawing.Point(100, 100);
        this.Controls.Add(cpu);

        this.cpuPriceText= new TextBox();
        cpuPriceText.Text = this.cpuPriceValue.ToString() + " zł";
        cpuPriceText.Location = new System.Drawing.Point(200, 100);
        cpuPriceText.ReadOnly = true;
        this.Controls.Add(cpuPriceText);

        this.cpuList = new ComboBox();
        cpuList.Location = new System.Drawing.Point(300, 100);
        cpuList.Size = new System.Drawing.Size(200, 100);
        cpuList.Items.Add("Intel");
        cpuList.Items.Add("AMD");
        cpuList.Items.Add("M");
        cpuList.SelectedIndexChanged += new EventHandler(cpuList_SelectedIndexChanged);
        this.Controls.Add(cpuList);

        Label disc = new Label();
        disc.Text = "Disc";
        disc.Location = new System.Drawing.Point(100, 150);
        this.Controls.Add(disc);

        this.discPriceText = new TextBox();
        discPriceText.Text = discPriceValue.ToString() + " zł";
        discPriceText.Location = new System.Drawing.Point(200, 150);
        discPriceText.ReadOnly = true;
        this.Controls.Add(discPriceText);

        getDiscs();
        generateRadioButtons();

        Label totalPrice = new Label();
        totalPrice.Text = "Total Price:";
        totalPrice.Location = new System.Drawing.Point(100, 300);
        this.Controls.Add(totalPrice);

        this.totalPriceText = new TextBox();
        totalPriceText.Text = totalPriceValue.ToString() + " zł";
        totalPriceText.Location = new System.Drawing.Point(200, 300);
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
    
    private void cpuList_SelectedIndexChanged(object sender, EventArgs e)
    {
        // even worse than radio button, maitainability -> 0
        string selectedItem = cpuList.SelectedItem.ToString(); 
        switch (selectedItem)
        {
            case "Intel":
                cpuPriceValue = 1000;
                cpuPriceText.Text =  cpuPriceValue.ToString() + " zł";
                totalPriceValue = discPriceValue + cpuPriceValue;
                totalPriceText.Text = totalPriceValue.ToString() + " zł";
                break;
            case "AMD":
                cpuPriceValue = 800;
                cpuPriceText.Text =  cpuPriceValue.ToString() + " zł";
                totalPriceValue = discPriceValue + cpuPriceValue;
                totalPriceText.Text = totalPriceValue.ToString() + " zł";
                break;
            case "M1":
                cpuPriceValue = 600;
                cpuPriceText.Text =  cpuPriceValue.ToString() + " zł";
                totalPriceValue = discPriceValue + cpuPriceValue;
                totalPriceText.Text = totalPriceValue.ToString() + " zł";
                break;
        }
    }
    
    private void getDiscs()
    {
        discList.Add(new Disc("1TB", "Samsung", 200));
        discList.Add(new Disc("2TB", "Seagate", 300));
        discList.Add(new Disc("500GB", "WD", 100));
    }

    private void generateRadioButtons()
    {
        int y = 150;
        foreach (Disc disc in discList)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.Text = disc.GetName();
            radioButton.Location = new System.Drawing.Point(300, y);
            radioButton.CheckedChanged += new System.EventHandler(radioButton_CheckedChanged);
            this.Controls.Add(radioButton);
            y += 20;
        }
    }

    private void radioButton_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton radioButton = (RadioButton)sender;
        if (radioButton.Checked)
        {
            // Trash performance, why iterate over the list every time. But for 3 options it's fine.
            string discName = radioButton.Text;
            foreach (Disc disc in discList)
            {
                if (disc.GetName() == discName)
                {
                    discPriceValue = disc.Price;
                    discPriceText.Text = discPriceValue.ToString() + " zł";
                    totalPriceValue = cpuPriceValue + discPriceValue;
                    totalPriceText.Text = totalPriceValue.ToString() + " zł";
                }
            }
        }
    }

    private void okButton_Click(object? sender, EventArgs e)
    {   
        // This could be a good example of how to use contracts
        this.updatePcPartsPrice(totalPriceValue);
        this.Close();
    }

    private void cancelButton_Click(object? sender, EventArgs e)
    {
        this.Close();
    }
}