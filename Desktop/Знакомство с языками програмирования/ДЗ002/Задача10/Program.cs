// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.Write("Введите трехзначное часто: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = 0;

if (number >= 100 && number < 1000) {
    number = number / 10;
    num = number % 10;
}
else 
    Console.WriteLine("Введено не трехзначное чисто");   

Console.WriteLine(num);