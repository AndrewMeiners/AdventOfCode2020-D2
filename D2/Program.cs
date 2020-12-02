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

                /* P1
                int min = Convert.ToInt32(parts[0]);
                int max = Convert.ToInt32(parts[1]);
                char searchChar = Convert.ToChar(parts[2]);
                string passwordString = parts[4];

                
                int charOccuranceCount = passwordString.Count(s => s == searchChar);

                if (min <= charOccuranceCount && charOccuranceCount <= max) validPasswordCount++;
                */

                // P2
                int index1 = Convert.ToInt32(parts[0]) - 1;
                int index2 = Convert.ToInt32(parts[1]) - 1;
                char searchChar = Convert.ToChar(parts[2]);
                string passwordString = parts[4];

                if ((passwordString[index1] == searchChar && passwordString[index2] != searchChar) || (passwordString[index2] == searchChar && passwordString[index1] != searchChar))
                {
                    validPasswordCount++;
                }
            }
            Console.WriteLine(validPasswordCount);
        }
    }
}
