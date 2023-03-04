// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.



// a = 5; b = 7 -> max = 7

// a = 2 b = 10 -> max = 10

// a = -9 b = -3 -> max = -3

Console.WriteLine($"Задача 1");



int a = Int32.Parse(Console.ReadLine());

int b = Int32.Parse(Console.ReadLine());

int c = a;



if (a > b)
{

    c = a;

}
else
{

    c = b;

}





Console.WriteLine($"a = {a}; b = {b} -> max = {c}");





// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.



// 2, 3, 7 -> 7

// 44 5 78 -> 78

// 22 3 9 -> 22



Console.WriteLine($"Задача 2");



int e = Int32.Parse(Console.ReadLine());

int f = Int32.Parse(Console.ReadLine());

int s = Int32.Parse(Console.ReadLine());



int[] arr = { e, f, s };



Array.Sort(arr);



int l = arr[arr.Length - 1];





Console.WriteLine($"{e}, {f}, {s} = > Max -> {l}");







// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).



// 4 -> да

// -3 -> нет

// 7 -> нет



Console.WriteLine($"Задача 3");



int u = Int32.Parse(Console.ReadLine());



string z = "нет";



if (u % 2 == 0)
{

    z = "да";

}



Console.WriteLine($"{u} -> {z}");







// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.



// 5 -> 2, 4

// 8 -> 2, 4, 6, 8







Console.WriteLine($"Задача 4");



int g = Int32.Parse(Console.ReadLine());





Console.Write($"{g} -> ");



for (int i = 1; i <= g; i++)
{



    if (i % 2 == 0)
    {

        Console.Write($"{i}, ");

    }



}