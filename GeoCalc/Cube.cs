namespace GeoCalc
{
    public class Cube : Geo3D
    {
        public Cube(string description, Geo2D baseFigure, int height) : base(description, baseFigure, height)
        {

        }

        public override int GetArea() => BaseFigure.GetArea() * Height;
        public override int GetCircumference() => BaseFigure.GetCircumference();
    }
}