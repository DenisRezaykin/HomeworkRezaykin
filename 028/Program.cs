// Определить количество цифр в числе. Сделать подпрограмму.
/* 1 вариант
int a;
System.Console.WriteLine("Введите число");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int k=0;
while (a!=0)
{
    a=a/10; k++;
}
System.Console.WriteLine($"{k}");
*/
// 2 вариант, с использованием подпрограммы

int CountDigits(int N)
{
    int k=0;
    while(N!=0)
    {
        k++;
        N=N/10;
    }
    return k;
}
System.Console.WriteLine(CountDigits(125));