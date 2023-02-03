// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int n = num.Length;

if (n >= 3)
Console.WriteLine(num[2]);
else
Console.WriteLine("Третьей цифры нет");