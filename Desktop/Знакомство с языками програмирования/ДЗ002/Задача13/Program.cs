// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 99)
    Console.WriteLine("Третьей цифры нет!");

while (n > 99) {
    if (n < 1000 && n > 99) {
        n = n % 10;
        Console.WriteLine("Третье цифра в веденом числе: " + n);
    }
    else if(n > 999)
        n = n / 10;
}    


