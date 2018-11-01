using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
    class TestPoint3D
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(0, 0, 0);
            Point3D p2 = new Point3D(5, 5, 0);

            Console.WriteLine("Distance from p1 to p2 is {0}", p1.Distance(p2));

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Console.Read();
        }
    }

    class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            MoveTo(x, y, z);
        }

        public void MoveTo(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Distance(Point3D p)
        {
            return Math.Sqrt(Math.Pow((X - p.X), 2) + Math.Pow((Y - p.Y), 2) + Math.Pow((Z - p.Z), 2));
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ", " + Z + ")";
        }
    }
}
