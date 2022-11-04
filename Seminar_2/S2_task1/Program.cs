// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.

var random = new Random();

int num = random.Next(10, 100);
Console.WriteLine($"Число {num}");
int numFirst = num / 10;
int numSecond = num % 10;

int max = numFirst;

if (max < numSecond)
{
    max = numSecond;
}
Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");