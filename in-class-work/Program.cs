using System.Collections.Generic;

namespace SumEvenNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Initialize our nums list with 10 int values
            List<int> nums = new List <int>() { 1, 5, 8, 11, 12, 4, 7, 8, 9, 19  };

            // call sumevennumbers menthod, passing in nums li
            // accet return value from sumevennumbers in to
            int sum = SumEvenNumbers(nums);
            System.Console.WriteLine("Sum " + sum);
              
        }

        //declare our sumevennumbers method, with a list par
        //sumevennumbers will return a value of type int
        public static int SumEvenNumbers(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    sum += list[i];
                }
            }
            return sum;
        }
    }
}
