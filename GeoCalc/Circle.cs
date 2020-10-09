using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public class Circle : Geo2D
    {
        public Circle(String description, Point p1, Point p2) : base (description, p1, p2)
        {

        }

        public override int GetArea() => (int)(P1.GetDistance(P2) * P1.GetDistance(P2) * Math.PI);
        public override int GetCircumference() => (int)(P1.GetDistance(P2) * 2 * Math.PI);
    }
}
