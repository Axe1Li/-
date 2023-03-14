// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

int Recursion(int M, int N)
{
    if (M == 0)
    {
        return (N + 1);
    }
    else
    {
        if ((M != 0) && (N == 0))
        {
            return Recursion(M - 1, 1);
        }
        else
        {
            return Recursion(M - 1, Recursion(M, N - 1));
        }
    }
}
Console.WriteLine($"A({M},{N}) = {Recursion(M, N)}");