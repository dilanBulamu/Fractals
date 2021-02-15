using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace PeerGrade5
{
    // Ковер Серпинского.
    class Carpet : Fractal
    {
        public Carpet(int length, int deep, PictureBox picture, GetColor colors) : base(length, deep, picture, colors) { }
        // Метод для рисования ковра.
        public void DrawCarpet(int x1, int y1, int deep, int length, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // Рисуем
            g.FillRectangle(new SolidBrush(Colors.Gradient(deep)), x1, y1, length, length);
            g.FillRectangle(new SolidBrush(Colors.Gradient(deep - 1)), x1 + length, y1, length, length);
            g.FillRectangle(new SolidBrush(Colors.Gradient(deep)), x1 + 2 * length, y1, length, length);
            g.FillRectangle(new SolidBrush(Colors.Gradient(deep - 1)), x1, y1 + length, length, length);
            g.FillRectangle(new SolidBrush(Colors.Gradient(deep - 1)), x1 + 2 * length, y1 + length, length, length);
            g.FillRectangle(new SolidBrush(Colors.Gradient(deep)), x1, y1 + 2 * length, length, length);
            g.FillRectangle(new SolidBrush(Colors.Gradient(deep - 1)), x1 + length, y1 + 2 * length, length, length);
            g.FillRectangle(new SolidBrush(Colors.Gradient(deep)), x1 + 2 * length, y1 + 2 * length, length, length);
            g.FillRectangle(new SolidBrush(Color.FromArgb(25,25,26)), x1 + length, y1 + length, length, length);
            Picture.Image = bmp;
            // Вызываем рекурсию от всех квадратов кроме среднего.
            if (deep > 1 && length >= 9)
            {
                DrawCarpet(x1, y1, deep - 1, (int)(length / 3.0), bmp);
                DrawCarpet(x1 + length, y1, deep - 1, (int)(length / 3.0), bmp);
                DrawCarpet(x1 + 2 * length, y1, deep - 1, (int)(length / 3.0), bmp);
                DrawCarpet(x1, y1 + 2 * length, deep - 1, (int)(length / 3.0), bmp);
                DrawCarpet(x1 + length, y1 + 2 * length, deep - 1, (int)(length / 3.0), bmp);
                DrawCarpet(x1 + 2 * length, y1 + 2 * length, deep - 1, (int)(length / 3.0), bmp);
                DrawCarpet(x1, y1 + length, deep - 1, (int)(length / 3.0), bmp);
                DrawCarpet(x1 + 2 * length, y1 + length, deep - 1, (int)(length / 3.0), bmp);
            }
        }
    }
}