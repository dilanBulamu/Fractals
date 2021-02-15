using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace PeerGrade5
{
    // Множество Кантора.
    class Cantor : Fractal
    {
        private int Distance { get; set; }
        public Cantor(int length, int deep, int distance, PictureBox picture, GetColor colors) : base(length, deep, picture, colors) 
        {
            Distance = distance;
        }
        // Метод для рисовки множества.
        public void DrawCantor(int x, int y, int deep, int length, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            if (deep != 0 && length >= 3)
            {
                g.DrawRectangle(new Pen(Colors.Gradient(deep), 1), x, y, length, 40);
                g.FillRectangle(new SolidBrush(Colors.Gradient(deep)), x, y, length, 40);
                Picture.Image = bmp;
                DrawCantor(x + length * 2 / 3, y + Distance, deep - 1, length / 3, bmp);
                DrawCantor(x, y + Distance, deep - 1, length / 3, bmp);
            }
        }
    }
}
