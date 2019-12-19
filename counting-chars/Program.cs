using System;
using System.Collections.Generic;
using System.Linq;

namespace countingchars
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> counts = CountCharacters(text);
            foreach (KeyValuePair<char, int> item in counts)
                Console.WriteLine(item);
            
        }



        public static Dictionary<char, int> CountCharacters(string gopher)
        {
            Dictionary<char, int> dict2go = new Dictionary<char, int>();

            foreach (char letter in gopher)
            {

                if (dict2go.ContainsKey(letter))
                {

                    dict2go[letter]++;
                }

                else
                {
                    dict2go.Add(letter, 1);
                }

            }
            return dict2go;
        }   
    }
}