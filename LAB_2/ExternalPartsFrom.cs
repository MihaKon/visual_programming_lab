namespace LAB_2;

public partial class ExternalPartsForm : Form
{
    public ExternalPartsForm()
    {
        this.Text = "Extarnal Parts";
        this.Size = new System.Drawing.Size(800, 600);

        Button button = new Button();
        button.Text = "Click Me";
        button.Location = new System.Drawing.Point(100, 100);
        this.Controls.Add(button);
    }
}