// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] arr = createArr(5, 7);

arithmeticMeanArr(arr);


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



void arithmeticMeanArr(int[,] arr){

Console.Write($"Среднее арифметическое каждого столбца: ");

for (int i = 0; i < arr.GetLength(1); i++)
{
    int sum = 0;
    
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        sum+=arr[j,i];
    }

    if(i < arr.GetLength(1)-1){
        Console.Write($"{sum*1.0/arr.GetLength(1)}; ");
    } else {
        Console.WriteLine($"{sum*1.0/arr.GetLength(1)}.");
    }

}


}