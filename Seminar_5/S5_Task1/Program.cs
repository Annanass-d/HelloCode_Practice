// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] GetRandomArray(int size, int begin, int last)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(begin, last+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "  ");
    }
}

int GetPositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0){
            sum += array[i];
        }
    }
    return sum;
}

int GetNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0){
            sum += array[i];
        }
    }
    return sum;
}

int GetSum (int[] array, bool isPositive = true)
{
    if (isPositive){
        return GetPositiveSum(array);
    }
    else{
        return GetNegativeSum(array);
    }
}


int size = 12;

int[] arr = GetRandomArray(size, -9, 9);
PrintArray(arr);
System.Console.WriteLine();

int sumPositive = GetSum(arr);
int sumNegative = GetSum(arr,false);
System.Console.WriteLine("Сумма положительных элементов = " + sumPositive);
System.Console.WriteLine("Сумма отрицательных элементов = " + sumNegative);