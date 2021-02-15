using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace PeerGrade5
{
    // Получение цыета для рисования факториала.
    class GetColor
    {
        // Первый цвет.
        public Color FirstColor { get; set; }
        // Второй цвет.
        public Color SecondColor { get; set; }
        // Глуюина рекурсии.
        public int Deep { get; set; }
        public GetColor(Color firstColor, Color secondColor, int deep)
        {
            FirstColor = firstColor;
            SecondColor = secondColor;
            Deep = deep;
        }
        // Получение градиента.
        public Color Gradient(int deep)
        {
            // Выходной цвет = текущая глубина*(Второй цвет - первый)/глубина рекурсии.
            return (Color.FromArgb(FirstColor.R + deep * (SecondColor.R - FirstColor.R) / Deep, FirstColor.G + deep * (SecondColor.G - FirstColor.G) / Deep, FirstColor.B + deep * (SecondColor.B - FirstColor.B) / Deep));
        }
    }
}
