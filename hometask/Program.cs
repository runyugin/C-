// Задача 3 * : Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Исходные массивы:");


int n = 3;
int m = 5;

int[,] arr1 = createArr(m, n);

int[,] arr2 = createArr(n, m);

Console.WriteLine();
Console.WriteLine($"Произведение массивов: {prArr(arr1,arr2)}");

int[,] createArr(int n, int m)
{

    int[,] arr = new int[m, n];
 
    Random x = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = x.Next(0, 10);
            Console.Write($"{arr[i, j]}, ");
        }

        Console.WriteLine();
    }

    return arr;
}


int[,] prArr(int[,] arr1, int[,] arr2)
{

    int row = arr1.GetLength(0) > arr1.GetLength(1) ? arr1.GetLength(0) : arr1.GetLength(1);

    int[,] result = new int[row,row];

    return result;

}