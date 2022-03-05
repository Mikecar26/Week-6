using System;

namespace program
{
    public class Program
    {
        static void Main()
        {
            ProblemOne();
            ProblemTwo();
        }
        static void ProblemOne()
        {
            List<string> input = new List<string>();

            Console.WriteLine("Enter the names of the person who liked your photo. Otherwise press enter.");
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "")
                    break;
                input.Add(name);
            }
            if (input.Count == 0)
                Console.WriteLine("");
            else if (input.Count == 1)
                Console.Write(input);
            else if (input.Count == 2)
            {
                Console.Write(input[0] + " and " + input[1]);
            }
            else
            {
                Console.Write(input[0] + ", " + input[1] + " and " + (input.Count() - 2) + " others");
            }
            Console.Write(" liked your post");
        }
        static void ProblemTwo()
        {
            Dictionary<char, int> histograph = new Dictionary<char, int>();
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            foreach (char c in input)
            {
                if (c == ' ')
                    continue;
                if (histograph.ContainsKey(c))
                    histograph[c] += 1;
                else
                    histograph.Add(c, 1);
            }
            foreach (KeyValuePair<char,int> i in histograph)
                Console.WriteLine(i);
        }
    }
}