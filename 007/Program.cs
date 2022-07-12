int a;
System.Console.WriteLine("Введите число");
string? s=System.Console.ReadLine();
a=Convert.ToInt32(s);
if (a%2==0)
{
    System.Console.WriteLine("Введенное число четное");
}
else
{
     System.Console.WriteLine("Введенное число нечетное");
}
