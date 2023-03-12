// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();  
    }
}

int [,] SummMatrix(int[,] OneMatrix, int[,] TwoMatrix)
{
    int[,] result = new int[OneMatrix.GetLength(0), TwoMatrix.GetLength(1)];
    for (int i = 0; i < OneMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < OneMatrix.GetLength(1); j++)
        {
            result[i, j] = OneMatrix[i, j] * TwoMatrix[i, j];
        }
    }
    return result;
}

Console.Clear();
Console.Write("Введите размер массивов: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] OneMatrix = new int[size[0], size[1]];
int[,] TwoMatrix = new int[size[0], size[1]];
InputMatrix(OneMatrix);
InputMatrix(TwoMatrix);
Console.WriteLine("Первый массив");
PrintMatrix(OneMatrix);
Console.WriteLine("Второй массив");
PrintMatrix(TwoMatrix);
Console.WriteLine("Сумма массивов");
PrintMatrix(SummMatrix(OneMatrix, TwoMatrix));