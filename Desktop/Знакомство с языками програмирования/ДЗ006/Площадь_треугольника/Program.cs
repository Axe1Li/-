// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

Console.Clear();

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());

double sideA = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // находим длину стороны АВ
double sideB = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)); // находим длину стороны ВС
double sideC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)); // находим длину стороны АC

double halfP = (sideA + sideB + sideC) / 2; // находим полупериметр для формулы Герона

double Square = Math.Round(Math.Sqrt(halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC)), 2); // находим площадь треугольника по формуле Герона

Console.WriteLine($"Площадь равна: {Square}");