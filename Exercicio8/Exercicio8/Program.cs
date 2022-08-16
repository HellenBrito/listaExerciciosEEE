int chaves = 0;
int chiquinha = 0;
int quico = 0;
int nulo = 0;
int branco = 0;
int voto = 0;
do
{
    Console.WriteLine(
        "\n1.Candidato Chaves" +
        "\n2.Candidata Chiquinha" +
        "\n3.Candidato Quico" +
        "\n4.Nulo / Branco" +
        "\n5.Encerrar a votação");
    Console.WriteLine("Entre com o seu voto: ");
    voto = int.Parse(Console.ReadLine());
    switch (voto)
    {
        case 1:
            chaves++;
            break;
        case 2:
            chiquinha++;
            break;
        case 3:
            quico++;
            break;
        case 4:
            nulo++;
            break;
        case 5:
            Console.WriteLine("Encerrado.");
            break;
        case 6:
            branco++;
            break;
        default:
            break;
    }
    if (voto == 5)
    {
        Console.WriteLine($"O número de votos de cada candidato é: " +
            $"\nChaves: {chaves}" +
            $"\nChiquinha: {chiquinha}" +
            $"\nQuico: {quico}" +
            $"\nNulo/Branco: {nulo + branco}");

        int somaTotal = chaves + chiquinha + quico + nulo + branco;
        Console.WriteLine($"A soma de todos os votos é: {somaTotal} ");
        
        double porcentagemNulo = (nulo * 100) / somaTotal;
        double porcentagemBranco = (branco * 100) / somaTotal;

        Console.WriteLine("Porcentagem de votos nulos: " + porcentagemNulo + "%");
        Console.WriteLine("Porcentagem de votos brancos: " + porcentagemBranco + "%");

        //Chaves
        if (chaves > chiquinha && chaves > quico)
        {
            Console.WriteLine("O vencedor foi o Chaves!");
        }
        //Chiquinha
        else if (chiquinha > chaves && chiquinha > quico)
        {
            Console.WriteLine("A vencedora foi a Chiquinha!");
        }
        //Quico
        else if (quico > chiquinha && quico > chaves)
        {
            Console.WriteLine("O vencedor foi o Quico!");
        }
    }
} while (voto != 5);
