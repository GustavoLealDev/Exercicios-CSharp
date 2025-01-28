using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Digite valor de Linhas e Colunas: ");
            Console.Write("Digite o número de linhas: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas: ");
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
            
            
            Console.WriteLine();
            Console.WriteLine("Digite um número para saber a posição:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Posição: " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Número a esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Número acima: " + mat[i - 1, j]);
                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine("Número a direita: " + mat[i, j + 1]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Número abaixo: " + mat[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}