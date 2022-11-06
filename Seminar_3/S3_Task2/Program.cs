// Напишите программу, которая по заданному номеру четверти показывает диапозон возможных координат точек
// в этой четверти.

static void ViewQuaterRange()
{
    System.Console.WriteLine("Введите число от 1 до 4 (номер четверти на плоскости координат):");
    int num = Convert.ToInt32(Console.ReadLine());

    switch (num)
    {
        case 1:
        Console.WriteLine("Диапозон возможных координат точек: X > 0 и Y > 0");
        break;
        case 2:
        Console.WriteLine("Диапозон возможных координат точек: X < 0 и Y > 0");
        break;
        case 3:
        Console.WriteLine("Диапозон возможных координат точек: X < 0 и Y < 0");
        break;
        case 4:
        Console.WriteLine("Диапозон возможных координат точек: X > 0 и Y < 0");
        break;
        default:
        Console.WriteLine("Введено неподходящее число");
        break;
    }
}
ViewQuaterRange();