// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив: 3 4
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 

Console.Clear();

Console.Write("Введите сколько нужно строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите сколько нужно элементов в строке: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[str, num];  
Random rand = new Random();
int[] summ = new int[num];

Console.WriteLine("Матрица");
for (int i = 0; i < str; i++)
{
    for (int j = 0; j < num; j++)
    {
        array[i, j] = rand.Next(10);
        Console.Write(array[i, j] + "\t");
        
    }
    Console.WriteLine();
}

for (int i = 0; i < num; i++)
{
    for (int j = 0; j < str; j++)
    {
        summ[i] += array[j, i];
    }
}
Console.WriteLine("Среднее арифметическое каждого столбца");
foreach(double elem in summ)
{
    Console.Write((elem / str) + "\t");
}
Console.WriteLine();