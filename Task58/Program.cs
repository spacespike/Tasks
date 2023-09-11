// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    // For instances with not square matrices
    int newRow, newColumn;
    if (firstMatrix.GetLength(0) > secondMatrix.GetLength(0))
    {
        newRow = secondMatrix.GetLength(0);
    }
    else
    {
        newRow = firstMatrix.GetLength(0);
    }

    if (firstMatrix.GetLength(1) > secondMatrix.GetLength(1))
    {
        newColumn = secondMatrix.GetLength(1);
    }
    else
    {
        newColumn = firstMatrix.GetLength(1);
    }

    int[,] newMartix = new int[newRow, newColumn];

    for (int i = 0; i < newRow; i++)
    {
        for (int j = 0; j < newColumn; j++)
        {
            for (int k = 0; k < newRow; k++)
            {
                newMartix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return newMartix;
}

Console.Write("Enter amount of rows for the first matrix: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of colums for the first matrix: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max value for the first matrix: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value for the first matrix: ");
int min = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = CreateMatrixRndInt(rows, colums, min, max);
Console.WriteLine("First created matrix: ");
PrintArray(firstMatrix);

Console.Write("Enter amount of rows for the second matrix: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of colums for the second matrix: ");
int colums2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max value for the second matrix: ");
int max2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value for the second matrix: ");
int min2 = Convert.ToInt32(Console.ReadLine());

int[,] secondMatrix = CreateMatrixRndInt(rows2, colums2, min2, max2);
Console.WriteLine("Second created matrix: ");
PrintArray(secondMatrix);

Console.WriteLine("Multiplied matrices: ");
int[,] newMartix = MultiplyMatrices(firstMatrix, secondMatrix);
PrintArray(newMartix);