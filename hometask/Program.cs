// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine($"Введите координату X для точки A:");
float x1 = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Введите координату Y для точки A:");
float y1 = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Введите координату Z для точки A:");
float z1 = Int32.Parse(Console.ReadLine());



Console.WriteLine($"Введите координату X для точки B:");
float x2 = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Введите координату Y для точки B:");
float y2 = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Введите координату Z для точки B:");
float z2 = Int32.Parse(Console.ReadLine());



Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {distance(x1,y1,z1,x2,y2,z2)}");


Double distance(float x1, float y1, float z1, float x2, float y2, float z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +  Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
    return d;
}