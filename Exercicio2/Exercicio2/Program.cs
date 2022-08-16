Console.Write("Digite um valor para A: ");
int valA = int.Parse(Console.ReadLine());

Console.Write("Digite um valor para B: ");
int valB = int.Parse(Console.ReadLine());

if (valA % valB == 0 || valB % valA == 0)
{
    Console.WriteLine("São Múltiplos");
}
else
{
    Console.WriteLine("Não são Múltiplos");
}