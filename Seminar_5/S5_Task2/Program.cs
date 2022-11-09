// Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ChangePosNegElements(int[] array)
{
    int[] arrayChanged = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayChanged[i] = -array[i];
    }
    return arrayChanged;
}


int[] arr = GetRandomArray(4,-9,10);
System.Console.WriteLine(String.Join(", ", arr));

int[] arrChng = ChangePosNegElements(arr);
System.Console.WriteLine(String.Join(", ", arrChng));