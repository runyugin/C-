﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Write("Enter M: ");

int m = int.Parse(Console.ReadLine());

Console.Write("Enter N: ");

int n = int.Parse(Console.ReadLine());

Console.Write($"M = {m}; N = {n} -> ");

chetNum(m,n);


void chetNum(int m, int n){


    if(m==n){
        return;
    } 

    if(m%2==0){
        Console.Write($"{m}, ");

    }

    chetNum(m+1,n);
}