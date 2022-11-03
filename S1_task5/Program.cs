Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if(num>99 && num<1000)
{
    Console.WriteLine(num%10);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}