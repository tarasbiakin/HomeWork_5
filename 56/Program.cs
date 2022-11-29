// В массиве хранятся цены на 10 видов мороженого. С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 3 до 20 включительно. Определить порядковый номер самого дорогого мороженого

int[] CreateArrayRndDouble(int size, int min, int max)
{
    int[] arr = new int[size];
    // создали класс 
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    { arr[i] =  rnd.Next(min, max+1);}
    return arr;
}

void PrintArrau(int[] arr,string symb1, string symb2)
{

    Console.Write(symb1);
   
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
       
        else
             Console.Write($"{arr[i]}");
    }
    Console.Write(symb2);

}

int ArrayMax(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]> max) max = arr[i];
    }
    return max;
}

// int ArrayMaxNumber(int[] arr)
// {
//    int max = arr[0];
//    int maxint = -1;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i]> max) 
//         {
//         max = arr[i];
//         maxint = i;
//         }
//     }
//     return maxint;
// }

 int ArrayMaxNumber(int[] arr,int result)
{
   for (int i = 0; i < arr.Length; i++)
   {
    if(arr[i]==result) result =i;
    }
    return result;
}

int[]array= CreateArrayRndDouble(10, 3, 20);
PrintArrau(array, "[", "]");
Console.WriteLine();

int res =  ArrayMax(array);
Console.WriteLine($"Максимальное число массива--> {res}");

int result =  ArrayMaxNumber(array,res);
Console.WriteLine($"Индекс максимального числа--> {result}");

