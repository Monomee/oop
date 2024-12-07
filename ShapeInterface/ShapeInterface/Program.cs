using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Random random = new Random();

            //Array of Objects
            Shape[] shapes = new Shape[]
            {
                new Circle(3.5),
                new Rectangle(5.6, 6.5),
                new Square(2.3),
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(i+".");
                Console.WriteLine("Before: " + shape.ToString());
                Console.WriteLine(shape.getArea());
                if (shape is IColorable icolorableShape)
                {
                    icolorableShape.HowToColor();
                }
                if (shape is Resizeable resizeableShape)
                {
                    int percent = random.Next(1, 101);
                    resizeableShape.Resize(percent);
                    Console.WriteLine("After: increase " + percent + "% " + resizeableShape.ToString());
                }
                i++;
            }



            Console.ReadLine();
        }
    }
}
