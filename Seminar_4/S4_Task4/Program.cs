// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + "  ");
        position++;
    }
}
int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);
