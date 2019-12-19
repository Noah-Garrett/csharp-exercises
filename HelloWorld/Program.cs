using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("gimme that width, hot boi!");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a height my man!");
            int height = int.Parse(Console.ReadLine());

            int area = width * height;

            Console.WriteLine("The area of the rectangle was " + area);
        }
    }
}
