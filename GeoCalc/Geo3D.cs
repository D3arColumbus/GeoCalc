using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dorner Christof 4CHIF
namespace GeoCalc
{
    public abstract class Geo3D : Geo
    {
        public int Height { set; get; }
        private Geo2D baseFigure;
        public Geo2D BaseFigure
        {
            set
            {
                baseFigure = value; 
            }
            get
            {
                return baseFigure;
            }
        }
        public Geo3D(String description, Geo2D baseFigure, int height) : base(description)
        {
            BaseFigure = baseFigure;
            Height = height;
        }

        public override int GetArea() => BaseFigure.GetArea();

        public override int GetCircumference() => BaseFigure.GetCircumference();

        public virtual int GetVolume() => BaseFigure.GetArea() * Height;

        public virtual int GetSurfaceArea() => BaseFigure.GetArea() * 2 + BaseFigure.GetCircumference() * Height;

        public override String Println()
        {
            Console.WriteLine(Description + " " + GetArea() + " " + GetCircumference() + " " + GetVolume() + " " + GetSurfaceArea());
            return Description + " " + GetArea() + " " + GetCircumference() + " " + GetVolume() + " " + GetSurfaceArea();
        }



    }
}
