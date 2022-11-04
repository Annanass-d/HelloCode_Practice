// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите два числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
int min = num2;

if (num2 > max)
{
    max = num2;
    min = num1;
}

if (max == Math.Pow(min,2))
{
    Console.WriteLine($"Число {max} является квадратом {min}");
}
else
{
    Console.WriteLine($"Число {max} не является квадратом {min}");
}