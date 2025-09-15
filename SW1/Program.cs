using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    class Program
    {
        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;

            if (n % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
               if (n % i == 0) return false;
            }

            return true;
        }
        static (double peso, double yen) convertMoney(double mon)
        {
            double pesoMon = mon * 57.17;
            double yenMon = mon * 146.67;

            return (pesoMon, yenMon);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string nums = Console.ReadLine();

            string[] values = nums.Trim().Split(' '); ;
            for (int i = 0; i < values.Length;i++)
            {
                int number = int.Parse(values[i]);
                string printPrime = isPrime(number) ? $"{i + 1}. {values[i]} Prime" : $"{i + 1}. {values[i]} Composite";
                Console.WriteLine(printPrime);
            }

            Console.Write("Enter currency in ($): ");
            string money = Console.ReadLine();

            string[] currMoney = money.Trim().Split(' ');
            Console.WriteLine("Dollar($) \t Phil Peso(P) \t Jpn Yen(Y)");
            for (int j = 0; j < currMoney.Length; j++)
            {
                var arrMoney = double.Parse(currMoney[j]);

                Console.WriteLine($"{currMoney[j]} \t         {convertMoney(arrMoney).peso}      \t {convertMoney(arrMoney).yen}");
            }

            Console.ReadKey();
        }
    }
}
