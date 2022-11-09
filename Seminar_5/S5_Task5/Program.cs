// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultParesArray(int[] array)
{
    int sizeNew = array.Length == 0 ? array.Length/2 : (array.Length/2) +1;
    int[] newArr = new int[sizeNew];
    for (int i = 0; i < array.Length/2; i++)
    {
        newArr[i] = array[i]*array[array.Length-1-i];
    }
    if (array.Length%2 != 0)
    {
        newArr[sizeNew-1] = array[sizeNew-1];
    }
    return newArr;
}


int[] arr = GetRandomArray(5,0,10);
System.Console.WriteLine(String.Join(", ",arr));

int[] newArray = MultParesArray(arr);
System.Console.WriteLine(String.Join(", ",newArray));