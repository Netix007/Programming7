// Задача 48: Показать двумерный массив размером m×n заполненный целыми числами.

int[,] GetArray(int m, int n)
{
    Random randomizer = new Random();
    int[,] arr = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = randomizer.Next(0,100);
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] arr = GetArray(5,4);
