Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
    Console.WriteLine("Число отрицательное");
}
else
{
    for (int i = -num; i < num; i++)
    {
        Console.Write(i + ", ");
    }
    Console.WriteLine(num);
}