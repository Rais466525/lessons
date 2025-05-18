using System.Drawing;
using System.Windows.Forms;
using System;

namespace _10;

public partial class Form1 : Form
{
    private float x = 0;
    private readonly System.Windows.Forms.Timer timer;
    private const float Speed = 2f;
    private const float Amplitude = 100f;
    private const float Frequency = 0.02f;
    private const int CircleRadius = 20;

    public Form1()
    {
        InitializeComponent();
        this.Size = new Size(800, 600);
        this.Text = "Движение по синусоиде";
        this.DoubleBuffered = true;

        timer = new System.Windows.Forms.Timer { Interval = 16 }; // ~60 FPS
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        x += Speed;
        if (x > this.ClientSize.Width + CircleRadius)
            x = -CircleRadius;
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        // Рисуем синусоиду
        using var pen = new Pen(Color.Gray, 1);
        for (int i = 0; i < this.ClientSize.Width; i++)
        {
            float y1 = this.ClientSize.Height / 2 + (float)Math.Sin(i * Frequency) * Amplitude;
            float y2 = this.ClientSize.Height / 2 + (float)Math.Sin((i + 1) * Frequency) * Amplitude;
            g.DrawLine(pen, i, y1, i + 1, y2);
        }

        // Рисуем движущуюся окружность
        float circleY = this.ClientSize.Height / 2 + (float)Math.Sin(x * Frequency) * Amplitude;
        using var brush = new SolidBrush(Color.Red);
        g.FillEllipse(brush, x - CircleRadius, circleY - CircleRadius, CircleRadius * 2, CircleRadius * 2);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        timer.Stop();
        timer.Dispose();
        base.OnFormClosing(e);
    }
} 