// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строки массива.

int[,] matr = GetRandomMatrix(3,4);
PrintMatrix(matr);
System.Console.WriteLine();
int[,] resultMatr = ChangeMatrStrings(matr);
PrintMatrix(resultMatr);

int[,] ChangeMatrStrings(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int [,] newMatrix = new int[row,col];
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newMatrix[i,j] = matrix[row-1,j];
            newMatrix[row-1,j] = matrix[i,j];
        }
    }
    for (int i = 1; i < row-1; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newMatrix[i,j] = matrix[i,j];
        }
    }
    return newMatrix;
}

int[,] GetRandomMatrix(int rows, int columns ,int begin = -10, int last = 10)
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
