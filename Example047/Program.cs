// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите число строк:");
int strock = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов:");
int stolbec = Convert.ToInt32(Console.ReadLine());
void randomArray(int strock, int stolbec)
{
    double[,] arr = new double[strock, stolbec];
    Console.WriteLine("Массив значений:");
    Random rand = new Random();
    for (int i = 0; i < strock; i++)
    {
        for (int j = 0; j < stolbec; j++)
        {
            arr[i, j] = Convert.ToDouble(rand.Next(-100, 100) / 10.0);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
randomArray(strock, stolbec);
