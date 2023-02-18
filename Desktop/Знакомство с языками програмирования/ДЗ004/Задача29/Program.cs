// Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int element = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[element];
Random rend = new Random();

for (int i = 0; i < element; i++){
    array[i] = rend.Next(10);
    Console.WriteLine(array[i]);
}

int x = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] == number)
    x++;
}
Console.WriteLine("Число {0} встречается в массиве {1} раз", number, x);
