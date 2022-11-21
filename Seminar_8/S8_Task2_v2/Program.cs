// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int[,] matr = GetRandomMatrix(5, 4);
PrintMatrix(matr);
System.Console.WriteLine();
PrintMatrix(Transpon(matr));


int[,] Transpon(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int[,] newMatr = new int[col, row];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newMatr[j, i] = matrix[i, j];
        }
    }
    return newMatr;
}

int[,] GetRandomMatrix(int rows, int columns, int begin = -10, int last = 10)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(begin, last + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}
