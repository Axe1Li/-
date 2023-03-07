// Дополнительная задача с фото

Console.Clear();

Console.Write("Введите сколько нужно строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите сколько нужно элементов в строке: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[str, num];  
Random rand = new Random();

for (int i = 0; i < str; i++)
{
    for (int j = 0; j < num; j++)
    {
        array[i, j] = rand.Next(-100, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}