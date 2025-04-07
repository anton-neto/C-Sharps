using System;

namespace SistemaDeAlunos
{
    public class Exe2
    {
        public static void Executar()
        {
            Console.WriteLine("Qual seu ano de nascimento:");
            int anoNascimento = int.Parse(Console.ReadLine());
            int idade = 2024 - anoNascimento;
            Console.WriteLine($"Você tem {idade} anos.");
        }
    }
}
