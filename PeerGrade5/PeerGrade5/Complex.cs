using System;
using System.Collections.Generic;
using System.Text;

namespace PeerGrade5
{
    // Операции над комплексными числами.
    class Complex
    {
        public double a;
        public double b;
        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        // Возведение в квадрат.
        public void Square()
        {
            double temp = (a * a) - (b * b);
            b = 2.0 * a * b;
            a = temp;
        }
        public double Magnitude()
        {
            return Math.Sqrt(a * a + b * b);
        }
        public void Add(Complex c)
        {
            a += c.a;
            b += c.b;
        }
    }
}
