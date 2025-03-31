{
    int numero = 10;
    int numero_2 = 5;
    Console.WriteLine("Quanto é: " + numero + " + " + numero_2 + "?");

    int resposta = Convert.ToInt32(Console.ReadLine());

    if (resposta == 15)
    {
        Console.WriteLine("Parabéns você acertou!");
    }
    else
    {
        Console.WriteLine("Tente Novamente!");
    }
}
