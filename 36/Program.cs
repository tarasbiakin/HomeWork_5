// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        if (i % 2 != 0) res = res +arr[i];
    }
    return res;
}

int[]array= CreateArrayRndDouble(8, -4, 12);
PrintArrau(array, "[", "]");
int res =  ArraySumEven(array);

Console.WriteLine($"--> {res}");