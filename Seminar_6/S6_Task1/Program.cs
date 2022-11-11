// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetRandomArray(int size,int begin, int last)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(begin, last+1);
    }
    return array;
}


int[] ReverseArray(int[] array)
{
    int[] rvrsArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        rvrsArr[i] = array[array.Length-1-i];
    }
    return rvrsArr;
}

int[] arr = GetRandomArray(6,1,10);
System.Console.WriteLine(String.Join(", ",arr));

int[] arrReverse = ReverseArray(arr);
System.Console.WriteLine(String.Join(", ",arrReverse));