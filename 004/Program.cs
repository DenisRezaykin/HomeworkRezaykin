﻿// По заданному с клавиатуры номеру дня недели вывести его название
/*
int a;
System.Console.WriteLine("Введите номер дня недели");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a==1)
{
    System.Console.WriteLine("Понедельник");
}
if (a==2)
{
    System.Console.WriteLine("Вторник");
}
if (a==3)
{
    System.Console.WriteLine("Среда");
}
if (a==4)
{
    System.Console.WriteLine("Четверг");
}
if (a==5)
{
    System.Console.WriteLine("Пятница");
}
if (a==6)
{
    System.Console.WriteLine("Суббота");
}
if (a==7)
{
    System.Console.WriteLine("Воскресенье");
}
*/

System.Console.WriteLine("Введите номер дня недели");
string? s=Console.ReadLine();
int a=Convert.ToInt32(s);
string?[] weekDays=new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
System.Console.WriteLine(weekDays[a-1]);