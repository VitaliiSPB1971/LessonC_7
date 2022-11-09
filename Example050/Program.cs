// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
void randomArray(int number)
{
    int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j].Equals(number))
            {
                Console.WriteLine("Индексы нужного элемента: " + i + "-" + j);
                count++;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }

}
randomArray(number);
