// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



    int[] array = arrayRandom();

    int different = maxNum(array)-minNum(array);

    Console.WriteLine($"[{string.Join(", ", array)}] -> {different}");


int[] arrayRandom(){

    int[] result = new int[8];

    for (int i = 0; i < result.Length; i++) {  
    result[i] = new Random().Next(-100,100);
    }

    return result;

}

int minNum(int[] arr){


    int result = int.MaxValue;


        for (int i = 0; i < arr.Length; i++)
        {

            if(result>arr[i]){
                result=arr[i];
            }

        }

    return result;
}


int maxNum(int[] arr){


    int result = int.MinValue;


        for (int i = 0; i < arr.Length; i++)
        {

            if(result<arr[i]){
                result=arr[i];
            }

        }

    return result;
}