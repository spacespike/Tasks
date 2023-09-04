// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] UsersArray(int arraySize)
{
    int[] arr = new int[arraySize];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("] ");
}

int MoreThanZero(int[] arr)
{
    int positive = 0;
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i] > 0) positive++;
        i++;
    }
    return positive;
}

Console.Write("Enter size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array's values: ");

int[] array = UsersArray(size);

Console.Write("Array ");
PrintArray(array);

Console.Write("The amount of numbers that are > 0 is: ");
Console.WriteLine(MoreThanZero(array));