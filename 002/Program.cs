﻿// С клавиатуры вводятся два вещественных числа. 
// Проверять является ли одно из них квадратом второго.
int a,b;
string? s=Console.ReadLine(); // вводится строка и эту строчку нам надо запомнить
a=Convert.ToInt32(s); // преобразовали введенное число
s=Console.ReadLine(); // запоминаем введенную строчку
b=Convert.ToInt32(s);

if (a*a==b)
{
    System.Console.WriteLine("b является квадратом a");
}
else
{
    if (b*b==a)
    {
    System.Console.WriteLine("a является квадратом b");
    }
    else
    {
    System.Console.WriteLine("Числа не являются квадратами друг друга");
    }
    
}


