// Задача 30: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = GenerateRandomArray(8);

Console.WriteLine("Created array: ");
PrintArray(array);

int[] GenerateRandomArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(2); // Генерирует случайное число 0 или 1
    }

    return array;
}

void PrintArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write($"{element} ");
    }

    Console.WriteLine();
}
