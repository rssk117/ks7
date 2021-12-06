using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ксюша_7
{
    class Triangle : Triad
    {
        public void Corners(out double corner1, out double corner2, out double corner3)
        {
            //формула есть в папке с программой
            double a = Number1;
            double b = Number2;
            double c = Number3;
            corner1 = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
            corner2 = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
            corner3 = 180 - corner1 - corner2;
        }
        public double S()
        {
            //вычесляем площадб по формуле Герона
            double p = (Number1 + Number2 + Number3) / 2.0;
            return (Math.Sqrt(p * (p - Number1) * (p - Number2) * (p - Number3)));
        }
    }
}
