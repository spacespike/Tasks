// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine("  |");
    }

}

void GetValue(int[,] matrix, int userRow, int userColum)
{
    if (userRow > matrix.GetLength(0) && userColum > matrix.GetLength(1))
        Console.WriteLine("wrong coordinats, there is no such number");
    else
    {
        object value = matrix.GetValue(userRow, userColum);
        Console.WriteLine(value);
    }
}

    Console.Write("Enter amount of rows for the array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter amount of colums for the array: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter max value for the array: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min value for the array: ");
    int min = Convert.ToInt32(Console.ReadLine());


    int[,] array = CreateMatrixRndInt(rows, colums, min, max);
    PrintArray(array);

    Console.WriteLine("Enter coordinats (remember, that they strats from 0, not from 1).");
    Console.Write("Enter row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter colum: ");
    int colum = Convert.ToInt32(Console.ReadLine());

    Console.Write("Value of the coordinats: ");
    GetValue(array, row, colum);