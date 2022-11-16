// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// *каждая сторона треугольника меньше суммы двух других сторон

int GetNum(string str)
{
    System.Console.WriteLine($"Введите число {str}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool CheckTriangle(int numA, int numB, int numC)
{
    if (numA < numB + numC && numB < numA + numC && numC < numA + numB) return true;
    else return false;
}

int numA = GetNum("A");
int numB = GetNum("B");
int numC = GetNum("C");

if (CheckTriangle(numA, numB, numC))
{
    Console.WriteLine($"Треугольник со сторонами длиной {numA}, {numB}, {numC} может существовать");
}
else Console.WriteLine($"Треугольник со сторонами длиной {numA}, {numB}, {numC} НЕ может существовать");