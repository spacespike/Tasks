// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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

void ColumAverage (int[,] matrix)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        average = (average + matrix[i, j]);
    }
    Console.Write($"{average/(matrix.GetLength(0)):F1}; ");
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
ColumAverage(array);
