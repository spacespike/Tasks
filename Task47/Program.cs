// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreateMatrixRndDouble(int rows, int colums, int min, int max)
{
    double[,] matrix = new double[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++) // matrix.GetLength(0)
    {
        for (int j = 0; j < colums; j++) // matrix.GetLength(1)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(min, max + 1));
        }
    }

    return matrix;
}

void PrintArray(double[,] matrix)
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

Console.Write("Enter amount of rows for the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of colums for the array: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max value for the array: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value for the array: ");
int min = Convert.ToInt32(Console.ReadLine());


double[,] array = CreateMatrixRndDouble(rows, colums, min, max);

PrintArray(array);
