using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void GetCharFrequency(string input, Dictionary<char, int> freq)
        {
            foreach (char c in input)
            {
                if (c == ' ') continue; 

                if (freq.ContainsKey(c))
                {
                    freq[c]++; 
                }
                else
                {
                    freq[c] = 1; 
                }
            }
        }

        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(',');

            foreach (string part in parts)
            {
                string word = part.Trim();
                Dictionary<char, int> freq = new Dictionary<char, int>();

                GetCharFrequency(word, freq);

                bool first = true;

                foreach (KeyValuePair<char, int> item in freq)
                {
                    if (!first)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(item.Key + "=" + item.Value);
                    first = false;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
