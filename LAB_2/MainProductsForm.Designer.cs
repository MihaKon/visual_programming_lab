namespace LAB_2
{
    partial class MainProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewGroup listViewGroup1 = new ListViewGroup("Intel", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("AMD", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Intel i5-7500", "1600" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Intel i7-10500k", "400" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "AMD ThreadRipper 7900", "700" }, -1);
            ListViewGroup listViewGroup3 = new ListViewGroup("Nvidia", HorizontalAlignment.Left);
            ListViewGroup listViewGroup4 = new ListViewGroup("AMD", HorizontalAlignment.Left);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Geforce GTX 1060 6GB", "1600" }, -1);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            listView2 = new ListView();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(9, 9);
            label1.Margin = new Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 0;
            label1.Text = "Produkty Wymagane";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(24, 194);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 1;
            label2.Text = "Karta Graficzna";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(24, 60);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 2;
            label3.Text = "Procesor";
            label3.Click += label3_Click;
            // 
            // listView1
            // 
            listViewGroup1.Header = "Intel";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "AMD";
            listViewGroup2.Name = "listViewGroup2";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(24, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(293, 67);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(630, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 23);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(630, 99);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 7;
            label5.Text = "Cena:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(630, 242);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 12;
            label6.Text = "Cena:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(630, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 23);
            textBox3.TabIndex = 10;
            // 
            // listView2
            // 
            listViewGroup3.Header = "Nvidia";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "AMD";
            listViewGroup4.Name = "listViewGroup1";
            listView2.Groups.AddRange(new ListViewGroup[] { listViewGroup3, listViewGroup4 });
            listViewItem4.Group = listViewGroup3;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem4 });
            listView2.Location = new Point(24, 243);
            listView2.Name = "listView2";
            listView2.Size = new Size(293, 67);
            listView2.TabIndex = 8;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Tile;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(713, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 99);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 6;
            label4.Text = "Wybrany Produkt:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(350, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(263, 23);
            textBox4.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(350, 242);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 11;
            label7.Text = "Wybrany Produkt:";
            // 
            // MainProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(listView2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainProductsForm";
            Text = "Form3";
            Load += MainProductsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listView1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private ListView listView2;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox4;
        private Label label7;
    }
}