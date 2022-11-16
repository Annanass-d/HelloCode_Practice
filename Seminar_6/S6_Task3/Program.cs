// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int GetNum(string str)
{
    System.Console.WriteLine($"Введите число {str}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string ConvertToBin(int num)
{
    string res = String.Empty;
    for (int i = num; i > 0; i /= 2)
    {
        res = i % 2 + res;
    }
    return res;
}

// string ConvertToBin(int num)
// {
//     string res = String.Empty;
//     while (num > 0)
//     {
//         res = num % 2 + res;
//         num = num / 2;
//     }
//     return res;
// }


int number = GetNum("десятичное");
string numberBin = ConvertToBin(number);
System.Console.WriteLine($"{number} -> {numberBin}");


