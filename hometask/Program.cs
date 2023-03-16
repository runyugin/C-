// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.




Console.WriteLine("Исходный массив");

int[,] arr = createArr(5, 7);

Console.WriteLine();
Console.WriteLine("Отсортированный массив");

sortArr(arr);


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




int[,] sortArr(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int f = 0; f < arr.GetLength(1) - j - 1; f++)
            {
                if (arr[i,f] > arr[i,f + 1])
                {
                    temp = arr[i,f + 1];
                    arr[i,f+1] = arr[i,f];
                    arr[i,f] = temp;

                }
            }
               Console.Write($"{arr[i, j]}, ");
        }

        Console.WriteLine();
    }

    return arr;

}