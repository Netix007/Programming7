// Задача 52: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

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
Console.WriteLine("================");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if ( i % 2 == 0 && j % 2 == 0)
            arr[i,j] = arr[i,j] * arr[i,j];
    Console.Write($"{arr[i,j]}   ");
    }
Console.WriteLine();
}