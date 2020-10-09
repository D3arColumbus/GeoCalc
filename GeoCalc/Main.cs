using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Point point = new Point(10, 10);
            Console.WriteLine(point.GetDistance(new Point(5, 5)));

        }
    }
}
