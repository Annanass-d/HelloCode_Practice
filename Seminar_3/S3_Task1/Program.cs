// Напишите программу, которая принимает на вход координаты точки(X,Y), причем они не равны нулю,
// и выдает номер четверти плоскости, в которой находится эта точка.

static void ViewQuaterNumber()
{
    System.Console.WriteLine("Введите два числа (не равных нулю) - координаты точки:");
    int X = Convert.ToInt32(Console.ReadLine());
    int Y = Convert.ToInt32(Console.ReadLine());

    if (X > 0 && Y > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    if (X < 0 && Y > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    if (X < 0 && Y < 0)
    {
        Console.WriteLine("Третья четверть");
    }
    if (X > 0 && Y < 0)
    {
        Console.WriteLine("Четвертая четверть");
    }
}
ViewQuaterNumber();