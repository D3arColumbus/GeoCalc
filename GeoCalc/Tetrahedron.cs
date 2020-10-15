using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dorner Christof 4CHIF
namespace GeoCalc
{
    public class Tetrahedron : Geo3D
    {
        public Tetrahedron(string description, Geo2D baseFigure, int height) : base(description, baseFigure, height)
        {
        }
        
        public override int GetVolume() => (int)(GetCircumference() * GetCircumference() * Math.Sqrt(3) + Height) / 12;

        public override int GetSurfaceArea() => (int)(BaseFigure.GetArea() * Height * 0.33333333333333);

    }
}
