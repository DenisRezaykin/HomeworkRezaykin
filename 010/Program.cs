// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
int a;
System.Console.WriteLine("Введите число");
string? s=System.Console.ReadLine();
a=Convert.ToInt32(s);
int c=a%10;
System.Console.WriteLine(c);

