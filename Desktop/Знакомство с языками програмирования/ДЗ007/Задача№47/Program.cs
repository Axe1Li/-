// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

//  0,5  7  -2 -0,2
//   1 -3,3  8 -9,9
//   8  7,8-7,1  9

Console.Clear();

Console.Write("Введите сколько нужно строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите сколько нужно элементов в строке: ");
int num = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[str, num];  
Random rand = new Random();

for (int i = 0; i < str; i++)
{
    for (int j = 0; j < num; j++)
    {
        array[i, j] = Convert.ToDouble(rand.Next(-100, 100) / 10.0);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}