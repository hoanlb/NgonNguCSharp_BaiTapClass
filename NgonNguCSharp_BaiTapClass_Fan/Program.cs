using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp_BaiTapClass_Fan
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan(3, 10, "Yellow", true);
            Fan fan2 = new Fan(2, 5, "Blue", false);

            fan1.ToString(3, 10, "Yellow", true);
            fan2.ToString(2, 5, "Blue", false);

            Console.ReadKey();
        } 
    }

    public class Fan
    {
        public Fan(int speed, double radius, string color, bool on)
        {
            speed = 1;
            on = false;
            radius = 5;
            color = "Blue";
        }

        public void ToString(int speed, double radius, string color, bool on)
        {
            if (on == true)
            {
                Console.WriteLine("Fan 's speed is: " + speed);
                Console.WriteLine("Fan 's color is: " + color);
                Console.WriteLine("Fan 's radius is: " + radius);
                Console.WriteLine("Fan is on");
                Console.WriteLine();
            } 
            else
            {
                Console.WriteLine("Fan 's color is: " + color);
                Console.WriteLine("Fan 's radius is: " + radius);
                Console.WriteLine("Fan is off");
                Console.WriteLine();
            }
        }
    }
}
