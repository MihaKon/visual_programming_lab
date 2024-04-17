namespace Lab_4;

public partial class MainWindow : Form
{
    private PictureBox pictureBox;
    private RadioButton radioButton90, radioButton180, radioButton270;
    public MainWindow()
    {
        InitializeComponent();
        
        this.pictureBox = new PictureBox();
        pictureBox.Location = new Point(120, 10);
        pictureBox.Size = new Size(400, 400);
        pictureBox.BackColor = Color.Gray;
        Controls.Add(pictureBox);

        this.radioButton90 = new RadioButton();
        radioButton90.Checked = true;
        radioButton90.Text = "90";
        radioButton90.Location = new Point(540, 10);
        radioButton90.Size = new Size(100, 50);
        Controls.Add(radioButton90);

        this.radioButton180 = new RadioButton();
        radioButton180.Text = "180";
        radioButton180.Location = new Point(540, 60);
        radioButton180.Size = new Size(100, 50);
        Controls.Add(radioButton180);

        this.radioButton270 = new RadioButton();
        radioButton270.Text = "270";
        radioButton270.Location = new Point(540, 110);
        radioButton270.Size = new Size(100, 50);
        Controls.Add(radioButton270);

        Button rotateImage = new Button();
        rotateImage.Text = "Rotate Image";
        rotateImage.Location = new Point(10, 10);
        rotateImage.Size = new Size(100, 50);
        rotateImage.Click += new EventHandler(rotateImage_Click);
        Controls.Add(rotateImage);

        Button onlyGreen = new Button();
        onlyGreen.Text = "Only Green";
        onlyGreen.Location = new Point(10, 70);
        onlyGreen.Size = new Size(100, 50);
        onlyGreen.Click += new EventHandler(onlyGreen_Click);
        Controls.Add(onlyGreen);
        
        Button InvertColors = new Button();
        InvertColors.Text = "Invert Colors";
        InvertColors.Location = new Point(10, 130);
        InvertColors.Size = new Size(100, 50);
        InvertColors.Click += new EventHandler(InvertColors_Click);
        Controls.Add(InvertColors);

        Button upsideDown = new Button();
        upsideDown.Text = "Upside Down";
        upsideDown.Location = new Point(10, 190);
        upsideDown.Size = new Size(100, 50);
        upsideDown.Click += new EventHandler(upsideDown_Click);
        Controls.Add(upsideDown);

        Button loadImage = new Button();
        loadImage.Text = "Load Image";
        loadImage.Location = new Point(10, 250);
        loadImage.Size = new Size(100, 50);
        loadImage.Click += new EventHandler(loadImage_Click);
        Controls.Add(loadImage);
    } 

    private void loadImage_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pictureBox.Image = Image.FromFile(openFileDialog.FileName);
        }
    }

    private void rotateImage_Click(object sender, EventArgs e)
    {
        if (pictureBox.Image != null)
        {
            int degrees = 0;
            if (radioButton90.Checked)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (radioButton180.Checked)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if (radioButton270.Checked)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }

            pictureBox.Invalidate();
        }
    }

    private void InvertColors_Click(object sender, EventArgs e)
    {
        if (pictureBox.Image != null)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Image);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    bitmap.SetPixel(i, j, Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
                }
            }
            pictureBox.Image = bitmap;
        }
    }

    private void upsideDown_Click(object sender, EventArgs e)
    {
        if (pictureBox.Image != null)
        {
            pictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox.Invalidate();
        }
    }
    private void onlyGreen_Click(object sender, EventArgs e)
    {
        if (pictureBox.Image != null)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Image);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    if (color.G > color.R && color.G > color.B)
                        bitmap.SetPixel(i, j, Color.FromArgb(0, color.G, 0));
                    else
                        bitmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                }
            }
            pictureBox.Image = bitmap;
        }
    }
}
