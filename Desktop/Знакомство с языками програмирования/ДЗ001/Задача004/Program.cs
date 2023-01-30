// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число для сравнения: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для сравнения: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число для сравнения: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
    {
        Console.Write("Большее число: ");
        Console.WriteLine(a); 
    }  
else if (b > a && b > c)
    {
        Console.Write("Большее число: ");
        Console.WriteLine(b);
    }   
else if (c > a && c > b)
    {
        Console.Write("Большее число: ");
        Console.WriteLine(c);
    }