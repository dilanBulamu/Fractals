using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace PeerGrade5
{
    // Множество Мондельброта.
    class Bonus
    {
        public PictureBox Picture { get; set; }
        public Bonus(PictureBox picture)
        {
            Picture = picture;
        }
        // Метод для рисовки множества.
        public void DrawMandelbrot(Bitmap bmp)
        {
            // Вот тут сложно.
            for (int i = 0; i < Picture.Width; i++)
            {
                for (int j = 0; j < Picture.Height; j++)
                {
                    double a = (double)(i - (Picture.Width / 2)) / (double)(Picture.Height / 4);
                    double b = (double)(j - (Picture.Width / 2)) / (double)(Picture.Height / 4);
                    Complex c = new Complex(a, b);
                    Complex z = new Complex(0, 0);
                    int it = 0;
                    do
                    {
                        it++;
                        z.Square();
                        z.Add(c);
                        if (z.Magnitude() > 2.0)
                        {
                            break;
                        }
                    }
                    while (it < 100);
                    // Если точка входит во множество, то закрашиваем ее.
                    bmp.SetPixel(i, j, it < 100 ? Color.FromArgb(it, it, it) : Color.FromArgb(255, 255, 255));
                }
            }
            Picture.Image = bmp;
        }
    }
}
