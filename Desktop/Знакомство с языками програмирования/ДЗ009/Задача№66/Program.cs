// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
while (M > N)
{
    Console.Write("Ошибка диапазона!\nВведите перове число: ");
    M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    N = Convert.ToInt32(Console.ReadLine());
}

int Recursion(int M, int N)
{
    if (M == N) 
    {
        return N;
    }
    else 
    {
        return M + Recursion(M + 1, N);
    }
}
Console.WriteLine($"Сумма натуральных чисел от {M} до {N} ровна: {Recursion(M, N)}");
