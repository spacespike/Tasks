// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRnd(int arraySize)
{
    double[] arr = new double[arraySize];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble();
    }

    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]:F2}, ");
        else
            Console.Write($"{arr[i]:F2}");
    }
    Console.WriteLine("] ");
}

double MaxMinDiff(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    int i = 1;
    while (i < arr.Length)
    {
        if (max < arr[i])
            max = arr[i];
        if (min > arr[i])
            min = arr[i];
        i++;
    }
    return max - min;
}

Console.Write("Enter size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrayRnd(size);

Console.Write("Array ");
PrintArray(array);

double result = MaxMinDiff(array);
Console.WriteLine($"The differece is: {result:F2}");