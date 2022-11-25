// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int ArraySumEven(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) res = res +arr[i];
    }
    return res;
}

int[]array= CreateArrayRndDouble(8, 100, 1000);
PrintArrau(array, "[", "]");
int res =  ArraySumEven(array);

Console.WriteLine($"--> {res}");