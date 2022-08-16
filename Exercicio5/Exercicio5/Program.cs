Console.WriteLine("Escolha um número de 1 á 3: ");
int opcao = int.Parse(Console.ReadLine());

switch(opcao){
    case 1:
        Console.WriteLine("Bom dia!");
        break;
    case 2:
        Console.WriteLine("Boa tarde!");
        break;
    case 3:
        Console.WriteLine("Boa noite!");
        break;
    default:
        Console.WriteLine("Inválido");
        break;
}