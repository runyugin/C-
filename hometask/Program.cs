// Задача 3

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



long num = long.Parse(Console.ReadLine());


Console.WriteLine($"{num} -> {string.Join(", ", numCube(num))}");


long[] numCube(long num){

    long[] arr = new long[num];

for (int i = 1; i <= num; i++)
{   
    arr[i-1] = (long)Math.Pow(i, 3);
}

return arr;

}