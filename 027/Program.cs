// Возведите число А в натуральную степень B используя цикл
// 1 вариант
/*System.Console.WriteLine("Введите число A и B");
int A=Convert.ToInt32(Console.ReadLine());
int B=Convert.ToInt32(Console.ReadLine());
double C=Math.Pow(A,B);
System.Console.WriteLine($"{A}^{B}={C}");
*/
// 2 вариант
Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);