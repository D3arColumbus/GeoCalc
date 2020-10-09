using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public abstract class Geo2D : Geo
    {
        protected Point P1 { get; set; }
        protected Point P2 { get; set; }



        protected Geo2D(String d, Point p1, Point p2) : base(d)
        {
            P1 = p1;
            P2 = p2;
        }

    }
}
