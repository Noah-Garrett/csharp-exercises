using System;

namespace somethingsomethingstrings
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            int indexOfSearchTerm;
            string guess;
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, " +
                "'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine(alice);
            Console.WriteLine("yo, guess if a word is in a mystery phrase!");
            guess = Console.ReadLine();

            indexOfSearchTerm = alice.IndexOf(guess);

            Console.WriteLine("was term found? " + (indexOfSearchTerm >= 0));
           

           


        }
    }
}
