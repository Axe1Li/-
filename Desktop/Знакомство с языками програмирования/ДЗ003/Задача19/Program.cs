// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первое решение
//Console.Clear();

// Console.Write("Введите 5-ти значное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < 10000){
//     Console.WriteLine("Вы ошиблись!\nВведите 5-ти значное число: ");
//     }
// int n5 = n % 10;
// int n4 = (n / 10) % 10;
// int n3 = (n / 100) % 10;
// int n2 = (n / 1000) % 10;
// int n1 = (n / 10000) % 10;

// if (n5 == n1 && n4 == n2){
//     Console.WriteLine($"Число {n} - палинтром");
// }
// else
//     Console.WriteLine($"Число {n} - не палиндром");

// Второе решение

// Console.Clear();

// Console.Write("Введите 5-ти значное число: ");
// string num = Console.ReadLine();
// int len = num.Length;
// if (len < 4){
//     Console.WriteLine("Вы ошиблись!\nВведите 5-ти значное число: ");
// }    
// if (num[0] == num[4] && num[1] == num[3])
//     Console.WriteLine($"Число {num} - палинтром");
// else
//     Console.WriteLine($"Число {num} - не палиндром");

// Третье решение

Console.Clear();

Console.WriteLine("Введите 5-ти значное число: ");
string text = Console.ReadLine();
int len = text.Length;
if (len < 4){
     Console.WriteLine("Вы ошиблись!\nВведите 5-ти значное число: ");
}
char[] textO = text.ToCharArray();
Array.Reverse(textO);
string textF = new String(textO);

if (text == textF)
    Console.WriteLine($"Число {text} - палинтром");
else
    Console.WriteLine($"Число {text} - не палинтром");