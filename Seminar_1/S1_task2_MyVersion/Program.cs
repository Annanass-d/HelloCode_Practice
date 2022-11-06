System.Console.WriteLine("Enter number 1");
string strNumber1 = Console.ReadLine();
int num1 = Convert.ToInt32(strNumber1);

System.Console.WriteLine("Enter number 2");
string strNumber2 = Console.ReadLine();
int num2 = Convert.ToInt32(strNumber2);

if(num2*num2 == num1)
{
    System.Console.WriteLine($"Number {num1} is square of {num2}");
}
else
{
    System.Console.WriteLine($"Number {num1} is not square of {num2}");
}