// Задача 46: задайте двумерный массив размером mxn, заполненный случайными целыми числами.
// m =3, n=4.

int[,] matrixRes = GetRandomMatrix(3,4,-10,11);
PrintMatrix(matrixRes);


int[,] GetRandomMatrix(int rows, int columns ,int begin, int last)
{
    int[,] matrix = new int[rows,columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = random.Next(begin, last+1);
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