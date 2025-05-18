using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorFilterApp
{
    public partial class ColorFilterForm : Form
    {
        private Bitmap originalImage;
        private PictureBox pictureBox;
        private Button loadButton;
        private Button filterButton;
        private Color selectedColor;

        public ColorFilterForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Фильтр по цвету";
            this.Size = new Size(800, 600);

            pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            };

            loadButton = new Button
            {
                Text = "Загрузить изображение",
                Dock = DockStyle.Top
            };
            loadButton.Click += LoadButton_Click;

            filterButton = new Button
            {
                Text = "Применить фильтр",
                Dock = DockStyle.Top,
                Enabled = false
            };
            filterButton.Click += FilterButton_Click;

            this.Controls.Add(pictureBox);
            this.Controls.Add(filterButton);
            this.Controls.Add(loadButton);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    pictureBox.Image = originalImage;
                    filterButton.Enabled = true;
                }
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedColor = colorDialog.Color;
                    ApplyColorFilter();
                }
            }
        }

        private void ApplyColorFilter()
        {
            if (originalImage == null) return;

            Bitmap filteredImage = new Bitmap(originalImage.Width, originalImage.Height);
            int tolerance = 30;

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    
                    if (IsColorSimilar(pixelColor, selectedColor, tolerance))
                    {
                        filteredImage.SetPixel(x, y, pixelColor);
                    }
                    else
                    {
                        filteredImage.SetPixel(x, y, Color.Transparent);
                    }
                }
            }

            pictureBox.Image = filteredImage;
        }

        private bool IsColorSimilar(Color color1, Color color2, int tolerance)
        {
            return Math.Abs(color1.R - color2.R) <= tolerance &&
                   Math.Abs(color1.G - color2.G) <= tolerance &&
                   Math.Abs(color1.B - color2.B) <= tolerance;
        }
    }
} 