using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public class Tetrahedron : Geo3D
    {
        public Tetrahedron(string description, Geo2D baseFigure, int height) : base(description, baseFigure, height)
        {
        }

        public override int GetArea() => (int)(BaseFigure.GetArea() * Height * 0.33333333333333);
        public override int GetCircumference() => BaseFigure.GetCircumference();
    }
}
