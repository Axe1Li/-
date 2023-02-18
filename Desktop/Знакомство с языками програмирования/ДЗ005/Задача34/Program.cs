// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

Console.Write("Введите колличество элементов массива: ");
int numArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numArray];

for (int i = 0; i < array.Length; i++){
    Console.WriteLine($"Введите {i} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int result = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0){
        result++;
    }
}
Console.WriteLine($"Четных чисел в массиве: {result}");