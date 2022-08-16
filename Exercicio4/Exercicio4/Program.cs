Console.WriteLine("informe a nota do aluno: ");
double nota = double.Parse(Console.ReadLine());

if(nota >= 7)
{
    Console.WriteLine("Aprovado.");
}
else if(nota < 7 && nota >= 4){
    Console.WriteLine("Em recuperação.");
}
else
{
    Console.WriteLine("Reprovado.");
}
