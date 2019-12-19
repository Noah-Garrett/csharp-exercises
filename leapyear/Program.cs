using System;

namespace leapyear
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(IsLeap(2000));

        

           

        }

        public static bool IsLeap(int year) {
            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else if (year % 100 == 0 && year % 400 == 0) {
                return true;
            }
            else {
                return false;
            }


        }
    }

}
