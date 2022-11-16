// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// f(1) = 0
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int GetNum(string str)
{
    System.Console.WriteLine($"Введите число {str}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// int[] Fibonacci(int num, int f1, int f2)
// {
//     int[] arrFib = new int[num];
//     arrFib[0] = f1;
//     arrFib[1] = f2;
//     for (int i = 2; i < arrFib.Length; i++)
//     {
//         arrFib[i] = arrFib[i-1] + arrFib[i-2];
//     }
//     return arrFib;
// }

void Fibonacci(int num, int f1, int f2)
{
    int[] arrFib = new int[num];
    arrFib[0] = f1;
    arrFib[1] = f2;

    System.Console.WriteLine($"f(1) = {f1}");
    System.Console.WriteLine($"f(2) = {f2}");

    for (int i = 2; i < arrFib.Length; i++)
    {
        arrFib[i] = arrFib[i-1] + arrFib[i-2];
        System.Console.WriteLine($"f({i+1}) = {arrFib[i]}");
    }
}

int number = GetNum("");

Fibonacci(number, 0, 1);
// System.Console.WriteLine(String.Join(", ", array));
