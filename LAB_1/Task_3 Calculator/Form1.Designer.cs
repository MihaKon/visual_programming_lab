namespace Task_3;
using Task_2;
partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox input_one;
    private System.Windows.Forms.TextBox input_two;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        this.input_one = new System.Windows.Forms.TextBox();
        input_one.Location = new System.Drawing.Point(200, 30);
        input_one.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check_input);

        this.input_two = new System.Windows.Forms.TextBox();
        input_two.Location = new System.Drawing.Point(350, 30);
        input_two.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check_input);


        System.Windows.Forms.Button add_button = new System.Windows.Forms.Button();
        add_button.Location = new System.Drawing.Point(50, 50);
        add_button.Text = "Add";
        add_button.Click += new System.EventHandler(this.add_button_Click);

        System.Windows.Forms.Button subtract_button = new System.Windows.Forms.Button();
        subtract_button.Location = new System.Drawing.Point(50, 100);
        subtract_button.Text = "Subtract";
        subtract_button.Click += new System.EventHandler(this.subtract_button_Click);

        System.Windows.Forms.Button multiply_button = new System.Windows.Forms.Button();
        multiply_button.Location = new System.Drawing.Point(50, 150);
        multiply_button.Text = "Multiply";
        multiply_button.Click += new System.EventHandler(this.multiply_button_Click);

        System.Windows.Forms.Button divide_button = new System.Windows.Forms.Button();
        divide_button.Location = new System.Drawing.Point(50, 200);
        divide_button.Text = "Divide";
        divide_button.Click += new System.EventHandler(this.divide_button_Click);

        this.Controls.Add(input_one);
        this.Controls.Add(input_two);
        this.Controls.Add(add_button);
        this.Controls.Add(subtract_button);
        this.Controls.Add(multiply_button);
        this.Controls.Add(divide_button);
    }

    private void check_input(object sender, System.Windows.Forms.KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void clear_input(object sender, System.EventArgs e)
    {
        input_two.Text = "";
        input_one.Text = "";
    }

    private (int,int) get_numbers()
    {
        int number_one = int.Parse(input_one.Text);
        int number_two = int.Parse(input_two.Text);
        return (number_one, number_two);
    }
    private void add_button_Click(object sender, System.EventArgs e)
    {   
        var (num1, num2) = get_numbers();
        int result = Task_2.Calculator.Add(num1, num2); 
        MessageBox.Show(result.ToString());
    }

    private void subtract_button_Click(object sender, System.EventArgs e)
    {
        var (num1, num2) = get_numbers();
        int result = Task_2.Calculator.Subtract(num1, num2);
        MessageBox.Show(result.ToString());
    }

    private void multiply_button_Click(object sender, System.EventArgs e)
    {
        var (num1, num2) = get_numbers();
        int result = Task_2.Calculator.Multiply(num1, num2);
        MessageBox.Show(result.ToString());
    }

    private void divide_button_Click(object sender, System.EventArgs e)
    {
        var (num1, num2) = get_numbers();
        int result = Task_2.Calculator.Divide(num1, num2);
        MessageBox.Show(result.ToString());
    }

    #endregion
}
