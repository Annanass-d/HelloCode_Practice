// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int SetNumber()
{
    System.Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Multipl (int num)
{
    int product = 1;
    for (int i = 1; i <=num; i++)
    {
        product = product * i;
    }
    return product;
}

int number = SetNumber();
int result = Multipl(number);
System.Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");