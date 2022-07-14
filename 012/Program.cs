//С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int a;
System.Console.WriteLine("Введите число");
string? s=System.Console.ReadLine();
a=Convert.ToInt32(s);
int b=a%10;
int c=a/10%10;
if (b>c)
{
    System.Console.WriteLine(b);
}
else
{
    System.Console.WriteLine(c);
}