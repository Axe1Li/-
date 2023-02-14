// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

Console.Write("Введите многозначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10)
    Console.WriteLine("Ошибка\nВведите многозначное число: ");
int sum = 0;
while (num != 0){
    sum += num % 10;
    num /= 10;
}
Console.WriteLine("Сумма цифр в числе ровна {0}", sum);
