// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



    int[] array = arrayRandom();

    int sum = sumNotEven(array);

    Console.WriteLine($"[{string.Join(", ", array)}] -> {sum}");


int[] arrayRandom(){

    int[] result = new int[8];

    for (int i = 0; i < result.Length; i++) {  
    result[i] = new Random().Next(1,8);
    }

    return result;

}

int sumNotEven(int[] arr){

    int result = 0;

        for (int i = 1; i < arr.Length; i=i+2)
        {
                result+=arr[i];

        }

    return result;
}