// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Сколько чисел вы хотите ввести: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
for (int i = 0; i < array.Length; i++){
    Console.WriteLine($"Введите {i+1} элемент: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int El = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] > 0)
        El ++; 
}
Console.WriteLine($"Чисел больше '0': {El}");
