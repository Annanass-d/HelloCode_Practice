// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число крастным первому.
// Если число 2 не крастно чсилу 1, то программа выводит остаток деления.

Console.WriteLine("Введите два числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 % num2;

if (result == 0)
{
    Console.WriteLine("-> кратно");
}
else
{
    Console.WriteLine($"-> не кратно, остаток {result}");
}