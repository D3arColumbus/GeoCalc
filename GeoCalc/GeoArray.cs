using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public class GeoArray
    {
        public int Length { get; }

        public GeoArray()
        {
            Length = 10;
        }

        public GeoArray(int length)
        {
            Length = length;
        }

        public void insert(Square square) => throw new NotImplementedException();
    }
}
