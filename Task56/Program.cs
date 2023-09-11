// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++) // matrix.GetLength(0)
    {
        for (int j = 0; j < colums; j++) // matrix.GetLength(1)
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

int FindLowestSumMatrixRows(int[,] matrix)
{
    int[] matrixSum = new int[matrix.GetLength(0)];
    Console.WriteLine("Rows sum:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixSum[i] += matrix[i, j];
        }
        Console.WriteLine($"{i + 1} -> {matrixSum[i]}");
    }
    int minimalSum = matrixSum[0];
    int minRow = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrixSum[i] < minimalSum)
        {
            minimalSum = matrixSum[i];
            minRow = i + 1;
        }
    }
    return minRow;
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
Console.WriteLine("Created matrix: ");
PrintArray(array);
int row = FindLowestSumMatrixRows(array);
Console.WriteLine($"Lowest sum is in the {row} row.");