// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int a,b;
string? s=Console.ReadLine(); // вводится строка и эту строчку нам надо запомнить
a=Convert.ToInt32(s); // преобразовали введенное число
s=Console.ReadLine(); // запоминаем введенную строчку
b=Convert.ToInt32(s);
if (a>b)
{
    System.Console.WriteLine("a является максимальным числом");
}
else
{
    System.Console.WriteLine("b является максимальным числом");
}
