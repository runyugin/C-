// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

long numA = long.Parse(Console.ReadLine());

long numB = long.Parse(Console.ReadLine());


Console.WriteLine($"{numA}, {numB} -> {numCube(numA, numB)}");


long numCube(long numA, long numB){
    return (long)Math.Pow(numA, numB);
}