using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ColorFilterApp
{
    public partial class ColorFilterForm : Form
    {
        private Bitmap originalImage;
        private PictureBox pictureBox;
        private Button loadButton;
        private Button filterButton;
        private TextBox hexColorBox;
        private Button applyHexButton;
        private Button pipetteButton;
        private Color selectedColor;
        private bool isPipetteActive = false;
        private Cursor pipetteCursor;

        public ColorFilterForm()
        {
            InitializeComponent();
            InitializeUI();
            // Создаем курсор пипетки
            pipetteCursor = CreatePipetteCursor();
        }

        private Cursor CreatePipetteCursor()
        {
            // Создаем простое изображение пипетки
            Bitmap cursorBitmap = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(cursorBitmap))
            {
                g.Clear(Color.Transparent);
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    // Рисуем пипетку
                    g.DrawLine(pen, 8, 8, 24, 24);
                    g.DrawEllipse(pen, 20, 20, 8, 8);
                }
            }
            return new Cursor(cursorBitmap.GetHicon());
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
            pictureBox.MouseClick += PictureBox_MouseClick;

            loadButton = new Button
            {
                Text = "Загрузить изображение",
                Dock = DockStyle.Top
            };
            loadButton.Click += LoadButton_Click;

            pipetteButton = new Button
            {
                Text = "Пипетка",
                Dock = DockStyle.Top,
                Enabled = false
            };
            pipetteButton.Click += PipetteButton_Click;

            filterButton = new Button
            {
                Text = "Выбрать цвет",
                Dock = DockStyle.Top,
                Enabled = false
            };
            filterButton.Click += FilterButton_Click;

            hexColorBox = new TextBox
            {
                PlaceholderText = "Введите HEX-код цвета (например, #FF0000)",
                Dock = DockStyle.Top,
                Enabled = false
            };

            applyHexButton = new Button
            {
                Text = "Применить HEX-цвет",
                Dock = DockStyle.Top,
                Enabled = false
            };
            applyHexButton.Click += ApplyHexButton_Click;

            this.Controls.Add(pictureBox);
            this.Controls.Add(applyHexButton);
            this.Controls.Add(hexColorBox);
            this.Controls.Add(filterButton);
            this.Controls.Add(pipetteButton);
            this.Controls.Add(loadButton);
        }

        private void PipetteButton_Click(object sender, EventArgs e)
        {
            isPipetteActive = !isPipetteActive;
            if (isPipetteActive)
            {
                pipetteButton.BackColor = Color.LightBlue;
                pictureBox.Cursor = pipetteCursor;
            }
            else
            {
                pipetteButton.BackColor = SystemColors.Control;
                pictureBox.Cursor = Cursors.Default;
            }
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isPipetteActive || originalImage == null) return;

            // Получаем координаты клика относительно изображения
            float scaleX = (float)originalImage.Width / pictureBox.ClientSize.Width;
            float scaleY = (float)originalImage.Height / pictureBox.ClientSize.Height;

            int imageX = (int)(e.X * scaleX);
            int imageY = (int)(e.Y * scaleY);

            // Проверяем, что координаты в пределах изображения
            if (imageX >= 0 && imageX < originalImage.Width && 
                imageY >= 0 && imageY < originalImage.Height)
            {
                selectedColor = originalImage.GetPixel(imageX, imageY);
                hexColorBox.Text = ColorTranslator.ToHtml(selectedColor);
                ApplyColorFilter();
                
                // Деактивируем пипетку после выбора цвета
                isPipetteActive = false;
                pipetteButton.BackColor = SystemColors.Control;
                pictureBox.Cursor = Cursors.Default;
            }
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
                    hexColorBox.Enabled = true;
                    applyHexButton.Enabled = true;
                    pipetteButton.Enabled = true;
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

        private void ApplyHexButton_Click(object sender, EventArgs e)
        {
            string hexColor = hexColorBox.Text.Trim();
            if (IsValidHexColor(hexColor))
            {
                selectedColor = ColorTranslator.FromHtml(hexColor);
                ApplyColorFilter();
            }
            else
            {
                MessageBox.Show("Неверный формат HEX-кода. Используйте формат #RRGGBB", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidHexColor(string hexColor)
        {
            if (string.IsNullOrWhiteSpace(hexColor)) return false;
            
            // Убираем # если есть
            hexColor = hexColor.TrimStart('#');
            
            // Проверяем формат RRGGBB
            return Regex.IsMatch(hexColor, "^[0-9A-Fa-f]{6}$");
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