// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


Console.Write("Enter M: ");

int m = int.Parse(Console.ReadLine());

Console.Write("Enter N: ");

int n = int.Parse(Console.ReadLine());

Console.WriteLine($"M = {m}; N = {n} -> {chetNum(m,n)}");


int chetNum(int m, int n){
    

    if(m==n){
        return m;
    } 

     return n + chetNum(m,n-1);

    
}