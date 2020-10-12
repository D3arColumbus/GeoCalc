namespace GeoCalc
{
    public class Cylinder : Geo3D
    {
        public Cylinder(string description, Geo2D baseFigure, int height) : base(description, baseFigure, height)
        {

        }

        public override int GetArea() => BaseFigure.GetArea() * Height;
        public override int GetCircumference() => BaseFigure.GetCircumference();
    }
}