using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor de linhas: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Valor de colunas: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Digite o numero para busca: ");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i, j] == num)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Numero de repetições: "+count);
            
            Console.WriteLine("=======================");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i, j] == num)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < m - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < n - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
    // Console.WriteLine(matriz.Length);
    // Console.WriteLine(matriz.Rank);
}
