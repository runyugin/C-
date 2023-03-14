// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int m=3;
int n=4;

double[,] arr = new double[m,n];

Random x = new Random(); 


        Console.WriteLine($"m = {m}, n = {n}");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = Convert.ToDouble(x.Next(-100, 100)/10.0);;
        Console.Write($"{arr[i,j]}, ");
    }

        Console.WriteLine();
}

