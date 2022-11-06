Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 0)
{
    Console.WriteLine("Число отрицательное");
}
else
{
    int number = -N;

    while (number != N)
    {
        Console.Write(number + ", ");
        number++;
    }
Console.WriteLine(number);
}
