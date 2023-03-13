// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


String num = Console.ReadLine();


Console.WriteLine($"{num} -> {numSum(num)}");


long numSum(String num){

    long result = 0;

    for (int i = 0; i < num.Length; i++) {  
    result += int.Parse(num[i].ToString());
    }

    return result;

}