// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Исходный массив");

int[,] arr = createArr(5, 7);

Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в троке №: {numberRowArr(arr)}");

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


int numberRowArr(int[,] arr)
{

    int result = int.MaxValue;
    int numberRow = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        int temp = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {

            temp+=arr[i,j];
        }

        if(result>temp){
            result=temp;
            numberRow = i;
        }
    }

    return numberRow;

}