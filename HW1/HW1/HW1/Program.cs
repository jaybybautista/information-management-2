using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter string: ");
                string word = Console.ReadLine().ToLower();

                string result = "";
                bool isPalindrome = false;

                if (word == "*")
                {
                    break;
                } else {
                    for (int i = word.Length - 1; i >= 0; i--)
                    {
                        result += word[i];

                        
                    }
                    if (result == word)
                    {
                        isPalindrome = true;
                        Console.WriteLine("Original String \t Reversed String \t Palindrome");
                        Console.WriteLine($"   {word}   \t\t    {result} \t\t    {isPalindrome}");
                    }
                    else
                    {
                        Console.WriteLine("Original String \t Reversed String \t Palindrome");
                        Console.WriteLine($"   {word}   \t\t    {result} \t\t    {isPalindrome}");
                    }
                } 
            }
        }
    }
}
