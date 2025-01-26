using System;
using System.Globalization;

namespace Course
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Estudantes> list = new List<Estudantes>();

            Console.Write("Digite quantos estudantes você ira digitar: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Aluno {i}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Nota 1: ");
                double nota1 = double.Parse(Console.ReadLine());
                Console.Write("Nota 2: ");
                double nota2 = double.Parse(Console.ReadLine());
                Console.Write("Nota 3: ");
                double nota3 = double.Parse(Console.ReadLine());
                list.Add(new Estudantes(name, idade, nota1, nota2, nota3));
                Console.WriteLine();
            }

            Console.WriteLine("Alunos : ");
            foreach (Estudantes obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            
            Console.WriteLine("Digite o nome do aluno para exclui-lo: ");
            string nameExc = Console.ReadLine();
            var estudanteExcluir = list.Find(x => x.Name == nameExc);

            if(estudanteExcluir != null)
            {
                list.Remove(estudanteExcluir);
                Console.WriteLine("Estudante excluído!!");
            } else {
                Console.WriteLine("Estudante não encontrado");
            }

            Console.WriteLine();

            Console.WriteLine("Alunos Atualizados : ");
            foreach (Estudantes obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}

// Adicionei excluir aluno
