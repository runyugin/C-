// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет


checkArr(3,4);


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


void checkArr(int a, int b){
 
    int[,] arr = createArr(5, 7);


            if(a<(arr.GetLength(0)) & b<(arr.GetLength(1))){
                Console.WriteLine($"a = {a}, b = {b} -> {arr[a,b]} ");
            } else {

                Console.WriteLine($"a = {a}, b = {b} -> такого числа в массиве нет ");
            }

}


