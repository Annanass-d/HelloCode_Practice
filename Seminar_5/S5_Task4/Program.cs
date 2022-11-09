// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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

int CheckCountArr(int[] array,int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >=10 && array[i] <=99)
        {
            count++;
        }
    }
    return count;
}


int[] arr = GetRandomArray(123,0,1000);
System.Console.WriteLine(String.Join(",",arr));

int min = 10;
int max = 99;

int countEl = CheckCountArr(arr,min,max);
System.Console.WriteLine($"В массиве {countEl} элементов, лежащих в отрезке от {min} до {max}");

