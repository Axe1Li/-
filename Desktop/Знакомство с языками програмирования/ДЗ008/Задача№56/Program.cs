// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
int SearchMinSumm(int[,] matrix)
{
    int MinSumRow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        MinSumRow += matrix[0, j];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int SumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow += matrix[i, j];
        }
        if (MinSumRow > SumRow)
        {
            MinSumRow = SumRow;
        }
    }
    return MinSumRow;
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (size[0] == size[1])
{
    Console.Write("Ошибка!\nВведите размер прямоугольного массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];

Console.WriteLine("Начальный прямоугольный массив");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Минимальная сумма строки ровна: {SearchMinSumm(matrix)}");
