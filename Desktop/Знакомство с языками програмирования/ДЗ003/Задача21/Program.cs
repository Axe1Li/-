// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координаты a1: ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты a2: ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты a3: ");
double a3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты b3: ");
double b3 = Convert.ToDouble(Console.ReadLine());

double dist = Math.Round(Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2) + Math.Pow(b3 - a3, 2)),2);
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {dist}");