using System;

namespace SistemaDeAlunos
{
    public class Exe5
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número para verificar se é par ou ímpar:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}
