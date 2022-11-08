// Напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до А.

int SetNumber(string str)
{
    System.Console.WriteLine($"Введите число {str}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Sum1toNumA(int numA)
{
    int sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum += i;
    }
    return sum;
}

void Print(int num, int sum)
{
    System.Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");
}

int numA = SetNumber("A");

int sum = Sum1toNumA(numA);

Print(numA,sum);

