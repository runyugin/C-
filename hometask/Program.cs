﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


Console.WriteLine("[{0}]", string.Join(", ", arrayRandom()));


int[] arrayRandom(){

    int[] result = new int[8];

    for (int i = 0; i < result.Length; i++) {  
    result[i] = new Random().Next(int.MinValue, int.MaxValue);;
    }

    return result;

}