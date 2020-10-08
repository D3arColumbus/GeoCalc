using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public class Point
    {
        int[] coordinates;
        public Point(params int[] param)
        {
            coordinates = new int[param.Length];
            int i = 0;

            foreach(int element in param)
            {
                coordinates[i++] = element;
            }
        }


    }
}
