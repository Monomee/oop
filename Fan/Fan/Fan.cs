using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    public class Fan
    {
        private const int MEDIUM = 2;
        private const int FAST = 3;
        private int SLOW = 1;
        //private int speed
        //{
        //    get => SLOW;
        //    set
        //    {
        //        if (value == 2)
        //        {
        //            SLOW = MEDIUM;
        //        }else if (value == 3)
        //        {
        //            SLOW = FAST;
        //        }
        //    }
        //}
        private int speed = 1;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";

        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public int Speed { get => speed; set => speed = value; }

        public Fan()
        {
        }

        public override string ToString()
        {
            if (on)
            {
                return "Speed: " + speed + ", Color: " + color + ", Radius: " + radius + ", fan is on.";
            }
            else
            {
                return "Color: " + color + ", Radius: " + radius + ", fan is off.";
            }
        }
    }
}
