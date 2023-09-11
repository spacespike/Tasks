//Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortToLower(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
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
Console.WriteLine("Created matrix: ");
PrintArray(array);
Console.WriteLine("Modified matrix: ");
SortToLower(array);
PrintArray(array);