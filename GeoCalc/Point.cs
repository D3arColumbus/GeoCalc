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

        public void set(int x, int y)
        {
            if (x >= 0)
                coordinates[0] = x;
            if (y >= 0)
                coordinates[1] = y;
        }

        public int GetVal(int v)
        {
            if ((v - 1) >= 0)
                return coordinates[v - 1];
            throw new IndexOutOfRangeException("This dimension does not exist!");
        }

        public int GetDistance(Point p)
        {
            if (p.coordinates.Length != this.coordinates.Length)
                throw new ArgumentOutOfRangeException("The two Points have different Dimesions!");
            if (this.coordinates.Length > 2)
                throw new ArgumentOutOfRangeException("The two Points have to many Dimensions!");
            if (this.coordinates.Length < 1)
                throw new ArgumentOutOfRangeException("The two Points have to few Dimesions!");
            if (coordinates.Length == 2)
                return (int)Math.Sqrt((coordinates[0] - p.coordinates[0]) * (coordinates[0] - p.coordinates[0]) + (coordinates[1] - p.coordinates[1]) * (coordinates[1] - p.coordinates[1]));
            if (coordinates.Length == 3)
                return (int)Math.Sqrt((coordinates[0] - p.coordinates[0]) * (coordinates[0] - p.coordinates[0]) + (coordinates[1] - p.coordinates[1]) * (coordinates[1] - p.coordinates[1]) + (coordinates[2] - p.coordinates[2]) * (coordinates[2] - p.coordinates[2]));
            throw new Exception("Something wrong with get distance!");
        }
    }
}
