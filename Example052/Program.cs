// Задача 52. Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
Console.Write("Введите число строк:");
int strock = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов:");
int stolbec = Convert.ToInt32(Console.ReadLine());
int[,] array_res = inputArray(strock, stolbec);
printArray(array_res);
Console.WriteLine(" ");
asbArray(array_res, strock, stolbec);
int[,] inputArray(int strock, int stolbec)
{
    int[,] array = new int[strock, stolbec];
    for (int i = 0; i < strock; i++)
    {
        for (int j = 0; j < stolbec; j++)
        {
            Console.Write($"Введите число на позиции {i} - {j}: ");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return array;
}
void printArray(int[,] arr)
{
    for (int i = 0; i < strock; i++)
    {
        for (int j = 0; j < stolbec; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void asbArray(int[,] arr, int strock, int stolbec)
{
    for (int i = 0; i < strock; i++)
    {
        int srAr = 0;
        for (int j = 0; j < stolbec; j++)
        {
            srAr += arr[j, i];
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr / 3}");
    }
}
