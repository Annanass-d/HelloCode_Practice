// Напишите программу, которая принимает на вход число(N) и выдает таблицу квадратов чисел от 1 до N.

System.Console.WriteLine("Введите число:");
double num = Convert.ToDouble(Console.ReadLine());

if (num < 0){
    num = num * (-1);
}
if (num == 0){
    System.Console.WriteLine("Введен ноль, введите другое число");
}
// double numCount = 1;
// while (numCount <= num)
// {
//     double result = Math.Pow(numCount, 2);
//     System.Console.Write(result + "  ");
//     numCount++;
// }

for (double numCount = 1; numCount <= num; numCount++)
{
    double result = Math.Pow(numCount, 2);
    System.Console.Write(result + "  ");
}