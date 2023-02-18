// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.Write("Введите колличество элементов массива: ");
int numElement = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numElement];
Random rand = new Random();
for (int i = 0; i < array.Length; i++){
    array[i] = rand.Next(-100, 100);
    Console.WriteLine(array[i]);
}
int sum = 0;
for (int i = 0; i < array.Length; i++){
    if (i % 2 != 0)
    sum = sum + array[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях ровна: {sum}");