using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public class Triangle : Geo2D
    {
        public Triangle(String documents, Point p1, Point p2) : base(documents, p1, p2)
        {

        }

        public override int GetArea() => (int)((Math.Sqrt(3) / 4) * P1.GetDistance(P2) * P1.GetDistance(P2));
        public override int GetCircumference() => (int)P1.GetDistance(P2) * 3;
    }
}
