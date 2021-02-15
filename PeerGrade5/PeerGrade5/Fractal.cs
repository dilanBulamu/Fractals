using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace PeerGrade5
{
    // Общий класс фракталов.
    class Fractal
    {
        public int Length { get; set; }
        public int Deep { get; set; }
        public PictureBox Picture { get; set; }
        public GetColor Colors { get; set; }
        public Fractal(int length, int deep, PictureBox picture, GetColor colors)
        {
            Length = length;
            Deep = deep;
            Picture = picture;
            Colors = colors;
        }
    }
}
