// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// d = √ (х А – х В) ^2 + (у А – у В) ^2

System.Console.WriteLine("Введите по пордяку 4 числа - координаты x,y точки A и координаты x,y точки B");

double X1 = Convert.ToDouble(Console.ReadLine());
double Y1 = Convert.ToDouble(Console.ReadLine());

double X2 = Convert.ToDouble(Console.ReadLine());
double Y2 = Convert.ToDouble(Console.ReadLine());

double DistanceTwoPoints(double X1,double Y1,double X2,double Y2)
{
    double distance = Math.Sqrt(Math.Pow((X1-X2),2) + Math.Pow((Y1-Y2),2));
    return distance;
}

double result = DistanceTwoPoints(X1,Y1,X2,Y2);
System.Console.WriteLine($"Расстояние между точками равно {result}");