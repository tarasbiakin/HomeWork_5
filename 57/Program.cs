// В одномерном массиве хранится информация о зарплате 15 человек, работающих в отделе. Составить программу для определения: а) итоговой суммы по всему отделу; б) порядкового номера человека, получившего наименьшую зарплату; в) средней зарплаты по отделу

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

int ArraySum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int ArrayMinNumber(int[] arr)
{
   int min = arr[0];
   int minint = -1;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]< min) 
        {
        min = arr[i];
        minint = i;
        }
    }
    return minint;
}
int ArrayMidlit(int[] arr,int summa)
{
int res =0;
res = (summa/arr.Length+1); 
 return res;
}


int[]array= CreateArrayRndDouble(18, 1000, 5000);
PrintArrau(array, "[", "]");

int sum =  ArraySum(array);
Console.WriteLine($"Сумма массива {sum}");

int min =  ArrayMinNumber(array);
Console.WriteLine($"Индекс минимального числа--> {min}");

int mid =  ArrayMidlit(array,sum);
Console.WriteLine($"Среднее число--> {mid}");