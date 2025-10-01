using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        
        static Dictionary<char, int> GetCharFrequency(string input)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ') continue; 

                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            return freq;
        }

        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(',');

            foreach (string part in parts)
            {
                string word = part.Trim(); 
                Dictionary<char, int> freq = GetCharFrequency(word);

                bool first = true;

                foreach (var kvp in freq)
                {
                    if (!first)
                        Console.Write(", ");
                    Console.Write(kvp.Key + "=" + kvp.Value);
                    first = false;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

