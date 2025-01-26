using System;
using System.Collections.Generic;

namespace Course
{
     class Estudantes
    {
        public string Name { get; set; }
        public int Idade { get; set; }
        public double Nota1, Nota2, Nota3;

        public Estudantes(string name, int idade)
        {
            Name = name;
            Idade = idade;
        }

        public Estudantes(string name, int idade, double nota1, double nota2, double nota3) : this(name, idade)
        { 
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double NotaF() 
        { 
            return (Nota1 + Nota2 + Nota2) / 3;
        }

        public override string ToString()
        {
            return "Aluno: " + Name + ", Idade: " + Idade + ", Nota: " + NotaF().ToString("F2");
        }
    }
}
