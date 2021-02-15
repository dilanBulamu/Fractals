using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace PeerGrade5
{
    // Треугольник Серпинского.
    class Triangle : Fractal
    {
        public Triangle(int length, int deep, PictureBox picture, GetColor colors) : base(length, deep, picture, colors) { }
        // Метод для рисования Треугольника.
        public void DrawTriangle(Point point1, Point point2, Point point3, int deep, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // Координат средин отрезков треугольника.
            Point point4 = new Point(((point2.X + point1.X) / 2), ((point2.Y + point1.Y) / 2));
            Point point5 = new Point(((point3.X + point1.X) / 2), ((point3.Y + point1.Y) / 2));
            Point point6 = new Point(((point2.X + point3.X) / 2), ((point2.Y + point3.Y) / 2));
            Point[] triangle456 = { point4, point5, point6 };
            Point[] triangle246 = { point2, point4, point6 };
            Point[] triangle145 = { point1, point4, point5 };
            Point[] triangle356 = { point3, point5, point6 };
            // Рисуем 4 треугольника (Все кроме среднего цветом следующей глубины рекурсии).
            g.FillPolygon(new SolidBrush(Colors.Gradient(deep)), triangle456);
            g.FillPolygon(new SolidBrush(Colors.Gradient(deep - 1)), triangle246);
            g.FillPolygon(new SolidBrush(Colors.Gradient(deep - 1)), triangle145);
            g.FillPolygon(new SolidBrush(Colors.Gradient(deep - 1)), triangle356);
            // Вызываем рекрсию.
            if (deep != 1 && Math.Abs(point1.X-point2.X) >= 4)
            {
                DrawTriangle(point2, point4, point6, deep - 1, bmp);
                DrawTriangle(point1, point4, point5, deep - 1, bmp);
                DrawTriangle(point3, point5, point6, deep - 1, bmp);
            }
            Picture.Image = bmp;
        }
    }
}