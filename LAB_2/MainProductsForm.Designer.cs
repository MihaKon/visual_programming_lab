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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Intel i5-7500", "Cena" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Intel i7-10500k", "400" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "AMD ThreadRipper 7900", "700" }, -1);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
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
            // 
            // MainProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}