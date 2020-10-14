using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public class GeoArray
    {
        private Geo[] array;

        public GeoArray()
        {
            array = new Geo[10];
        }

        public GeoArray(int length)
        {
            array = new Geo[length];
        }

        public Geo this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public void Println()
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                    array[i].Println();
            }
        }

        public void Println(String name)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null && array[i].Description.Equals(name))
                    array[i].Println();
            }
        }

        public void ReadFrom(String path)
        {

        }

        public void WriteInto(String path)
        {

        }
    }
}
