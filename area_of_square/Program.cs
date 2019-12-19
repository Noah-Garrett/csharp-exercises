using System;

namespace area_of_square
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Yo yo yo! what's the length of that reccy boi?:");

            string length = Console.ReadLine();
            int ilength = int.Parse(length);

            Console.WriteLine("siiiiiiiiiiiiick. sick sick sick. what's that wiiiiiiide width tho?:");

            string width = Console.ReadLine();
            int iwidth = int.Parse(width);

            int area = iwidth * ilength;

            Console.WriteLine(" ayooooooo000000!!!! that boi is " + area);





        }
    }
}
