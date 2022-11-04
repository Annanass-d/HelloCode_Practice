// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

var random = new Random();

int num = random.Next(100, 1000);
Console.Write($"{num} -> ");

int numFirst = num / 100;
int numThird = num % 10;
int result = numFirst * 10 + numThird;

Console.WriteLine(result);
