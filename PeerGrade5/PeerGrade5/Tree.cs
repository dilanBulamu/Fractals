using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace PeerGrade5
{
    class Tree:Fractal
    {
        public int FirstAngle { get; set; }
        public int SecondAngle { get; set; }
        public double Ratio { get; set; }
        public Tree(int length, int deep, int firstAngle, int secondAngle, double ratio, PictureBox picture, GetColor colors) : base(length, deep, picture, colors)
        {
            FirstAngle = firstAngle;
            SecondAngle = secondAngle;
            Ratio = ratio;
        }
        public void Draw(int x, int y, int length, int firstAngle, int secondAngle, int deep, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            double x1 = x + length * Math.Sin(Math.PI * firstAngle / 180.0);
            double y1 = y + length * Math.Cos(Math.PI * secondAngle / 180.0);
            if (deep != 0 && length >= 1)
            {
                Draw((int)x1, (int)y1, (int)(length / Ratio), firstAngle + FirstAngle, secondAngle + FirstAngle, deep - 1, bmp);
                Draw((int)x1, (int)y1, (int)(length / Ratio), firstAngle - SecondAngle, secondAngle - SecondAngle, deep - 1, bmp);
            }
            g.DrawLine(new Pen(Colors.Gradient(deep), length / 7), x, Picture.Height - y, (int)x1, Picture.Height - (int)y1);
            Picture.Image = bmp;
        }
    }
}
