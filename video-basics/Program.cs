using System;

namespace videobasics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string myString = "My \"so-called\" life";
            string myString2 = "what if i need a \nnew line";
            string myString3 = @"Go to your c:\ drive";

            string myString4 = string.Format("{1} = {0}", "First", "Second");

            string myString5 = string.Format("{0:C}", 123.45);

            string mystring6 = string.Format("{0:N}", 123456789);

            string mystring7 = string.Format("Percentage: {0:P}", .123);

            string myString8 = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);

            string myString9 = "that summer we tok threes across the board";
            //myString9 = myString.Substring(6,14);
            //myString9 = myString.ToUpper();
            //myString9 = myString.Replace(" ", "--");
            //myString9 = myString.Remove(6, 14);

            myString9 = string.Format("Length before: {0} -- length after: {1}",
                myString.Length,
                myString.Trim().Length);

            string myString10 = "";
            for (int i = 0; i<100; i++)
            {
                myString10 += "--" + i.ToString();
            }

            
        

            Console.WriteLine(myString);
            Console.WriteLine(myString2);
            Console.WriteLine(myString3);
            Console.WriteLine(myString4);
            Console.WriteLine(myString5);
            Console.WriteLine(mystring6);
            Console.WriteLine(mystring7);
            Console.WriteLine(myString8);
            Console.WriteLine(myString9);
            Console.ReadLine();


        }
    }
}
