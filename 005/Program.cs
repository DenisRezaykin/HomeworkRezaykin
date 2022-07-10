// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a,b,c;
System.Console.WriteLine("Введите три числа");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
s=Console.ReadLine();
c=Convert.ToInt32(s);
if (a>b)
{
    if (a>c)
    {
        System.Console.WriteLine("a является максимальным числом");
    }
    else
    {
        System.Console.WriteLine("c является максимальным числом");
    }
}
else
{
 if (b>c)
    {
        System.Console.WriteLine("b является максимальным числом");
    }
    else
    {
        System.Console.WriteLine("c является максимальным числом");
    }
}