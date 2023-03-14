// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Write("Enter b1: ");

float b1 = float.Parse(Console.ReadLine());

Console.Write("Enter k1: ");

float k1 = float.Parse(Console.ReadLine());


Console.Write("Enter b2: ");

float b2 = float.Parse(Console.ReadLine());


Console.Write("Enter k2: ");

float k2 = float.Parse(Console.ReadLine());


cordinats(b1, k1, b2, k2);



void cordinats(float b1, float k1, float b2, float k2){

    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({(b2-b1)/(k1-k2)}, {k1*((b2-b1)/(k1-k2))+b1})");
}


