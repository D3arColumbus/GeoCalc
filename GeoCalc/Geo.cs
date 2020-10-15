using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dorner Christof 4CHIF
namespace GeoCalc
{
    public abstract class Geo
    {
        public String Description { get; set; }

        protected Geo(String description)
        {
            Description = description;
        }

        public abstract int GetArea();
        public abstract int GetCircumference();
        public virtual String Println()
        {
            Console.WriteLine(Description + " " + GetArea() + " " + GetCircumference());
            return Description + " " + GetArea() + " " + GetCircumference();
        }

    }
}
