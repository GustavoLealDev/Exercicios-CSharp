using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> direito = new HashSet<int>();
            HashSet<int> administração = new HashSet<int>();
            HashSet<int> turismo = new HashSet<int>();

            try
            {
                Console.Write("Quantos alunos fazem Direito? ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"Código do aluno {i}: ");
                    int codigo = int.Parse(Console.ReadLine());
                    direito.Add(codigo);
                }

                Console.WriteLine();
                Console.Write("Quantos alunos fazem Administração? ");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"Código do aluno {i}: ");
                    int codigo = int.Parse(Console.ReadLine());
                    administração.Add(codigo);
                }

                Console.WriteLine();
                Console.Write("Quantos alunos fazem Turismo? ");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"Código do aluno {i}: ");
                    int codigo = int.Parse(Console.ReadLine());
                    turismo.Add(codigo);
                }

                Console.WriteLine();
                HashSet<int> all = new HashSet<int>(direito);
                all.UnionWith(administração);
                all.UnionWith(turismo);
                Console.WriteLine("Total de Estudantes: " + all.Count);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
            }
        }
    }
}