Console.Write("Digite o valor A: ");
double lA = double.Parse(Console.ReadLine());
Console.Write("Digite o valor B: ");
double lB = double.Parse(Console.ReadLine());
Console.Write("Digite o valor C: ");
double lC = double.Parse(Console.ReadLine());

// Letra A - Area do triângulo:

double areaTriangulo = (lA * lC) / 2;
Console.WriteLine($"A área do triângulo é: {areaTriangulo:F2}");

// Letra B - Area do circulo:

double pi = 3.14159;
double raio = pi * (lC * lC);
Console.WriteLine($"A área do círculo de raio é: {raio:F2}");

// Letra C - Area do trapézio:

double areaTrapezio = ((lA + lB) * lC) / 2;
Console.WriteLine($"A área do trapezio é: {areaTrapezio:F2}");

// Letra D - Area do quadrado:

double areaQuadrado = lB * lB;
Console.WriteLine($"A área do quadrado é: {areaQuadrado:F2} ");

//Letra E - Area do retangulo
double areaRetangulo = lA * lB;
Console.WriteLine($"A área do retângulo é: {areaRetangulo:F2} ");