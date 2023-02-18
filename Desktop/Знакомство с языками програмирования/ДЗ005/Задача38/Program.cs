// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3, 7, 22, 2, 78] -> 76

Console.Clear();

Console.Write("Введите колличество элементов массива: ");
int numElement = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numElement];
Random rand = new Random();
for (int i = 0; i < array.Length; i++){
    array[i] = rand.Next(100);
    Console.WriteLine(array[i]);
}
Array.Sort(array);
int n = array[array.Length - 1] - array[0];
Console.WriteLine($"Разница между мин.значением {array[0]} и макс.значением {array[array.Length - 1]} ровна: {n}"); 