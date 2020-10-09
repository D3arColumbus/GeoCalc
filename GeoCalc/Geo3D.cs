using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public class Geo3D : Geo
    {
        public Geo3D(String description) : base(description)
        {

        }

        public override int GetArea() => throw new NotImplementedException();
        public override int GetCircumference() => throw new NotImplementedException();
        public override String Println() => throw new NotImplementedException();
    }
}
