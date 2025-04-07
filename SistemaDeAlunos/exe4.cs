using System;

namespace SistemaDeAlunos
{
    public class Exe4
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"O maior número é: {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"O maior número é: {numero2}");
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }
        }
    }
}
