// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (0,0),(1,1) и т.д.

int[,] matr = GetRandomMatrix(4,4,1,9);
PrintMatrix(matr);
System.Console.WriteLine();
int result = SumDiagonal(matr);
System.Console.WriteLine($"Сумма элементов на главной диагонали = {result}");

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

int SumDiagonal (int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i,j];
        }
    }
    return sum;
}