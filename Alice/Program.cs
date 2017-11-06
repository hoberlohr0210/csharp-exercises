using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            string input;
            
            

            Console.WriteLine("What word are you looking for?");
            input = Console.ReadLine();
            
            sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            if (sentence.Contains(input))
                { Console.WriteLine("true"); Console.ReadLine(); }

            else
                { Console.WriteLine("false"); Console.ReadLine(); }
        }
    }
}
