using System;
using System.Globalization;

namespace SistemaDeAlunos{

    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite ae seu nome");
        string nome = Console.ReadLine();

        Console.WriteLine("qual a primeira nota");
        double nota1 = double.Parse(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        Console.WriteLine("e qual a segunda nota");
        double nota2 = double.Parse(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        Aluno aluno = new Aluno(nome, nota1, nota2);

        aluno.ExibirResultado();
    }
}
}



// {
//         bool continuar = true; 

//         while (continuar)
//         {
//             Console.Clear();
//             Console.WriteLine("Bem-vindo à calculadora!");
//             Console.WriteLine("Escolha uma operação:");
//             Console.WriteLine("1 - Soma");
//             Console.WriteLine("2 - Subtração");
//             Console.WriteLine("3 - Multiplicação");
//             Console.WriteLine("4 - Divisão");
//             Console.WriteLine("5 - Porcentagem");
//             Console.WriteLine("6 - Fração");
//             Console.WriteLine("7 - Potenciação");
//             Console.WriteLine("8 - Sair");

//             int opcao = Convert.ToInt32(Console.ReadLine());

//             if (opcao == 8)
//             {
//                 continuar = false; 
//                 Console.WriteLine("Obrigado por usar a calculadora!");
//                 break;
//             }

//             double num1, num2, resultado = 0;

//             switch (opcao)
//             {
//                 case 1: 
//                     Console.Write("Digite o primeiro número: ");
//                     num1 = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Digite o segundo número: ");
//                     num2 = Convert.ToDouble(Console.ReadLine());
//                     resultado = num1 + num2;
//                     Console.WriteLine("Resultado: " + resultado);
//                     break;

//                 case 2: 
//                     Console.Write("Digite o primeiro número: ");
//                     num1 = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Digite o segundo número: ");
//                     num2 = Convert.ToDouble(Console.ReadLine());
//                     resultado = num1 - num2;
//                     Console.WriteLine("Resultado: " + resultado);
//                     break;

//                 case 3:
//                     Console.Write("Digite o primeiro número: ");
//                     num1 = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Digite o segundo número: ");
//                     num2 = Convert.ToDouble(Console.ReadLine());
//                     resultado = num1 * num2;
//                     Console.WriteLine("Resultado: " + resultado);
//                     break;

//                 case 4: 
//                     Console.Write("Digite o primeiro número: ");
//                     num1 = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Digite o segundo número: ");
//                     num2 = Convert.ToDouble(Console.ReadLine());

//                     if (num2 == 0)
//                     {
//                         Console.WriteLine("Não é possível dividir por zero!");
//                     }
//                     else
//                     {
//                         resultado = num1 / num2;
//                         Console.WriteLine("Resultado: " + resultado);
//                     }
//                     break;

//                 case 5: 
//                     Console.Write("Digite o número: ");
//                     num1 = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Digite a porcentagem: ");
//                     num2 = Convert.ToDouble(Console.ReadLine());
//                     resultado = (num1 * num2) / 100;
//                     Console.WriteLine("Resultado: " + resultado);
//                     break;

//                 case 6: 
//                     Console.Write("Digite o numerador: ");
//                     num1 = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Digite o denominador: ");
//                     num2 = Convert.ToDouble(Console.ReadLine());

//                     if (num2 == 0)
//                     {
//                         Console.WriteLine("Não é possível dividir por zero!");
//                     }
//                     else
//                     {
//                         resultado = num1 / num2;
//                         Console.WriteLine("Resultado: " + resultado);
//                     }
//                     break;

//                 case 7: 
//                     Console.Write("Digite a base: ");
//                     num1 = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Digite o expoente: ");
//                     num2 = Convert.ToDouble(Console.ReadLine());
//                     resultado = Math.Pow(num1, num2);
//                     Console.WriteLine("Resultado: " + resultado);
//                     break;

//                 default:
//                     Console.WriteLine("Opção inválida!");
//                     break;
//             }
//             Console.WriteLine("\nDeseja realizar outra operação? (s/n)");
//             string resposta = Console.ReadLine()?.ToLower();
//             if (resposta != "s")
//             {
//                 continuar = false; 
//                 Console.WriteLine("Obrigado por usar a calculadora!");
//             }
//         }
//     }