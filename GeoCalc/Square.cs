using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public class Square : Geo2D
    {
        //Punkte müssen angrenzend sein
        public Square(String d, Point p1, Point p2) : base(d,p1,p2)
        {

        }

        public override int GetArea() => P1.GetDistance(P2) * P1.GetDistance(P2);
        public override int GetCircumference() => P1.GetDistance(P2) * 4;
    }
}
