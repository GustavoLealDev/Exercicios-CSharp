using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Digite valor de Linhas e Colunas: ");
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int [M, N];

            for (int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            foreach (int i in mat) 
            { 
                Console.WriteLine(i);
            }

        }
    }
}