using System;
using System.Globalization;

namespace SistemaDeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("1. Nome e Saudação");
                Console.WriteLine("2. Calculo de Idade");
                Console.WriteLine("3. Média de Notas");
                Console.WriteLine("4. Maior Número");
                Console.WriteLine("5. Verificar Par ou Ímpar");
                Console.WriteLine("6. Sair");
                Console.Write("Qual opção tu quer? ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // Exercício 1
                        Console.WriteLine("Qual seu nome piazão?");
                        string nome = Console.ReadLine();
                        Console.WriteLine($"Fala, {nome}!");
                        break;

                    case 2:
                        // Exercício 2
                        Console.WriteLine("Nasceu que ano? ");
                        int anoNascimento = int.Parse(Console.ReadLine());
                        int idade = 2024 - anoNascimento;
                        Console.WriteLine($"Irmão, se tem {idade} anos.");
                        break;

                    case 3:
                        // Exercício 3
                        Console.WriteLine("Qual a primeira nota? ");
                        double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("E a segunda nota? ");
                        double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("Agora a terceira nota: ");
                        double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        double media = (nota1 + nota2 + nota3) / 3;
                        Console.WriteLine($"A média das suas notas é: {media:F2}");
                        break;

                    case 4:
                        // Exercício 4
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
                        break;

                    case 5:
                        // Exercício 5
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
                        break;

                    case 6:
                        Console.WriteLine("Flw fi!");
                        break;

                    default:
                        Console.WriteLine("Escolheu errado, temte de novo!");
                        break;
                }

                Console.WriteLine(); 
            }
            while (opcao != 6); 
        }
    }
}
