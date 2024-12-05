using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5, "red");
            Cylinder cylinder = new Cylinder(9, "yellow", 3);
            Console.WriteLine(circle.getArea());
            Console.WriteLine(cylinder.getVolumn());
            Console.ReadLine();
        }
    }
}
