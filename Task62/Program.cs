// Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrixRndInt(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= matrix.GetLength(0) * matrix.GetLength(1)) //up to 16
    {
        matrix[i, j] = temp;                                   //step
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)  //on top, moving right
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1) //right angle, moving down
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1) //bottom, moving left
            j--;
        else                                                //moving up
            i--;
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

int[,] matrix = CreateSpiralMatrixRndInt(4, 4);
Console.WriteLine("Created matrix: ");
PrintArray(matrix);