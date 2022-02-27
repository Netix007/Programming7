// Задача 54: В матрице чисел найти сумму элементов главной диагонали.

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

int[,] arr = GetArray(5,5);
int summ = 0;
Console.WriteLine("================");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i == j)
            {summ = summ + arr[i,j];}
    }
}
Console.WriteLine($"Сумма элементов главной диагонали матрицы: {summ}");