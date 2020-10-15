using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dorner Christof 4CHIF
namespace GeoCalc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GeoArray array = new GeoArray();
            array.ReadFrom("geocalc.txt");
            array.Println();
            array.WriteInto("geocalcOut.txt");

        }
    }
}
