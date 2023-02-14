//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow();

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую натуральную степень возвести: ");
int pow = Convert.ToInt32(Console.ReadLine());
int p = num;
int i = 1;

while(i < pow){
    p = p * num;
    i++;
    }   
Console.WriteLine("Число {0} в степени {1} равняется {2}", num, pow, p);

