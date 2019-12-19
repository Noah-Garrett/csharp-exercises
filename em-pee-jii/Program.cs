using System;

namespace empeejii
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("how far have you traveled in your motorized vehile since your previous entry into the computational subrotines contained within this simplistic yet effective calculator?");
            string distance = Console.ReadLine();
            double dub_distance = double.Parse(distance);
            

            Console.WriteLine("and how many units of compustable hybrid fluid produced by undergound resources whose cascading depletion rates will one day cause a collapse of the known world unless adjustments to civilization as you know it occur:?");
            string gas = Console.ReadLine();
            double dub_gas = double.Parse(gas);
            

            double avg = dub_distance / dub_gas;

            Console.WriteLine("your average distance achieved utilizing a singular gallon of dinosuars is " + avg);
            
        }
    }
}