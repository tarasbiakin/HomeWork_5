//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[]CreateArrayRndDouble(int size, double min, double max)
{
   double[] arr = new double[size];
    // создали класс 
    Random rnd = new Random();
    for(int i= 0; i<arr.Length;i++)
    {arr[i] = rnd.NextDouble()*(max-min)+min;}
    return arr;
}

void PrintArrau(double[]arr,string symb1, string symb2){

Console.Write(symb1);

   for(int i= 0; i<arr.Length;i++)
   { 
    if (i<arr.Length-1){
        Console.Write($"{Math.Round(arr[i],2)}, ");}
        else 
        Console.Write($"{Math.Round(arr[i],2)}");
    }
    Console.Write(symb2);
    
}

double ArrayDoubleMin(double[] arr)
{ double min=arr[0];
for(int i= 0; i<arr.Length;i++)
{
    if (arr[i]<min)min = arr[i];
}
return min;
}

double ArrayDoubleMax(double[] arr)
{ double max=arr[0];
for(int i= 0; i<arr.Length;i++)
{
    if (arr[i]>max)max = arr[i];
}
return max;
}

double[]array= CreateArrayRndDouble(12, 5.2, -9.5);
PrintArrau(array, "[", "]");
double minimum =  ArrayDoubleMin(array);
double maximum =  ArrayDoubleMax(array);
double result =  maximum-minimum;


// Console.WriteLine($"Минимальное число = {Math.Round(minimum,2)}");
// Console.WriteLine($"Максимальное число = {Math.Round(maximum,2)}");
Console.WriteLine($"--> {Math.Round(result,2)}");



