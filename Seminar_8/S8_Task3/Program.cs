// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

System.Console.WriteLine("Введите количество строк массива");
int rows = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetRandomMatrix(rows, columns, 0, 10);
PrintMatrix(array);
System.Console.WriteLine();
int[] rowAr = GetRowArray(array);
SortArray(rowAr);
System.Console.WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);



int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i,j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i+1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            System.Console.WriteLine($"{el} встречается {count} раз");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    System.Console.WriteLine($"{el} встречается {count} раз");
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