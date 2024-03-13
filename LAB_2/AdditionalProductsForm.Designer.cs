namespace LAB_2
{
    partial class AdditionalProductsForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "1TB", "200" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "2TB", "300" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "3TB", "300" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "27\"", "600" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "24\"", "700" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "32\"", "800" }, -1);
            button1 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            listView1 = new ListView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listView2 = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(713, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(339, 243);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 26;
            label6.Text = "Cena:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(339, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 23);
            textBox3.TabIndex = 24;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 100);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 21;
            label5.Text = "Cena:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(339, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 23);
            textBox2.TabIndex = 19;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(24, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(293, 67);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.ItemChecked += listV;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(24, 60);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 16;
            label3.Text = "Dysk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(24, 194);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 15;
            label2.Text = "Monitor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(9, 9);
            label1.Margin = new Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 37);
            label1.TabIndex = 14;
            label1.Text = "Produkty Dodatkowe";
            // 
            // listView2
            // 
            listView2.CheckBoxes = true;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
            listView2.Location = new Point(24, 242);
            listView2.Name = "listView2";
            listView2.Size = new Size(293, 67);
            listView2.TabIndex = 28;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.List;
            listView2.ItemChecked += ItemChecked;
            // 
            // AdditionalProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdditionalProductsForm";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private ListView listView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView listView2;
    }
}