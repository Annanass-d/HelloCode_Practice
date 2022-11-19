// Задача 48: задайте двумерный массив размера m на n,
// каждый элемент находится по формуле Amn = m+n. Выведите полученный массив на экран.
// m=3,n=4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] matrixRes = GetMatrix(3,4);
PrintMatrix(matrixRes);

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = i+j;
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
            System.Console.Write(matrix[i,j] + "  ");
        }
        System.Console.WriteLine();
    }
}
