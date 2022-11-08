// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

int SetNumber()
{
    System.Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int NumberLength (int number)
{
    int count = number;
    int i = 1;
    while (count >10)
    {
        count /= 10;
        i++;
    }
    return i;
}

int number = SetNumber();
int result = NumberLength(number);
System.Console.WriteLine(result);