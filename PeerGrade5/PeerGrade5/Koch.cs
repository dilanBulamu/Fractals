using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace PeerGrade5
{
    // Кривая коха.
    class Koch:Fractal
    {
        public Koch(int length, int deep, PictureBox picture, GetColor colors) : base(length, deep, picture, colors) { }
        // Метод рисования кривой.
        public void DrawKoch(int x1, int y1, int x2, int y2, int deep, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double height = length / (2 * Math.Sqrt(3));
            // Делим отрезок на три части и запоминаем координаты среднего.
            int x3 = x1 + (int)((x2 - x1) / 3.0);
            int y3 = y1 + (int)((y2 - y1) / 3.0);
            int x4 = x1 + (int)(2 * (x2 - x1) / 3.0 + 0.5);
            int y4 = y1 + (int)(2 * (y2 - y1) / 3.0 + 0.5);
            // Находим координаты второй точки высоты среднего треугольника.
            int x5 = (int)((x1 + x2) / 2.0 + height * (y2 - y1) / length);
            int y5 = (int)((y1 + y2) / 2.0 - height * (x2 - x1) / length);
            // Вызываем рекурсию.
            if (deep != 1 && length >= 9)
            {
                DrawKoch(x1, y1, x3, y3, deep - 1, bmp);
                DrawKoch(x3, y3, x5, y5, deep - 1, bmp);
                DrawKoch(x4, y4, x2, y2, deep - 1, bmp);
                DrawKoch(x5, y5, x4, y4, deep - 1, bmp);
            }
            // Чертим кривую.
            else
            {
                Pen pen = new Pen(Colors.Gradient(deep));
                g.DrawLine(pen, x1, y1, x3, y3);
                g.DrawLine(pen, x3, y3, x5, y5);
                g.DrawLine(pen, x5, y5, x4, y4);
                g.DrawLine(pen, x4, y4, x2, y2);
                Picture.Image = bmp;
            }

        }
    }
}
