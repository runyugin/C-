// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write("Enter length array: ");

int numM = int.Parse(Console.ReadLine());

long[] arr = numArr(numM);

Console.WriteLine($"{String.Join(", ", arr)} -> {positive(arr)}");


long[] numArr(int numM){

    long[] arr = new long[numM];

    for (int i = 0; i < numM; i++) {  

        Console.Write($"Enter length array[{i}]: ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    return arr;

}

int positive(long[] arr){

  int count = 0;
    for (int i = 0; i < arr.Length; i++) {  

        if(arr[i]>0)
            count++;
    }  
    
    return count;
}