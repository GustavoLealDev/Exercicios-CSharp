using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
           Alunos alunos = new Alunos();
            
            Console.WriteLine("Digite o dados do Aluno: ");
            Console.Write("Nome: ");
            alunos.Nome = Console.ReadLine();
            Console.Write("Digite a nota da AV1: ");
            alunos.AV1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da AV2: ");
            alunos.AV2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da AV3: ");
            alunos.AV3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final: " + alunos.NotaFinal().ToString("F2"));
            

            if (alunos.Media())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("Faltou " + alunos.AprovOrReprov().ToString("F2") + " Pontos!!");
                Console.WriteLine("REPROVADO");
            }
        
        }
    }
}
