
using System;

class GFG
{


    public static void Main()
    {

        int[][,] jagged_arr = new int[3][,]
        {
            new int[,] {{12,15,13} ,{45,41,52} ,{11,25,14} },
            new int[,] {{22,35,83} ,{15,21,32} ,{21,55,24} },
            new int[,]  {{52,45,73} ,{65,71,12} ,{51,35,64} },
        };

        for (int i = 0; i < jagged_arr.Length;i++)
        {
            Console.Write("\n");
            for(int j= 0; j < jagged_arr[i].GetLength(0);j++)
            {
                for (int k = 0; k < jagged_arr[i].GetLength(1); k++)
                {
                    Console.Write(jagged_arr[i][j, k] );
                    Console.Write("\t");
                }
                Console.Write('\n');
            }
        }
        Console.ReadLine();
    }
}
