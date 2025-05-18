using System.Drawing;
using System.Drawing.Drawing2D;

namespace _9;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Size = new Size(800, 600);
        this.Text = "Рисунок из фигур";
        this.Paint += Form1_Paint;
    }

    private void Form1_Paint(object? sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        // Линии разных стилей
        using var pen1 = new Pen(Color.Red, 2);
        using var pen2 = new Pen(Color.Blue, 2) { DashStyle = DashStyle.Dash };
        using var pen3 = new Pen(Color.Green, 2) { DashStyle = DashStyle.DashDot };

        g.DrawLine(pen1, 50, 50, 200, 50);
        g.DrawLine(pen2, 50, 80, 200, 80);
        g.DrawLine(pen3, 50, 110, 200, 110);

        // Прямоугольники
        using var brush1 = new SolidBrush(Color.Yellow);
        g.FillRectangle(brush1, 250, 50, 100, 60);
        g.DrawRectangle(pen1, 250, 50, 100, 60);

        // Эллипсы
        using var brush2 = new SolidBrush(Color.Purple);
        g.FillEllipse(brush2, 400, 50, 100, 60);
        g.DrawEllipse(pen2, 400, 50, 100, 60);

        // Многоугольник
        Point[] points = { new(50, 200), new(100, 250), new(150, 200), new(100, 150) };
        using var brush3 = new SolidBrush(Color.Orange);
        g.FillPolygon(brush3, points);
        g.DrawPolygon(pen3, points);

        // Дуга
        g.DrawArc(pen1, 250, 200, 100, 100, 0, 270);

        // Кривая Безье
        g.DrawBezier(pen2, 400, 200, 450, 150, 500, 250, 550, 200);
    }
} 