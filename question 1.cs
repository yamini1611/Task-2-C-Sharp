using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Rows :");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Columns :");
            int columns = int.Parse(Console.ReadLine());

            int[,] Arr = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter values for rows and columns [{i} {j}] ");
                    Arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Printing values of rows and columns ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(Arr[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
