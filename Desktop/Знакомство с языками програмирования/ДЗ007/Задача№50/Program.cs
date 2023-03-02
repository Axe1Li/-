// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этот элемент или же указание, что такого элемента нет.
// Например, задан массив: 3 4 

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите сколько нужно строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите сколько нужно элементов в строке: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[str, num];  
Random rand = new Random();

for (int i = 0; i < str; i++)
{
    for (int j = 0; j < num; j++)
    {
        array[i, j] = rand.Next(-100, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Введите индекс строки для поска: ");
int SearchStr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс элемента для поиска: ");
int SearchNum = Convert.ToInt32(Console.ReadLine());

if (SearchStr > str)
{
    Console.WriteLine("Поиск не возможен! Не верный индекс строки!");
}
else if (SearchNum > num)
{
    Console.WriteLine("Поиск не возможен! Не верный индекс элемента!");
}
else
    Console.WriteLine("Результат поиска: " + array[SearchStr - 1,SearchNum - 1]);