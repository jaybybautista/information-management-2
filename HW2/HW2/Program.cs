using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double average = 0;

            List<List<double>> numList = new List<List<double>>();

            Console.Write("Enter row: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter column: ");
            int col = Convert.ToInt32(Console.ReadLine());

            double nums;

            for (int x = 0; x < row; x++)
            {
                List<double> tempList = new List<double>();
                Console.WriteLine($"Row {x + 1}");
                for (int y = 0; y < col; y++)
                    
                {
                    Console.Write($"Enter number {y + 1}: ");
                    nums = Convert.ToDouble(Console.ReadLine());
                    tempList.Add(nums);
                }
                numList.Add(tempList);
            }
         
            

            Console.WriteLine("\nThe numbers are:");
            for (int i = 0; i < numList.Count; i++)
            {
                for (int l = 0; l < numList[i].Count; l++)
                {
                    sum += numList[i][l];
                    
                    Console.Write($"{numList[i][l]} ");
                    
                    
                }
                Console.WriteLine();

            }
            int ave = row * col;
            average = sum / ave;
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");

            Console.ReadKey();
        }
    }
}
