// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

bool FindElArray(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Math.Abs(find)){
            return true;
        }
    }
    return false;
}



int[] arr = GetRandomArray(10, 0, 100);
System.Console.WriteLine(String.Join(", ", arr));

int find = 4;

if(FindElArray(arr,find))
{
    System.Console.WriteLine($"Элемент {find} есть в массиве");
}
else
{
    System.Console.WriteLine($"Элемента {find} нет в массиве");
}
