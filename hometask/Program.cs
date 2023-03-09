// Задача 1

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Проверка без применения строк

// 14212 -> нет

// 12821 -> да

// 23432 -> да



using System;

int num = Int32.Parse(Console.ReadLine());

int[] number = toIntegerReversArray(num);



Console.WriteLine($"{num} -> {IsPolindrom(number)}");


int[] toIntegerReversArray (int number)
    {
        int a = number;

        List<int> l = new List<int>();

        while(a>0)
        {
                l.Add(a % 10);
                a = a / 10; 
        }
        return l.ToArray();
    }

bool IsPolindrom(int[] array){

    for (int i = 0; i < array.Length; i++)
    {

        if(array[i]!=array[array.Length-i-1]){
            return false;
        }
    }

    return true;
}
