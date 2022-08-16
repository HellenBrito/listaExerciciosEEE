Console.Write("Digite um valor para N: ");
int numero = int.Parse(Console.ReadLine());


    for (int i = 1; i <= numero; i++)
    {
        int linha1 = i;
        int linha2 = i * i;
        int linha3 = i * i * i;
        Console.WriteLine($"{linha1} {linha2} {linha3}");
    }
