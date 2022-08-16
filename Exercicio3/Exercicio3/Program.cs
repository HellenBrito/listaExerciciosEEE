

Console.WriteLine("Digite a estimativa otimista: ");
double otimista =double.Parse(Console.ReadLine());
Console.WriteLine("Digite a estimativa pessimista: ");
double pessimista = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a estimativa provável: ");
double provavel = double.Parse(Console.ReadLine());

double pert = (otimista + pessimista + (4 * provavel)) / 6;

Console.WriteLine($"Estimativa otimista: {otimista}");
Console.WriteLine($"Estimativa pessimista: {pessimista}");
Console.WriteLine($"Estimativa provavel: {provavel}");
Console.WriteLine($"PERT = {pert:F2}");

