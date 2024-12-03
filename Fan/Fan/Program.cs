using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            Fan fan2 = new Fan();

            fan1.Speed = 3;
            fan1.Radius = 10;
            fan1.Color = "yellow";
            fan1.On = true;

            fan2.Speed = 2;
            fan2.Radius = 5;
            //fan2.Color = "blue";
            //fan2.On = false;

            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());

            Console.ReadLine();
        }
    }
}
