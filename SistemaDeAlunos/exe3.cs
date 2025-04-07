using System;
using System.Globalization;

namespace SistemaDeAlunos
{
    public class Exe3
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a terceira nota:");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"A média das suas notas é: {media:F2}");
        }
    }
}