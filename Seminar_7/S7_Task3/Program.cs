// Задача 49: задайте двумерный массив. Найдите элементы, у которых оба индекса четные
// и замените эти элементы на их квадраты

int[,] matrFirst = GetRandomMatrix(4,4,1,10);
PrintMatrix(matrFirst);
System.Console.WriteLine();
int[,] matrRes = MatrixChange(matrFirst);
PrintMatrix(matrRes);



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

int[,] MatrixChange (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 ==0){
                matrix[i,j] *= matrix[i,j];
            }
        }
    }
    return matrix;
}