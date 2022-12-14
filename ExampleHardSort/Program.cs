// Задача _HARD SORT Задайте двумерный массив из целых чисел. Количество строк и столбцов задается
// с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
using System;
using System.Linq;
Console.Write("Введите число строк:");
int strock = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов:");
int stolbec = Convert.ToInt32(Console.ReadLine());
int[,] array_res = inputArray(strock, stolbec);
printArray(array_res);
Console.WriteLine(" ");
sortArray(array_res, strock, stolbec);
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
void sortArray(int[,] arr, int strock, int stolbec)
{
    var _tmp = new int[arr.GetLength(0) * arr.GetLength(1)];
    System.Buffer.BlockCopy(arr, 0, _tmp, 0, _tmp.Length * sizeof(int));
    _tmp = _tmp.OrderBy(x => x).ToArray();
    System.Buffer.BlockCopy(_tmp, 0, arr, 0, _tmp.Length * sizeof(int));
    for (int i = 0; i < strock; i++)
    {
        for (int j = 0; j < stolbec; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
