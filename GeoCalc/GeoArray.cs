using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//Dorner Christof 4CHIF

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
            string[] part;
            StreamReader tr = new StreamReader(path);
            string[] p1;
            string[] p2;
            string[] p3;
            string line = tr.ReadLine();
            while (line != null)
            {
                part = line.Split(';');
                p1 = part[2].Split(',');
                p2 = part[3].Split(',');
                line = tr.ReadLine();
                switch (int.Parse(part[1]))
                {
                    case 1:

                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == null)
                            {
                                array[i] = new Triangle(part[0], new Point(int.Parse(p1[0]), int.Parse(p1[1])), new Point(int.Parse(p2[0]), int.Parse(p2[1])));
                                break;
                            }
                        }
                        break;
                    case 2:
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == null)
                            {
                                array[i] = new Square(part[0], new Point(int.Parse(p1[0]), int.Parse(p1[1])), new Point(int.Parse(p2[0]), int.Parse(p2[1])));
                                break;
                            }
                        }
                        break;
                    case 3:
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == null)
                            {
                                array[i] = new Circle(part[0], new Point(int.Parse(p1[0]), int.Parse(p1[1])), new Point(int.Parse(p2[0]), int.Parse(p2[1])));
                                break;
                            }
                        }
                        break;
                    case 4:
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == null)
                            {
                                array[i] = new Tetrahedron(part[0], new Triangle("genTriangle", new Point(int.Parse(p1[0]), int.Parse(p1[1]), int.Parse(p1[2])), new Point(int.Parse(p2[0]), int.Parse(p2[1]), int.Parse(p2[2]))), int.Parse(part[4]));
                                break;
                            }
                        }
                        break;
                    case 5:
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == null)
                            {
                                array[i] = new Cube(part[0], new Square("genTriangle", new Point(int.Parse(p1[0]), int.Parse(p1[1]), int.Parse(p1[2])), new Point(int.Parse(p2[0]), int.Parse(p2[1]), int.Parse(p2[2]))), int.Parse(part[4]));
                                break;
                            }
                        }
                        break;
                    case 6:
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == null)
                            {
                                array[i] = new Cylinder(part[0], new Circle("genTriangle", new Point(int.Parse(p1[0]), int.Parse(p1[1]), int.Parse(p1[2])), new Point(int.Parse(p2[0]), int.Parse(p2[1]), int.Parse(p2[2]))), int.Parse(part[4]));
                                break;
                            }
                        }
                        break;
                    case 7:
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == null)
                            {
                                array[i] = new Prism(part[0], new Triangle("genTriangle", new Point(int.Parse(p1[0]), int.Parse(p1[1]), int.Parse(p1[2])), new Point(int.Parse(p2[0]), int.Parse(p2[1]), int.Parse(p2[2]))), int.Parse(part[4]));
                                break;
                            }
                        }
                        break;
                }
            }
            tr.Close();

        }

        public void WriteInto(String path)
        {
            StreamWriter sw = new StreamWriter(path);
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                    sw.WriteLine(array[i].Println());
            }
            sw.Close();
        }
    }
}
