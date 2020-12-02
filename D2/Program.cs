using System;
using System.Linq;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiterChars = { ' ', '-', ':' };
            int validPasswordCount = 0;
            string[] lines = System.IO.File.ReadAllLines(@"D2.txt");

            foreach (string line in lines)
            {
                // delims = ' ', '-', ':'
                string[] parts = line.Split(delimiterChars);

                int min = Convert.ToInt32(parts[0]);
                int max = Convert.ToInt32(parts[1]);
                char searchChar = Convert.ToChar(parts[2]);
                string passwordString = parts[4];

                //Console.WriteLine(min);
                //Console.WriteLine(max);
                //Console.WriteLine(searchChar);
                //Console.WriteLine(passwordString);

                int charOccuranceCount = passwordString.Count(s => s == searchChar);

                if (min <= charOccuranceCount && charOccuranceCount <= max) validPasswordCount++;
            }
            Console.WriteLine(validPasswordCount);
        }
    }
}
