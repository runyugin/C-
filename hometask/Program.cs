// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


    int[] array = arrayRandom();

    int count = contEven(array);

    Console.WriteLine($"[{string.Join(", ", array)}] -> {count}");


int[] arrayRandom(){

    int[] result = new int[8];

    for (int i = 0; i < result.Length; i++) {  
    result[i] = new Random().Next(100, 999);
    }

    return result;

}

int contEven(int[] arr){

    int result = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i]%2==0){
        result++;
    }
    
}

    return result;
}