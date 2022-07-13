// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int a,b,c;
System.Console.WriteLine("Введите два числа");
string? s=System.Console.ReadLine();
a=Convert.ToInt32(s);
s=System.Console.ReadLine();
b=Convert.ToInt32(s);
if (a%b==0)
{
    System.Console.WriteLine($"Число {a} кратно {b}");
}
else
{
    c=a%b;
    System.Console.WriteLine($"Число {c} является остатком от деления {a} на {b}");
}
